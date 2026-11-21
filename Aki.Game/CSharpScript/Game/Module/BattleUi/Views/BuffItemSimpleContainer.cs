using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CF6 RID: 19702
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffItemSimpleContainer
	{
		// Token: 0x060315AD RID: 202157 RVA: 0x00DCA534 File Offset: 0x00DC8734
		public void Init(UUIItem buffParentItem, int maxItemCount = 6, bool isSmallContainer = false)
		{
			this.BuffParentItem = buffParentItem;
			this.MaxItemCount = maxItemCount;
			this.IsSmallContainer = isSmallContainer;
		}

		// Token: 0x060315AE RID: 202158 RVA: 0x00DCA54C File Offset: 0x00DC874C
		public void Tick(float delta)
		{
			int frame = Time.Instance.Frame;
			if (frame < this.NextTickFrame)
			{
				return;
			}
			if (this.BuffItemInfoList.Count > 6)
			{
				this.NextTickFrame = frame + 2;
			}
			foreach (BuffItemInfo buffItemInfo in this.BuffItemInfoList)
			{
				BuffItemBase buffItem = buffItemInfo.BuffItem;
				if (buffItem == null)
				{
					break;
				}
				buffItem.Tick(delta);
			}
			for (int i = this.HidingBuffItemList.Count - 1; i >= 0; i--)
			{
				BuffItemBase buffItemBase = this.HidingBuffItemList[i];
				if (!buffItemBase.TickHiding(delta))
				{
					this.HidingBuffItemList.RemoveAt(i);
					buffItemBase.GetRootItem().SetHierarchyIndex(this.BuffItemInfoList.Count + this.HidingBuffItemList.Count);
					this.HiddenBuffItemPool.RecycleBuffItem(buffItemBase);
				}
			}
		}

		// Token: 0x060315AF RID: 202159 RVA: 0x00DCA644 File Offset: 0x00DC8844
		public void RefreshBuff(List<long> buffIds)
		{
			this.ClearAll();
			foreach (long buffId in buffIds)
			{
				this.AddBuffByBuffId(buffId);
			}
		}

		// Token: 0x060315B0 RID: 202160 RVA: 0x00DCA698 File Offset: 0x00DC8898
		public void AddBuffByBuffId(long buffId)
		{
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
			if (((buffDefinition != null) ? buffDefinition.GameplayCueIds : null) == null)
			{
				return;
			}
			long[] gameplayCueIds = buffDefinition.GameplayCueIds;
			for (int i = 0; i < gameplayCueIds.Length; i++)
			{
				GameplayCue? configById = GameplayCueController.GetConfigById(gameplayCueIds[i]);
				if (configById != null)
				{
					GameplayCue value = configById.Value;
					this.AddBuffByCue(value, buffId, false);
				}
			}
		}

		// Token: 0x060315B1 RID: 202161 RVA: 0x00DCA6FC File Offset: 0x00DC88FC
		public void AddBuffByCue(in GameplayCue buffCueConfig, long handleId, bool playAnim = false)
		{
			if (!this.CheckCanShow(buffCueConfig))
			{
				return;
			}
			GameplayCue gameplayCue = buffCueConfig;
			long id = gameplayCue.Id;
			BuffItemInfo buffItemInfo;
			if (this.StateBuffItemInfoMap.TryGetValue(id, out buffItemInfo))
			{
				buffItemInfo.BuffHandleSet.Add(handleId);
				return;
			}
			buffItemInfo = this.NewBuffItemInfo(buffCueConfig);
			buffItemInfo.BuffHandleSet.Add(handleId);
			this.StateBuffItemInfoMap[id] = buffItemInfo;
			this.AddBuffItemInfo(buffItemInfo, playAnim);
		}

		// Token: 0x060315B2 RID: 202162 RVA: 0x00DCA774 File Offset: 0x00DC8974
		private bool CheckCanShow(GameplayCue buffCueConfig)
		{
			return !this.IsSmallContainer || buffCueConfig.ParametersLength <= 4 || !(buffCueConfig.Parameters(4) == "1");
		}

		// Token: 0x060315B3 RID: 202163 RVA: 0x00DCA7A0 File Offset: 0x00DC89A0
		public void RemoveBuffByBuffId(long buffId)
		{
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
			if (((buffDefinition != null) ? buffDefinition.GameplayCueIds : null) == null)
			{
				return;
			}
			long[] gameplayCueIds = buffDefinition.GameplayCueIds;
			for (int i = 0; i < gameplayCueIds.Length; i++)
			{
				GameplayCue? configById = GameplayCueController.GetConfigById(gameplayCueIds[i]);
				if (configById != null)
				{
					this.RemoveBuffByCue(configById.Value, buffId, false);
				}
			}
		}

		// Token: 0x060315B4 RID: 202164 RVA: 0x00DCA800 File Offset: 0x00DC8A00
		public void RemoveBuffByCue(GameplayCue buffCueConfig, long handleId, bool playAnim = false)
		{
			long id = buffCueConfig.Id;
			BuffItemInfo buffItemInfo;
			if (!this.StateBuffItemInfoMap.TryGetValue(id, out buffItemInfo))
			{
				return;
			}
			if (!buffItemInfo.BuffHandleSet.Contains(handleId))
			{
				return;
			}
			buffItemInfo.BuffHandleSet.Remove(handleId);
			if (buffItemInfo.BuffHandleSet.Count <= 0)
			{
				this.StateBuffItemInfoMap.Remove(id);
				this.RemoveBuffItemInfo(buffItemInfo, playAnim);
			}
		}

		// Token: 0x060315B5 RID: 202165 RVA: 0x00DCA868 File Offset: 0x00DC8A68
		private BuffItemInfo NewBuffItemInfo(GameplayCue buffCueConfig)
		{
			BuffItemInfo buffItemInfo = (this.BuffItemInfoPool.Count > 0) ? this.BuffItemInfoPool.Pop<BuffItemInfo>() : new BuffItemInfo();
			buffItemInfo.SortId = BuffItemInfo.GenSortId();
			buffItemInfo.Priority = buffCueConfig.Priority;
			buffItemInfo.BuffCueConfig = new GameplayCue?(buffCueConfig);
			return buffItemInfo;
		}

		// Token: 0x060315B6 RID: 202166 RVA: 0x00DCA8B9 File Offset: 0x00DC8AB9
		private void RecycleBuffItemInfo(BuffItemInfo buffItemInfo)
		{
			buffItemInfo.Clear();
			this.BuffItemInfoPool.Add(buffItemInfo);
		}

		// Token: 0x060315B7 RID: 202167 RVA: 0x00DCA8D0 File Offset: 0x00DC8AD0
		private void AddBuffItemInfo(BuffItemInfo buffItemInfo, bool playAnim = false)
		{
			int num = this.InsertBuffItemInfo(buffItemInfo);
			if (num < this.MaxItemCount)
			{
				if (this.BuffItemInfoList.Count > this.MaxItemCount)
				{
					this.DeactivateBuffItem(this.BuffItemInfoList[this.MaxItemCount], false);
				}
				buffItemInfo.BuffItem = this.NewBuffItem(buffItemInfo.BuffCueConfig);
				this.ActivateBuffItem(buffItemInfo, num, playAnim);
			}
		}

		// Token: 0x060315B8 RID: 202168 RVA: 0x00DCA934 File Offset: 0x00DC8B34
		private int InsertBuffItemInfo(BuffItemInfo newInfo)
		{
			int count = this.BuffItemInfoList.Count;
			for (int i = 0; i < count; i++)
			{
				if (BuffItemInfo.Compare(this.BuffItemInfoList[i], newInfo) >= 0)
				{
					this.BuffItemInfoList.Insert(i, newInfo);
					return i;
				}
			}
			this.BuffItemInfoList.Add(newInfo);
			return count;
		}

		// Token: 0x060315B9 RID: 202169 RVA: 0x00DCA98C File Offset: 0x00DC8B8C
		private void RemoveBuffItemInfo(BuffItemInfo buffItemInfo, bool playAnim = false)
		{
			int num = this.BuffItemInfoList.IndexOf(buffItemInfo);
			if (num < 0)
			{
				return;
			}
			this.BuffItemInfoList.RemoveAt(num);
			if (num < this.MaxItemCount)
			{
				this.DeactivateBuffItem(buffItemInfo, playAnim);
				if (this.BuffItemInfoList.Count >= this.MaxItemCount)
				{
					BuffItemInfo buffItemInfo2 = this.BuffItemInfoList[this.MaxItemCount - 1];
					if (buffItemInfo2.BuffItem != null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.CFT;
						string message = "有残留的buffItem引用";
						string item = "cueId";
						BuffItemInfo buffItemInfo3 = buffItemInfo2;
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (buffItemInfo3.BuffCueConfig != null) ? new long?(buffItemInfo3.BuffCueConfig.GetValueOrDefault().Id) : null);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					buffItemInfo2.BuffItem = this.NewBuffItem(buffItemInfo2.BuffCueConfig);
					this.ActivateBuffItem(buffItemInfo2, this.MaxItemCount - 1, false);
				}
			}
			this.RecycleBuffItemInfo(buffItemInfo);
		}

		// Token: 0x060315BA RID: 202170 RVA: 0x00DCAA7E File Offset: 0x00DC8C7E
		private BuffItemBase NewBuffItem(GameplayCue? cueConfig)
		{
			return this.HiddenBuffItemPool.GetBuffItem(this.BuffParentItem, cueConfig);
		}

		// Token: 0x060315BB RID: 202171 RVA: 0x00DCAA94 File Offset: 0x00DC8C94
		private void ActivateBuffItem(BuffItemInfo buffItemInfo, int index, bool playAnim = false)
		{
			BuffItemBase buffItem = buffItemInfo.BuffItem;
			buffItem.Activate(buffItemInfo.BuffCueConfig.Value, buffItemInfo.SingleBuff, playAnim, 0);
			if (index <= 0)
			{
				buffItem.GetRootItem().SetHierarchyIndex(0);
				return;
			}
			BuffItemBase buffItem2 = this.BuffItemInfoList[index - 1].BuffItem;
			if (buffItem2 != null)
			{
				buffItem.GetRootItem().SetHierarchyIndex(buffItem2.GetRootItem().GetHierarchyIndex() + 1);
				return;
			}
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "要插入的buff图标前面的buff没有buffItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060315BC RID: 202172 RVA: 0x00DCAB20 File Offset: 0x00DC8D20
		public void DeactivateBuffItem(BuffItemInfo buffItemInfo, bool playAnim = false)
		{
			BuffItemBase buffItem = buffItemInfo.BuffItem;
			if (buffItem == null)
			{
				return;
			}
			buffItemInfo.BuffItem = null;
			if (playAnim)
			{
				buffItem.DeactivateWithCloseAnim();
				this.HidingBuffItemList.Add(buffItem);
				return;
			}
			buffItem.Deactivate();
			buffItem.GetRootItem().SetHierarchyIndex(this.BuffItemInfoList.Count + this.HidingBuffItemList.Count);
			this.HiddenBuffItemPool.RecycleBuffItem(buffItem);
		}

		// Token: 0x060315BD RID: 202173 RVA: 0x00DCAB8C File Offset: 0x00DC8D8C
		public void ClearAll()
		{
			foreach (BuffItemInfo buffItemInfo in this.BuffItemInfoList)
			{
				BuffItemBase buffItem = buffItemInfo.BuffItem;
				if (buffItem != null)
				{
					buffItem.DestroyCompatible();
				}
			}
			this.BuffItemInfoList.Clear();
			this.StateBuffItemInfoMap.Clear();
			this.BuffItemInfoPool.Clear();
			foreach (BuffItemBase buffItemBase in this.HidingBuffItemList)
			{
				buffItemBase.Deactivate();
				buffItemBase.DestroyCompatible();
			}
			this.HidingBuffItemList.Clear();
			this.HiddenBuffItemPool.Clear();
			this.NextTickFrame = 0;
		}

		// Token: 0x0401A23B RID: 107067
		private const int MAX_ITEM_COUNT = 6;

		// Token: 0x0401A23C RID: 107068
		private const int TICK_INTERVAL_FRAME_AT_MORE = 2;

		// Token: 0x0401A23D RID: 107069
		private readonly List<BuffItemInfo> BuffItemInfoList = new List<BuffItemInfo>();

		// Token: 0x0401A23E RID: 107070
		private readonly Dictionary<long, BuffItemInfo> StateBuffItemInfoMap = new Dictionary<long, BuffItemInfo>();

		// Token: 0x0401A23F RID: 107071
		private readonly List<BuffItemInfo> BuffItemInfoPool = new List<BuffItemInfo>();

		// Token: 0x0401A240 RID: 107072
		private readonly List<BuffItemBase> HidingBuffItemList = new List<BuffItemBase>();

		// Token: 0x0401A241 RID: 107073
		private readonly BuffItemPool HiddenBuffItemPool = new BuffItemPool();

		// Token: 0x0401A242 RID: 107074
		[Nullable(2)]
		private UUIItem BuffParentItem;

		// Token: 0x0401A243 RID: 107075
		private int MaxItemCount;

		// Token: 0x0401A244 RID: 107076
		private bool IsSmallContainer;

		// Token: 0x0401A245 RID: 107077
		private int NextTickFrame;
	}
}
