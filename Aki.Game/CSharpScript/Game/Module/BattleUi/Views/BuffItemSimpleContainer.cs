using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D14 RID: 23828
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffItemSimpleContainer
	{
		// Token: 0x0603C654 RID: 247380 RVA: 0x00E79EB4 File Offset: 0x00E780B4
		public void Init(UUIItem buffParentItem, int maxItemCount = 6, bool isSmallContainer = false)
		{
			this.BuffParentItem = buffParentItem;
			this.MaxItemCount = maxItemCount;
			this.IsSmallContainer = isSmallContainer;
		}

		// Token: 0x0603C655 RID: 247381 RVA: 0x00E79ECC File Offset: 0x00E780CC
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

		// Token: 0x0603C656 RID: 247382 RVA: 0x00E79FC4 File Offset: 0x00E781C4
		public void RefreshBuff(List<long> buffIds)
		{
			this.ClearAll();
			foreach (long buffId in buffIds)
			{
				this.AddBuffByBuffId(buffId);
			}
		}

		// Token: 0x0603C657 RID: 247383 RVA: 0x00E7A018 File Offset: 0x00E78218
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

		// Token: 0x0603C658 RID: 247384 RVA: 0x00E7A07C File Offset: 0x00E7827C
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

		// Token: 0x0603C659 RID: 247385 RVA: 0x00E7A0F4 File Offset: 0x00E782F4
		private bool CheckCanShow(GameplayCue buffCueConfig)
		{
			return !this.IsSmallContainer || buffCueConfig.ParametersLength <= 4 || !(buffCueConfig.Parameters(4) == "1");
		}

		// Token: 0x0603C65A RID: 247386 RVA: 0x00E7A120 File Offset: 0x00E78320
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

		// Token: 0x0603C65B RID: 247387 RVA: 0x00E7A180 File Offset: 0x00E78380
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

		// Token: 0x0603C65C RID: 247388 RVA: 0x00E7A1E8 File Offset: 0x00E783E8
		private BuffItemInfo NewBuffItemInfo(GameplayCue buffCueConfig)
		{
			BuffItemInfo buffItemInfo = (this.BuffItemInfoPool.Count > 0) ? this.BuffItemInfoPool.Pop<BuffItemInfo>() : new BuffItemInfo();
			buffItemInfo.SortId = BuffItemInfo.GenSortId();
			buffItemInfo.Priority = buffCueConfig.Priority;
			buffItemInfo.BuffCueConfig = new GameplayCue?(buffCueConfig);
			return buffItemInfo;
		}

		// Token: 0x0603C65D RID: 247389 RVA: 0x00E7A239 File Offset: 0x00E78439
		private void RecycleBuffItemInfo(BuffItemInfo buffItemInfo)
		{
			buffItemInfo.Clear();
			this.BuffItemInfoPool.Add(buffItemInfo);
		}

		// Token: 0x0603C65E RID: 247390 RVA: 0x00E7A250 File Offset: 0x00E78450
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

		// Token: 0x0603C65F RID: 247391 RVA: 0x00E7A2B4 File Offset: 0x00E784B4
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

		// Token: 0x0603C660 RID: 247392 RVA: 0x00E7A30C File Offset: 0x00E7850C
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

		// Token: 0x0603C661 RID: 247393 RVA: 0x00E7A3FE File Offset: 0x00E785FE
		private BuffItemBase NewBuffItem(GameplayCue? cueConfig)
		{
			return this.HiddenBuffItemPool.GetBuffItem(this.BuffParentItem, cueConfig);
		}

		// Token: 0x0603C662 RID: 247394 RVA: 0x00E7A414 File Offset: 0x00E78614
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

		// Token: 0x0603C663 RID: 247395 RVA: 0x00E7A4A0 File Offset: 0x00E786A0
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

		// Token: 0x0603C664 RID: 247396 RVA: 0x00E7A50C File Offset: 0x00E7870C
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

		// Token: 0x0401F782 RID: 128898
		private const int MAX_ITEM_COUNT = 6;

		// Token: 0x0401F783 RID: 128899
		private const int TICK_INTERVAL_FRAME_AT_MORE = 2;

		// Token: 0x0401F784 RID: 128900
		private readonly List<BuffItemInfo> BuffItemInfoList = new List<BuffItemInfo>();

		// Token: 0x0401F785 RID: 128901
		private readonly Dictionary<long, BuffItemInfo> StateBuffItemInfoMap = new Dictionary<long, BuffItemInfo>();

		// Token: 0x0401F786 RID: 128902
		private readonly List<BuffItemInfo> BuffItemInfoPool = new List<BuffItemInfo>();

		// Token: 0x0401F787 RID: 128903
		private readonly List<BuffItemBase> HidingBuffItemList = new List<BuffItemBase>();

		// Token: 0x0401F788 RID: 128904
		private readonly BuffItemPool HiddenBuffItemPool = new BuffItemPool();

		// Token: 0x0401F789 RID: 128905
		[Nullable(2)]
		private UUIItem BuffParentItem;

		// Token: 0x0401F78A RID: 128906
		private int MaxItemCount;

		// Token: 0x0401F78B RID: 128907
		private bool IsSmallContainer;

		// Token: 0x0401F78C RID: 128908
		private int NextTickFrame;
	}
}
