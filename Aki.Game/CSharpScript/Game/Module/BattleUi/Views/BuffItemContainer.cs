using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CF3 RID: 19699
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffItemContainer
	{
		// Token: 0x06031593 RID: 202131 RVA: 0x00DC9948 File Offset: 0x00DC7B48
		public void Init(UUIItem buffParentItem, int maxItemCount = 6, bool isSmallContainer = false, bool isPlayer = false, bool isRoleBuff = false, [Nullable(2)] UUIItem exceedTipItem = null)
		{
			this.BuffParentItem = buffParentItem;
			this.MaxItemCount = maxItemCount;
			this.IsSmallContainer = isSmallContainer;
			this.IsPlayer = isPlayer;
			this.IsRoleBuff = isRoleBuff;
			this.ExceedTipItem = exceedTipItem;
			this.RefreshExceedTipItemVisible();
		}

		// Token: 0x06031594 RID: 202132 RVA: 0x00DC9980 File Offset: 0x00DC7B80
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

		// Token: 0x06031595 RID: 202133 RVA: 0x00DC9A78 File Offset: 0x00DC7C78
		[NullableContext(2)]
		public void RefreshBuff(EntityHandle entityHandle)
		{
			this.ClearAll();
			if (entityHandle == null || !entityHandle.IsInit)
			{
				this.BuffComponent = null;
				this.RoleBuffComponent = null;
				return;
			}
			this.BuffComponent = entityHandle.Entity.GetComponent<CharacterBuffComponent>();
			this.RoleBuffComponent = entityHandle.Entity.GetComponent<RoleBuffComponent>();
			CharacterGameplayCueComponent component = entityHandle.Entity.GetComponent<CharacterGameplayCueComponent>();
			this.AddBuffByCueComp(component);
			if (!this.IsPlayer)
			{
				return;
			}
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
			PlayerGameplayCueComponent playerGameplayCueComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerGameplayCueComponent>() : null;
			if (playerGameplayCueComponent != null)
			{
				this.AddBuffByCueComp(playerGameplayCueComponent);
			}
		}

		// Token: 0x06031596 RID: 202134 RVA: 0x00DC9B14 File Offset: 0x00DC7D14
		private void AddBuffByCueComp(BaseGameplayCueComponent cueComp)
		{
			foreach (GameplayCueBase gameplayCueBase in cueComp.GetAllCurrentCueRef())
			{
				GameplayCue cueConfig = gameplayCueBase.CueConfig;
				ECueType cueType = (ECueType)cueConfig.CueType;
				if (cueType == ECueType.UITexture || cueType == ECueType.StateUITexture || cueType == ECueType.RoleUITexture || cueType == ECueType.CustomStyleUITexture)
				{
					this.AddBuffByCue(cueConfig, gameplayCueBase.BuffHandleId, false);
				}
			}
		}

		// Token: 0x06031597 RID: 202135 RVA: 0x00DC9B8C File Offset: 0x00DC7D8C
		public void AddBuffByCue(GameplayCue buffCueConfig, int handleId, bool playAnim = false)
		{
			ECueType cueType = (ECueType)buffCueConfig.CueType;
			if (cueType == ECueType.UITexture && !this.IsRoleBuff)
			{
				if (!this.CheckCanShow(buffCueConfig))
				{
					return;
				}
				if (this.BuffItemInfoMap.ContainsKey(handleId))
				{
					return;
				}
				IActiveBuff buffByHandleId = this.GetBuffByHandleId(handleId);
				if (buffByHandleId == null)
				{
					return;
				}
				BuffItemInfo buffItemInfo = this.NewBuffItemInfo(buffCueConfig);
				buffItemInfo.SingleBuff = buffByHandleId;
				this.BuffItemInfoMap[handleId] = buffItemInfo;
				this.AddBuffItemInfo(buffItemInfo, playAnim);
				return;
			}
			else if (cueType == ECueType.StateUITexture && !this.IsRoleBuff)
			{
				if (!this.CheckCanShow(buffCueConfig))
				{
					return;
				}
				long id = buffCueConfig.Id;
				BuffItemInfo buffItemInfo2;
				if (!this.StateBuffItemInfoMap.TryGetValue(id, out buffItemInfo2))
				{
					buffItemInfo2 = this.NewBuffItemInfo(buffCueConfig);
					buffItemInfo2.BuffHandleSet.Add((long)handleId);
					this.StateBuffItemInfoMap[id] = buffItemInfo2;
					this.AddBuffItemInfo(buffItemInfo2, playAnim);
					return;
				}
				if (!buffItemInfo2.BuffHandleSet.Add((long)handleId))
				{
					return;
				}
				if (buffItemInfo2.BuffItem != null)
				{
					buffItemInfo2.BuffItem.SetNum(buffItemInfo2.BuffHandleSet.Count);
					if (playAnim && this.BuffItemInfoList.IndexOf(buffItemInfo2) < this.MaxItemCount)
					{
						buffItemInfo2.BuffItem.PlayAddBuffAnim();
					}
				}
				return;
			}
			else
			{
				if (cueType != ECueType.RoleUITexture || !this.IsRoleBuff)
				{
					if (cueType == ECueType.CustomStyleUITexture && !this.IsRoleBuff)
					{
						if (this.BuffItemInfoMap.ContainsKey(handleId))
						{
							return;
						}
						IActiveBuff buffByHandleId2 = this.GetBuffByHandleId(handleId);
						if (buffByHandleId2 == null)
						{
							return;
						}
						BuffItemInfo buffItemInfo3 = this.NewBuffItemInfo(buffCueConfig);
						buffItemInfo3.SingleBuff = buffByHandleId2;
						this.BuffItemInfoMap[handleId] = buffItemInfo3;
						this.AddBuffItemInfo(buffItemInfo3, playAnim);
					}
					return;
				}
				if (!this.CheckCanShow(buffCueConfig))
				{
					return;
				}
				if (this.BuffItemInfoMap.ContainsKey(handleId))
				{
					return;
				}
				IActiveBuff buffByHandleId3 = this.GetBuffByHandleId(handleId);
				if (buffByHandleId3 == null)
				{
					return;
				}
				BuffItemInfo buffItemInfo4 = this.NewBuffItemInfo(buffCueConfig);
				buffItemInfo4.SingleBuff = buffByHandleId3;
				this.BuffItemInfoMap[handleId] = buffItemInfo4;
				this.AddBuffItemInfo(buffItemInfo4, playAnim);
				return;
			}
		}

		// Token: 0x06031598 RID: 202136 RVA: 0x00DC9D64 File Offset: 0x00DC7F64
		private bool CheckCanShow(GameplayCue buffCueConfig)
		{
			return !this.IsSmallContainer || buffCueConfig.ParametersLength <= 4 || !(buffCueConfig.Parameters(4) == "1");
		}

		// Token: 0x06031599 RID: 202137 RVA: 0x00DC9D90 File Offset: 0x00DC7F90
		public void RemoveBuffByCue(in GameplayCue buffCueConfig, int handleId, bool playAnim = false)
		{
			GameplayCue gameplayCue = buffCueConfig;
			ECueType cueType = (ECueType)gameplayCue.CueType;
			if (cueType != ECueType.UITexture && cueType != ECueType.RoleUITexture && cueType != ECueType.CustomStyleUITexture)
			{
				if (cueType == ECueType.StateUITexture)
				{
					gameplayCue = buffCueConfig;
					long id = gameplayCue.Id;
					BuffItemInfo buffItemInfo;
					if (!this.StateBuffItemInfoMap.TryGetValue(id, out buffItemInfo))
					{
						return;
					}
					if (!buffItemInfo.BuffHandleSet.Remove((long)handleId))
					{
						return;
					}
					if (buffItemInfo.BuffHandleSet.Count <= 0)
					{
						this.StateBuffItemInfoMap.Remove(id);
						this.RemoveBuffItemInfo(buffItemInfo, playAnim);
						return;
					}
					if (buffItemInfo.BuffItem != null)
					{
						buffItemInfo.BuffItem.SetNum(buffItemInfo.BuffHandleSet.Count);
					}
				}
				return;
			}
			BuffItemInfo buffItemInfo2;
			if (!this.BuffItemInfoMap.Remove(handleId, out buffItemInfo2))
			{
				return;
			}
			this.RemoveBuffItemInfo(buffItemInfo2, playAnim);
		}

		// Token: 0x0603159A RID: 202138 RVA: 0x00DC9E54 File Offset: 0x00DC8054
		private BuffItemInfo NewBuffItemInfo(GameplayCue buffCueConfig)
		{
			BuffItemInfo buffItemInfo = (this.BuffItemInfoPool.Count > 0) ? this.BuffItemInfoPool.Pop<BuffItemInfo>() : new BuffItemInfo();
			buffItemInfo.SortId = BuffItemInfo.GenSortId();
			buffItemInfo.Priority = buffCueConfig.Priority;
			buffItemInfo.BuffCueConfig = new GameplayCue?(buffCueConfig);
			return buffItemInfo;
		}

		// Token: 0x0603159B RID: 202139 RVA: 0x00DC9EA5 File Offset: 0x00DC80A5
		private void RecycleBuffItemInfo(BuffItemInfo buffItemInfo)
		{
			buffItemInfo.Clear();
			this.BuffItemInfoPool.Add(buffItemInfo);
		}

		// Token: 0x0603159C RID: 202140 RVA: 0x00DC9EBC File Offset: 0x00DC80BC
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
			this.RefreshExceedTipItemVisible();
		}

		// Token: 0x0603159D RID: 202141 RVA: 0x00DC9F28 File Offset: 0x00DC8128
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

		// Token: 0x0603159E RID: 202142 RVA: 0x00DC9F80 File Offset: 0x00DC8180
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
			this.RefreshExceedTipItemVisible();
		}

		// Token: 0x0603159F RID: 202143 RVA: 0x00DCA078 File Offset: 0x00DC8278
		[NullableContext(2)]
		private IActiveBuff GetBuffByHandleId(int handleId)
		{
			IActiveBuff buffByHandle;
			if ((buffByHandle = this.BuffComponent.GetBuffByHandle(handleId)) == null)
			{
				RoleBuffComponent roleBuffComponent = this.RoleBuffComponent;
				if (roleBuffComponent == null)
				{
					return null;
				}
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				if (formationBuffComp == null)
				{
					return null;
				}
				buffByHandle = formationBuffComp.GetBuffByHandle(handleId);
			}
			return buffByHandle;
		}

		// Token: 0x060315A0 RID: 202144 RVA: 0x00DCA0A7 File Offset: 0x00DC82A7
		private BuffItemBase NewBuffItem(GameplayCue? cueConfig)
		{
			return this.HiddenBuffItemPool.GetBuffItem(this.BuffParentItem, cueConfig);
		}

		// Token: 0x060315A1 RID: 202145 RVA: 0x00DCA0BC File Offset: 0x00DC82BC
		private void ActivateBuffItem(BuffItemInfo buffItemInfo, int index, bool playAnim = false)
		{
			BuffItemBase buffItem = buffItemInfo.BuffItem;
			buffItem.Activate(buffItemInfo.BuffCueConfig.Value, buffItemInfo.SingleBuff, playAnim, buffItemInfo.BuffHandleSet.Count);
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

		// Token: 0x060315A2 RID: 202146 RVA: 0x00DCA150 File Offset: 0x00DC8350
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

		// Token: 0x060315A3 RID: 202147 RVA: 0x00DCA1B9 File Offset: 0x00DC83B9
		private void RefreshExceedTipItemVisible()
		{
			UUIItem exceedTipItem = this.ExceedTipItem;
			if (exceedTipItem == null)
			{
				return;
			}
			exceedTipItem.SetUIActive(this.BuffItemInfoList.Count > this.MaxItemCount);
		}

		// Token: 0x060315A4 RID: 202148 RVA: 0x00DCA1E0 File Offset: 0x00DC83E0
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
			this.BuffItemInfoMap.Clear();
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

		// Token: 0x0401A226 RID: 107046
		private const int MAX_ITEM_COUNT = 6;

		// Token: 0x0401A227 RID: 107047
		private const int TICK_INTERVAL_FRAME_AT_MORE = 2;

		// Token: 0x0401A228 RID: 107048
		private readonly List<BuffItemInfo> BuffItemInfoList = new List<BuffItemInfo>();

		// Token: 0x0401A229 RID: 107049
		private readonly Dictionary<int, BuffItemInfo> BuffItemInfoMap = new Dictionary<int, BuffItemInfo>();

		// Token: 0x0401A22A RID: 107050
		private readonly Dictionary<long, BuffItemInfo> StateBuffItemInfoMap = new Dictionary<long, BuffItemInfo>();

		// Token: 0x0401A22B RID: 107051
		private readonly List<BuffItemInfo> BuffItemInfoPool = new List<BuffItemInfo>();

		// Token: 0x0401A22C RID: 107052
		private readonly List<BuffItemBase> HidingBuffItemList = new List<BuffItemBase>();

		// Token: 0x0401A22D RID: 107053
		private readonly BuffItemPool HiddenBuffItemPool = new BuffItemPool();

		// Token: 0x0401A22E RID: 107054
		[Nullable(2)]
		private UUIItem BuffParentItem;

		// Token: 0x0401A22F RID: 107055
		private int MaxItemCount;

		// Token: 0x0401A230 RID: 107056
		private bool IsSmallContainer;

		// Token: 0x0401A231 RID: 107057
		private bool IsPlayer;

		// Token: 0x0401A232 RID: 107058
		private bool IsRoleBuff;

		// Token: 0x0401A233 RID: 107059
		[Nullable(2)]
		private UUIItem ExceedTipItem;

		// Token: 0x0401A234 RID: 107060
		[Nullable(2)]
		private CharacterBuffComponent BuffComponent;

		// Token: 0x0401A235 RID: 107061
		[Nullable(2)]
		private RoleBuffComponent RoleBuffComponent;

		// Token: 0x0401A236 RID: 107062
		private int NextTickFrame;
	}
}
