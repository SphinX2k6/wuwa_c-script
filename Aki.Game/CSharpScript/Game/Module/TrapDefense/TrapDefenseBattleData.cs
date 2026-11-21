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
	// Token: 0x020039C7 RID: 14791
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBattleData : ISkillButtonUiEventInterface
	{
		// Token: 0x060261A8 RID: 156072 RVA: 0x00AB07C2 File Offset: 0x00AAE9C2
		public static TrapDefenseBattleData Create()
		{
			TrapDefenseBattleData trapDefenseBattleData = new TrapDefenseBattleData();
			trapDefenseBattleData.Init();
			return trapDefenseBattleData;
		}

		// Token: 0x060261A9 RID: 156073 RVA: 0x00AB07CF File Offset: 0x00AAE9CF
		private void Init()
		{
		}

		// Token: 0x060261AA RID: 156074 RVA: 0x00AB07D4 File Offset: 0x00AAE9D4
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

		// Token: 0x060261AB RID: 156075 RVA: 0x00AB080C File Offset: 0x00AAEA0C
		private void RemoveTempTreeVarDelegate(ETrapDefenseSystemVarType key, TTreeVarUpdateDelegate @delegate)
		{
			HashSet<TTreeVarUpdateDelegate> hashSet;
			if (this.TempTreeVarDelegateMap.TryGetValue(key, out hashSet))
			{
				hashSet.Remove(@delegate);
			}
		}

		// Token: 0x060261AC RID: 156076 RVA: 0x00AB0831 File Offset: 0x00AAEA31
		private void ClearTempTreeVarDelegate()
		{
			this.TempTreeVarDelegateMap.Clear();
		}

		// Token: 0x060261AD RID: 156077 RVA: 0x00AB083E File Offset: 0x00AAEA3E
		public void Clear()
		{
			this.BehaviorTreeVarMap.Clear();
			this.TechParamMap.Clear();
			this.BattleSkillData.Clear();
			this.ClearTempTreeVarDelegate();
		}

		// Token: 0x060261AE RID: 156078 RVA: 0x00AB0868 File Offset: 0x00AAEA68
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

		// Token: 0x060261AF RID: 156079 RVA: 0x00AB08B4 File Offset: 0x00AAEAB4
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

		// Token: 0x060261B0 RID: 156080 RVA: 0x00AB0900 File Offset: 0x00AAEB00
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

		// Token: 0x060261B1 RID: 156081 RVA: 0x00AB0A20 File Offset: 0x00AAEC20
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

		// Token: 0x060261B2 RID: 156082 RVA: 0x00AB0A61 File Offset: 0x00AAEC61
		public long GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType key)
		{
			VarDefinePb behaviorTreeVar = this.GetBehaviorTreeVar(key);
			if (behaviorTreeVar == null)
			{
				return 0L;
			}
			return behaviorTreeVar.Int;
		}

		// Token: 0x060261B3 RID: 156083 RVA: 0x00AB0A76 File Offset: 0x00AAEC76
		public long GetGoldNum()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.Gold);
		}

		// Token: 0x060261B4 RID: 156084 RVA: 0x00AB0A7F File Offset: 0x00AAEC7F
		public long GetHealth()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.Health);
		}

		// Token: 0x060261B5 RID: 156085 RVA: 0x00AB0A88 File Offset: 0x00AAEC88
		public int GetBatch()
		{
			return (int)this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.Batch);
		}

		// Token: 0x060261B6 RID: 156086 RVA: 0x00AB0A92 File Offset: 0x00AAEC92
		public long GetMaxBatch()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.MaxBatch);
		}

		// Token: 0x060261B7 RID: 156087 RVA: 0x00AB0A9B File Offset: 0x00AAEC9B
		public long GetTrapCount()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.TrapCount);
		}

		// Token: 0x060261B8 RID: 156088 RVA: 0x00AB0AA4 File Offset: 0x00AAECA4
		public long GetMaxTrapCount()
		{
			return this.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.MaxTrapCount);
		}

		// Token: 0x060261B9 RID: 156089 RVA: 0x00AB0AB0 File Offset: 0x00AAECB0
		public int GetCurrentPurificationItemCount()
		{
			TrapDefenseBattleItemData itemData = TrapDefenseModel.Instance.BattleInventoryData.GetItemData(1);
			if (itemData == null)
			{
				return 0;
			}
			return itemData.InventoryCount;
		}

		// Token: 0x060261BA RID: 156090 RVA: 0x00AB0AD9 File Offset: 0x00AAECD9
		public int GetPurificationItemConsume()
		{
			return TowerDefenseEventController.Instance.RaycastResult.PollutedNum;
		}

		// Token: 0x17004DD4 RID: 19924
		// (get) Token: 0x060261BB RID: 156091 RVA: 0x00AB0AEA File Offset: 0x00AAECEA
		public bool IsPurificationItemEnough
		{
			get
			{
				return this.GetCurrentPurificationItemCount() >= this.GetPurificationItemConsume();
			}
		}

		// Token: 0x060261BC RID: 156092 RVA: 0x00AB0B00 File Offset: 0x00AAED00
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

		// Token: 0x060261BD RID: 156093 RVA: 0x00AB0B78 File Offset: 0x00AAED78
		public float GetSlotCount()
		{
			float result;
			if (!this.TechParamMap.TryGetValue(TrapDefenseParamType.SlotCount, out result))
			{
				return 0f;
			}
			return result;
		}

		// Token: 0x060261BE RID: 156094 RVA: 0x00AB0B9C File Offset: 0x00AAED9C
		public float GetAuxiliaryLimit()
		{
			float result;
			if (!this.TechParamMap.TryGetValue(TrapDefenseParamType.AuxiliaryCount, out result))
			{
				return 1f;
			}
			return result;
		}

		// Token: 0x17004DD5 RID: 19925
		// (get) Token: 0x060261BF RID: 156095 RVA: 0x00AB0BC0 File Offset: 0x00AAEDC0
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

		// Token: 0x060261C0 RID: 156096 RVA: 0x00AB0BFF File Offset: 0x00AAEDFF
		public void SetShopOpen(bool isOpen)
		{
			this.IsShopOpen = isOpen;
		}

		// Token: 0x060261C1 RID: 156097 RVA: 0x00AB0C08 File Offset: 0x00AAEE08
		public void SetPreviewCountDown(float countDown)
		{
			this.PreviewCountDown = countDown;
		}

		// Token: 0x060261C2 RID: 156098 RVA: 0x00AB0C11 File Offset: 0x00AAEE11
		public void SetComboNum(int num)
		{
			this.ComboNum = num;
			EventSystem.Instance.Emit<int>(EEventName.TrapDefenseComboNumChange, num);
		}

		// Token: 0x060261C3 RID: 156099 RVA: 0x00AB0C2B File Offset: 0x00AAEE2B
		public void SetSpecialShow(bool isShow)
		{
			this.IsSpecialShow = isShow;
		}

		// Token: 0x060261C4 RID: 156100 RVA: 0x00AB0C34 File Offset: 0x00AAEE34
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

		// Token: 0x060261C5 RID: 156101 RVA: 0x00AB0C84 File Offset: 0x00AAEE84
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

		// Token: 0x060261C6 RID: 156102 RVA: 0x00AB0D18 File Offset: 0x00AAEF18
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

		// Token: 0x060261C7 RID: 156103 RVA: 0x00AB0DD0 File Offset: 0x00AAEFD0
		public void EquipExplorePhantomSkill()
		{
			this.RefreshExploreSkillData();
		}

		// Token: 0x060261C8 RID: 156104 RVA: 0x00AB0DD8 File Offset: 0x00AAEFD8
		public void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCd(groupSkillCdInfo);
		}

		// Token: 0x060261C9 RID: 156105 RVA: 0x00AB0DE1 File Offset: 0x00AAEFE1
		public void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCd(groupSkillCdInfo);
		}

		// Token: 0x060261CA RID: 156106 RVA: 0x00AB0DEC File Offset: 0x00AAEFEC
		public int? GetExploreSkillId()
		{
			TrapDefenseBattleExploreSkillData trapDefenseBattleExploreSkillData = this.GetSkillData("塔防道具") as TrapDefenseBattleExploreSkillData;
			if (trapDefenseBattleExploreSkillData == null)
			{
				return null;
			}
			return new int?(trapDefenseBattleExploreSkillData.GetSkillId());
		}

		// Token: 0x060261CB RID: 156107 RVA: 0x00AB0E21 File Offset: 0x00AAF021
		public void SetHasStartAkEvent(bool value)
		{
			this.HasStartAkEvent = value;
		}

		// Token: 0x04014EB4 RID: 85684
		private readonly Dictionary<ETrapDefenseSystemVarType, string> BehaviorTreeVarMap = new Dictionary<ETrapDefenseSystemVarType, string>();

		// Token: 0x04014EB5 RID: 85685
		private readonly Dictionary<ETrapDefenseSystemVarType, HashSet<TTreeVarUpdateDelegate>> TempTreeVarDelegateMap = new Dictionary<ETrapDefenseSystemVarType, HashSet<TTreeVarUpdateDelegate>>();

		// Token: 0x04014EB6 RID: 85686
		private readonly Dictionary<TrapDefenseParamType, float> TechParamMap = new Dictionary<TrapDefenseParamType, float>();

		// Token: 0x04014EB7 RID: 85687
		private readonly Dictionary<string, TrapDefenseBattleSkillData> BattleSkillData = new Dictionary<string, TrapDefenseBattleSkillData>();

		// Token: 0x04014EB8 RID: 85688
		public bool IsShopOpen;

		// Token: 0x04014EB9 RID: 85689
		public bool IsSpecialShow;

		// Token: 0x04014EBA RID: 85690
		public float PreviewCountDown;

		// Token: 0x04014EBB RID: 85691
		public int ComboNum;

		// Token: 0x04014EBC RID: 85692
		public bool HasStartAkEvent;
	}
}
