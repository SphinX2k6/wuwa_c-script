using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200476C RID: 18284
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoBattleData : ISkillButtonUiEventInterface
	{
		// Token: 0x0602DE6E RID: 188014 RVA: 0x00CD9A95 File Offset: 0x00CD7C95
		public static KurotatoBattleData Create()
		{
			return new KurotatoBattleData();
		}

		// Token: 0x0602DE6F RID: 188015 RVA: 0x00CD9A9C File Offset: 0x00CD7C9C
		public void InitBattleSkillData()
		{
			KurotatoBattleSkillData kurotatoBattleSkillData = new KurotatoBattleSkillData(700105);
			kurotatoBattleSkillData.InitData("闪避");
			this.BattleSkillData["闪避"] = kurotatoBattleSkillData;
		}

		// Token: 0x0602DE70 RID: 188016 RVA: 0x00CD9AD0 File Offset: 0x00CD7CD0
		[return: Nullable(2)]
		public KurotatoBattleSkillData GetBattleSkillData(string actionName)
		{
			return this.BattleSkillData.GetValueOrDefault(actionName);
		}

		// Token: 0x0602DE71 RID: 188017 RVA: 0x00CD9AE0 File Offset: 0x00CD7CE0
		public void Clear()
		{
			this.BehaviorDelegate.Clear();
			this.BattleSkillData.Clear();
			if (this.NextTickTimerId != null)
			{
				TimerSystem.Instance.Remove(this.NextTickTimerId);
				this.NextTickTimerId = null;
			}
			this.SkillCdChanged.Clear();
		}

		// Token: 0x0602DE72 RID: 188018 RVA: 0x00CD9B2E File Offset: 0x00CD7D2E
		public void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCdNextTick(groupSkillCdInfo);
		}

		// Token: 0x0602DE73 RID: 188019 RVA: 0x00CD9B37 File Offset: 0x00CD7D37
		public void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCdNextTick(groupSkillCdInfo);
		}

		// Token: 0x0602DE74 RID: 188020 RVA: 0x00CD9B40 File Offset: 0x00CD7D40
		private void RefreshSkillCdNextTick(GroupSkillCdInfo groupSkillCdInfo)
		{
			foreach (int num in groupSkillCdInfo.SkillCdInfoMap.Keys)
			{
				foreach (KurotatoBattleSkillData kurotatoBattleSkillData in this.BattleSkillData.Values)
				{
					if (kurotatoBattleSkillData.GetSkillId() == num)
					{
						this.SkillCdChanged.Add(kurotatoBattleSkillData);
					}
				}
			}
			if (this.NextTickTimerId != null)
			{
				return;
			}
			this.NextTickTimerId = TimerSystem.Instance.Next(new TTimerAction(this.NextTick), null, null);
		}

		// Token: 0x0602DE75 RID: 188021 RVA: 0x00CD9C10 File Offset: 0x00CD7E10
		private void NextTick(float delta)
		{
			this.NextTickTimerId = null;
			foreach (KurotatoBattleSkillData kurotatoBattleSkillData in this.SkillCdChanged)
			{
				kurotatoBattleSkillData.RefreshSkillCd();
				EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, kurotatoBattleSkillData.GetButtonType());
			}
			this.SkillCdChanged.Clear();
		}

		// Token: 0x0602DE76 RID: 188022 RVA: 0x00CD9C8C File Offset: 0x00CD7E8C
		public void SetBehaviorTreeVar(IDictionary<string, string> variableKeyNames)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (KeyValuePair<string, string> keyValuePair in variableKeyNames)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			this.BehaviorDelegate.SetBehaviorTreeVarRelation(dictionary);
		}

		// Token: 0x0602DE77 RID: 188023 RVA: 0x00CD9CF4 File Offset: 0x00CD7EF4
		[NullableContext(2)]
		public VarDefinePb GetBehaviorTreeVar(EKurotatoSystemVarType varType)
		{
			return this.BehaviorDelegate.GetBehaviorTreeVar(varType.ToEnumString());
		}

		// Token: 0x0602DE78 RID: 188024 RVA: 0x00CD9D07 File Offset: 0x00CD7F07
		public int GetBehaviorTreeVarToNumber(EKurotatoSystemVarType varType)
		{
			return (int)this.BehaviorDelegate.GetBehaviorTreeVarToNumber(varType.ToEnumString());
		}

		// Token: 0x0602DE79 RID: 188025 RVA: 0x00CD9D1B File Offset: 0x00CD7F1B
		public int GetCurrencyCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.Gold);
		}

		// Token: 0x0602DE7A RID: 188026 RVA: 0x00CD9D24 File Offset: 0x00CD7F24
		public int GetRoleLevel()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.RoleLevel);
		}

		// Token: 0x0602DE7B RID: 188027 RVA: 0x00CD9D2D File Offset: 0x00CD7F2D
		public int GetRoleExp()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.TotalRoleExp);
		}

		// Token: 0x0602DE7C RID: 188028 RVA: 0x00CD9D36 File Offset: 0x00CD7F36
		public int GetBatchConfigId()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.BatchConfigId);
		}

		// Token: 0x0602DE7D RID: 188029 RVA: 0x00CD9D3F File Offset: 0x00CD7F3F
		public int GetBatch()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.Batch);
		}

		// Token: 0x0602DE7E RID: 188030 RVA: 0x00CD9D48 File Offset: 0x00CD7F48
		public EKurotatoBatchType GetBatchType()
		{
			return (EKurotatoBatchType)this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.BatchType);
		}

		// Token: 0x0602DE7F RID: 188031 RVA: 0x00CD9D51 File Offset: 0x00CD7F51
		public int GetMaxBatch()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.MaxBatch);
		}

		// Token: 0x0602DE80 RID: 188032 RVA: 0x00CD9D5A File Offset: 0x00CD7F5A
		public int GetChestCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.TreasureBoxCount);
		}

		// Token: 0x0602DE81 RID: 188033 RVA: 0x00CD9D64 File Offset: 0x00CD7F64
		public int GetUpgradeCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.UpgradeCount);
		}

		// Token: 0x0602DE82 RID: 188034 RVA: 0x00CD9D6E File Offset: 0x00CD7F6E
		public int GetComboKillCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.ConsecutiveKillCount);
		}

		// Token: 0x0602DE83 RID: 188035 RVA: 0x00CD9D78 File Offset: 0x00CD7F78
		public int GetGoldGainEfficiency()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.GoldGainEfficiency);
		}

		// Token: 0x0602DE84 RID: 188036 RVA: 0x00CD9D82 File Offset: 0x00CD7F82
		public int GetSpareGold()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.SpareGold);
		}

		// Token: 0x0602DE85 RID: 188037 RVA: 0x00CD9D8C File Offset: 0x00CD7F8C
		public int GetPlayerPropertyValue(int propId)
		{
			UKSC_AttrSet playerAttrSet = this.GetPlayerAttrSet();
			int? num;
			if (playerAttrSet == null)
			{
				num = null;
			}
			else
			{
				TMap<EKSC_AttrType, int> attrs_ = playerAttrSet.Attrs_;
				num = ((attrs_ != null) ? attrs_.GetValueOrNull((EKSC_AttrType)propId) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x0602DE86 RID: 188038 RVA: 0x00CD9DD1 File Offset: 0x00CD7FD1
		[NullableContext(2)]
		public UKSC_AttrSet GetPlayerAttrSet()
		{
			KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
			if (curSubModel == null)
			{
				return null;
			}
			AKSC_Entity kscPlayerEntity = curSubModel.KscPlayerEntity;
			if (kscPlayerEntity == null)
			{
				return null;
			}
			UKSC_SkillComp skillComp = kscPlayerEntity.GetSkillComp();
			if (skillComp == null)
			{
				return null;
			}
			return skillComp.AttrSet_;
		}

		// Token: 0x0602DE87 RID: 188039 RVA: 0x00CD9DFE File Offset: 0x00CD7FFE
		public bool IsPlayerPropertyLocked(int propId)
		{
			UKSC_AttrSet playerAttrSet = this.GetPlayerAttrSet();
			return playerAttrSet != null && playerAttrSet.IsAttrValueLocked((EKSC_AttrType)propId);
		}

		// Token: 0x0602DE88 RID: 188040 RVA: 0x00CD9E14 File Offset: 0x00CD8014
		public int GetPlayerPropertyLockedValue(int propId)
		{
			UKSC_AttrSet playerAttrSet = this.GetPlayerAttrSet();
			if (playerAttrSet == null)
			{
				return 0;
			}
			int result = 0;
			playerAttrSet.GetLockedAttrValue((EKSC_AttrType)propId, ref result);
			return result;
		}

		// Token: 0x0602DE89 RID: 188041 RVA: 0x00CD9E3C File Offset: 0x00CD803C
		public bool AssignAllPlayerAttrListen(FOnKSCAllAttrChange delegateFunc)
		{
			UKSC_AttrSet playerAttrSet = this.GetPlayerAttrSet();
			if (playerAttrSet == null)
			{
				return false;
			}
			playerAttrSet.AssignAllAttrListen(delegateFunc);
			return true;
		}

		// Token: 0x0602DE8A RID: 188042 RVA: 0x00CD9E5E File Offset: 0x00CD805E
		public void RemoveAllPlayerAttrListen(FOnKSCAllAttrChange delegateFunc)
		{
			UKSC_AttrSet playerAttrSet = this.GetPlayerAttrSet();
			if (playerAttrSet == null)
			{
				return;
			}
			playerAttrSet.RemoveAllAttrListen(delegateFunc);
		}

		// Token: 0x0401882E RID: 100398
		private const int DODGE_SKILL_ID = 700105;

		// Token: 0x0401882F RID: 100399
		public BehaviorTreeUpdateDelegateProxy BehaviorDelegate = new BehaviorTreeUpdateDelegateProxy();

		// Token: 0x04018830 RID: 100400
		private readonly Dictionary<string, KurotatoBattleSkillData> BattleSkillData = new Dictionary<string, KurotatoBattleSkillData>();

		// Token: 0x04018831 RID: 100401
		[Nullable(2)]
		private TimerHandle NextTickTimerId;

		// Token: 0x04018832 RID: 100402
		private readonly HashSet<KurotatoBattleSkillData> SkillCdChanged = new HashSet<KurotatoBattleSkillData>();
	}
}
