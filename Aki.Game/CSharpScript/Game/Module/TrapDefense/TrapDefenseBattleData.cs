using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Module.TowerDefenseEvent;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A1F RID: 18975
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBattleData : ISkillButtonUiEventInterface
	{
		// Token: 0x06031418 RID: 201752 RVA: 0x00B6C7C6 File Offset: 0x00B6A9C6
		public static TrapDefenseBattleData Create()
		{
			TrapDefenseBattleData trapDefenseBattleData = new TrapDefenseBattleData();
			trapDefenseBattleData.Init();
			return trapDefenseBattleData;
		}

		// Token: 0x06031419 RID: 201753 RVA: 0x00B6C7D3 File Offset: 0x00B6A9D3
		private void Init()
		{
		}

		// Token: 0x0603141A RID: 201754 RVA: 0x00B6C7D8 File Offset: 0x00B6A9D8
		private void AddTempTreeVarDelegate(ETrapDefenseSystemVarType key, TTreeVarUpdateDelegate @delegate)
		{
			HashSet<TTreeVarUpdateDelegate> hashSet;
			if (!this.TempTreeVarDelegateMap.TryGetValue(key, out hashSet))
			{
				hashSet = new HashSet<TTreeVarUpdateDelegate>();
				this.TempTreeVarDelegateMap[key] = hashSet;
			}
			hashSet.Add(@delegate);
		}

		// Token: 0x0603141B RID: 201755 RVA: 0x00B6C810 File Offset: 0x00B6AA10
		private void RemoveTempTreeVarDelegate(ETrapDefenseSystemVarType key, TTreeVarUpdateDelegate @delegate)
		{
			HashSet<TTreeVarUpdateDelegate> hashSet;
			if (this.TempTreeVarDelegateMap.TryGetValue(key, out hashSet))
			{
				hashSet.Remove(@delegate);
			}
		}

		// Token: 0x0603141C RID: 201756 RVA: 0x00B6C835 File Offset: 0x00B6AA35
		private void ClearTempTreeVarDelegate()
		{
			this.TempTreeVarDelegateMap.Clear();
		}

		// Token: 0x0603141D RID: 201757 RVA: 0x00B6C842 File Offset: 0x00B6AA42
		public void Clear()
		{
			this.BehaviorTreeVarMap.Clear();
			this.TechParamMap.Clear();
			this.BattleSkillData.Clear();
			this.ClearTempTreeVarDelegate();
		}

		// Token: 0x0603141E RID: 201758 RVA: 0x00B6C86C File Offset: 0x00B6AA6C
		public void AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType key, TTreeVarUpdateDelegate @delegate)
		{
			InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
			if (instanceDungeonInfo == null || instanceDungeonInfo.Tree == null)
			{
				return;
			}
			string key2;
			if (this.BehaviorTreeVarMap.TryGetValue(key, out key2))
			{
				instanceDungeonInfo.Tree.AddTreeVarUpdateDelegate(key2, @delegate);
				return;
			}
			this.AddTempTreeVarDelegate(key, @delegate);
		}

		// Token: 0x0603141F RID: 201759 RVA: 0x00B6C8B8 File Offset: 0x00B6AAB8
		public void RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType key, TTreeVarUpdateDelegate @delegate)
		{
			InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
			if (instanceDungeonInfo == null || instanceDungeonInfo.Tree == null)
			{
				return;
			}
			string key2;
			if (this.BehaviorTreeVarMap.TryGetValue(key, out key2))
			{
				instanceDungeonInfo.Tree.RemoveTreeVarUpdateDelegate(key2, @delegate);
				return;
			}
			this.RemoveTempTreeVarDelegate(key, @delegate);
		}

		// Token: 0x06031420 RID: 201760 RVA: 0x00B6C904 File Offset: 0x00B6AB04
		public void SetBehaviorTreeVar(Dictionary<string, string> variableKeyNames)
		{
			this.BehaviorTreeVarMap.Clear();
			InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
			foreach (KeyValuePair<string, string> keyValuePair in variableKeyNames)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string value = text;
				string text3 = text2;
				ETrapDefenseSystemVarType key = (ETrapDefenseSystemVarType)Enum.Parse(typeof(ETrapDefenseSystemVarType), value);
				this.BehaviorTreeVarMap[key] = text3;
				HashSet<TTreeVarUpdateDelegate> hashSet;
				if (this.TempTreeVarDelegateMap.TryGetValue(key, out hashSet) && instanceDungeonInfo != null && instanceDungeonInfo.Tree != null)
				{
					foreach (TTreeVarUpdateDelegate ttreeVarUpdateDelegate in hashSet)
					{
						instanceDungeonInfo.Tree.AddTreeVarUpdateDelegate(text3, ttreeVarUpdateDelegate);
						ttreeVarUpdateDelegate(null, instanceDungeonInfo.Tree.GetTreeVarByKey(text3));
					}
					this.TempTreeVarDelegateMap.Remove(key);
				}
			}
		}

		// Token: 0x06031421 RID: 201761 RVA: 0x00B6CA24 File Offset: 0x00B6AC24
		[NullableContext(2)]
		private VarDefinePb GetBehaviorTreeVar(ETrapDefenseSystemVarType key)
		{
			string key2;
			if (!this.BehaviorTreeVarMap.TryGetValue(key, out key2))
			{
				return null;
			}
			InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
			if (instanceDungeonInfo == null)
			{
				return null;
			}
			BaseBehaviorTree tree = instanceDungeonInfo.Tree;
			if (tree == null)
			{
				return null;
			}
			return tree.GetTreeVarByKey(key2);
		}

		// Token: 0x06031422 RID: 201762 RVA: 0x00B6CA65 File Offset: 0x00B6AC65
		public long GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType key)
		{
			VarDefinePb behaviorTreeVar = this.GetBehaviorTreeVar(key);
			if (behaviorTreeVar == null)
			{
				return 0L;
			}
			return behaviorTreeVar.Int;
		}

		// Token: 0x06031423 RID: 201763 RVA: 0x00B6CA7A File Offset: 0x00B6AC7A
		public long GetGoldNum()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.Gold);
		}

		// Token: 0x06031424 RID: 201764 RVA: 0x00B6CA83 File Offset: 0x00B6AC83
		public long GetHealth()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.Health);
		}

		// Token: 0x06031425 RID: 201765 RVA: 0x00B6CA8C File Offset: 0x00B6AC8C
		public int GetBatch()
		{
			return (int)this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.Batch);
		}

		// Token: 0x06031426 RID: 201766 RVA: 0x00B6CA96 File Offset: 0x00B6AC96
		public long GetMaxBatch()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.MaxBatch);
		}

		// Token: 0x06031427 RID: 201767 RVA: 0x00B6CA9F File Offset: 0x00B6AC9F
		public long GetTrapCount()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.TrapCount);
		}

		// Token: 0x06031428 RID: 201768 RVA: 0x00B6CAA8 File Offset: 0x00B6ACA8
		public long GetMaxTrapCount()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.MaxTrapCount);
		}

		// Token: 0x06031429 RID: 201769 RVA: 0x00B6CAB4 File Offset: 0x00B6ACB4
		public int GetCurrentPurificationItemCount()
		{
			TrapDefenseBattleItemData itemData = TrapDefenseModel.Instance.BattleInventoryData.GetItemData(1);
			if (itemData == null)
			{
				return 0;
			}
			return itemData.InventoryCount;
		}

		// Token: 0x0603142A RID: 201770 RVA: 0x00B6CADD File Offset: 0x00B6ACDD
		public int GetPurificationItemConsume()
		{
			return TowerDefenseEventController.Instance.RaycastResult.PollutedNum;
		}

		// Token: 0x17007A27 RID: 31271
		// (get) Token: 0x0603142B RID: 201771 RVA: 0x00B6CAEE File Offset: 0x00B6ACEE
		public bool IsPurificationItemEnough
		{
			get
			{
				return this.GetCurrentPurificationItemCount() >= this.GetPurificationItemConsume();
			}
		}

		// Token: 0x0603142C RID: 201772 RVA: 0x00B6CB04 File Offset: 0x00B6AD04
		public void SetTechParamMapVar(Dictionary<int, int> techParamMap)
		{
			if (techParamMap == null)
			{
				return;
			}
			this.TechParamMap.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in techParamMap)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int key = num;
				int num3 = num2;
				this.TechParamMap[(TrapDefenseParamType)key] = (float)num3;
			}
		}

		// Token: 0x0603142D RID: 201773 RVA: 0x00B6CB7C File Offset: 0x00B6AD7C
		public float GetSlotCount()
		{
			float result;
			if (!this.TechParamMap.TryGetValue(TrapDefenseParamType.SlotCount, out result))
			{
				return 0f;
			}
			return result;
		}

		// Token: 0x0603142E RID: 201774 RVA: 0x00B6CBA0 File Offset: 0x00B6ADA0
		public float GetAuxiliaryLimit()
		{
			float result;
			if (!this.TechParamMap.TryGetValue(TrapDefenseParamType.AuxiliaryCount, out result))
			{
				return 1f;
			}
			return result;
		}

		// Token: 0x17007A28 RID: 31272
		// (get) Token: 0x0603142F RID: 201775 RVA: 0x00B6CBC4 File Offset: 0x00B6ADC4
		public bool IsCanBuildMachine
		{
			get
			{
				TrapDefenseWave? currentBatchData = TrapDefenseModel.Instance.GetCurrentBatchData();
				if (currentBatchData == null)
				{
					return false;
				}
				bool flag = TowerDefenseEventController.Instance.IsInPreview();
				return currentBatchData.Value.CanBuildMachine && flag;
			}
		}

		// Token: 0x06031430 RID: 201776 RVA: 0x00B6CC03 File Offset: 0x00B6AE03
		public void SetShopOpen(bool isOpen)
		{
			this.IsShopOpen = isOpen;
		}

		// Token: 0x06031431 RID: 201777 RVA: 0x00B6CC0C File Offset: 0x00B6AE0C
		public void SetPreviewCountDown(float countDown)
		{
			this.PreviewCountDown = countDown;
		}

		// Token: 0x06031432 RID: 201778 RVA: 0x00B6CC15 File Offset: 0x00B6AE15
		public void SetComboNum(int num)
		{
			this.ComboNum = num;
			EventSystem.Instance.Emit<int>(EEventName.TrapDefenseComboNumChange, num);
		}

		// Token: 0x06031433 RID: 201779 RVA: 0x00B6CC2F File Offset: 0x00B6AE2F
		public void SetSpecialShow(bool isShow)
		{
			this.IsSpecialShow = isShow;
		}

		// Token: 0x06031434 RID: 201780 RVA: 0x00B6CC38 File Offset: 0x00B6AE38
		public TrapDefenseBattleSkillData GetSkillData(string actionName)
		{
			TrapDefenseBattleSkillData trapDefenseBattleSkillData;
			if (!this.BattleSkillData.TryGetValue(actionName, out trapDefenseBattleSkillData))
			{
				if (actionName == "塔防道具")
				{
					trapDefenseBattleSkillData = new TrapDefenseBattleExploreSkillData();
				}
				else
				{
					trapDefenseBattleSkillData = new TrapDefenseBattleSkillData();
				}
				trapDefenseBattleSkillData.InitData(actionName);
				this.BattleSkillData[actionName] = trapDefenseBattleSkillData;
			}
			return trapDefenseBattleSkillData;
		}

		// Token: 0x06031435 RID: 201781 RVA: 0x00B6CC88 File Offset: 0x00B6AE88
		public void RefreshExploreSkillData()
		{
			int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
			ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(currentExploreSkillId);
			if (exploreConfigById == null || exploreConfigById.Value.SkillType != 5)
			{
				return;
			}
			TrapDefenseBattleExploreSkillData trapDefenseBattleExploreSkillData = this.GetSkillData("塔防道具") as TrapDefenseBattleExploreSkillData;
			trapDefenseBattleExploreSkillData.SetExploreSkillId(currentExploreSkillId);
			bool flag = RouletteModel.Instance.IsExploreRouletteOpen(false);
			bool curInstToLevelDataHasShop = TrapDefenseModel.Instance.GetCurInstToLevelDataHasShop();
			trapDefenseBattleExploreSkillData.SetVisible(flag && curInstToLevelDataHasShop);
			EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, trapDefenseBattleExploreSkillData.GetButtonType());
		}

		// Token: 0x06031436 RID: 201782 RVA: 0x00B6CD1C File Offset: 0x00B6AF1C
		private void RefreshSkillCd(GroupSkillCdInfo groupSkillCdInfo)
		{
			foreach (int num in groupSkillCdInfo.SkillCdInfoMap.Keys)
			{
				foreach (TrapDefenseBattleSkillData trapDefenseBattleSkillData in this.BattleSkillData.Values)
				{
					if (trapDefenseBattleSkillData.GetSkillId() == num)
					{
						trapDefenseBattleSkillData.RefreshSkillCd();
						EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, trapDefenseBattleSkillData.GetButtonType());
					}
				}
			}
		}

		// Token: 0x06031437 RID: 201783 RVA: 0x00B6CDD4 File Offset: 0x00B6AFD4
		public void EquipExplorePhantomSkill()
		{
			this.RefreshExploreSkillData();
		}

		// Token: 0x06031438 RID: 201784 RVA: 0x00B6CDDC File Offset: 0x00B6AFDC
		public void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCd(groupSkillCdInfo);
		}

		// Token: 0x06031439 RID: 201785 RVA: 0x00B6CDE5 File Offset: 0x00B6AFE5
		public void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCd(groupSkillCdInfo);
		}

		// Token: 0x0603143A RID: 201786 RVA: 0x00B6CDF0 File Offset: 0x00B6AFF0
		public int? GetExploreSkillId()
		{
			TrapDefenseBattleExploreSkillData trapDefenseBattleExploreSkillData = this.GetSkillData("塔防道具") as TrapDefenseBattleExploreSkillData;
			if (trapDefenseBattleExploreSkillData == null)
			{
				return null;
			}
			return new int?(trapDefenseBattleExploreSkillData.GetSkillId());
		}

		// Token: 0x0603143B RID: 201787 RVA: 0x00B6CE25 File Offset: 0x00B6B025
		public void SetHasStartAkEvent(bool value)
		{
			this.HasStartAkEvent = value;
		}

		// Token: 0x0401A55D RID: 107869
		private readonly Dictionary<ETrapDefenseSystemVarType, string> BehaviorTreeVarMap = new Dictionary<ETrapDefenseSystemVarType, string>();

		// Token: 0x0401A55E RID: 107870
		private readonly Dictionary<ETrapDefenseSystemVarType, HashSet<TTreeVarUpdateDelegate>> TempTreeVarDelegateMap = new Dictionary<ETrapDefenseSystemVarType, HashSet<TTreeVarUpdateDelegate>>();

		// Token: 0x0401A55F RID: 107871
		private readonly Dictionary<TrapDefenseParamType, float> TechParamMap = new Dictionary<TrapDefenseParamType, float>();

		// Token: 0x0401A560 RID: 107872
		private readonly Dictionary<string, TrapDefenseBattleSkillData> BattleSkillData = new Dictionary<string, TrapDefenseBattleSkillData>();

		// Token: 0x0401A561 RID: 107873
		public bool IsShopOpen;

		// Token: 0x0401A562 RID: 107874
		public bool IsSpecialShow;

		// Token: 0x0401A563 RID: 107875
		public float PreviewCountDown;

		// Token: 0x0401A564 RID: 107876
		public int ComboNum;

		// Token: 0x0401A565 RID: 107877
		public bool HasStartAkEvent;
	}
}
