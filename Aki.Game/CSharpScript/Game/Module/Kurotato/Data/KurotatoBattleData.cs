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
	// Token: 0x02005795 RID: 22421
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoBattleData : ISkillButtonUiEventInterface
	{
		// Token: 0x06038F5E RID: 233310 RVA: 0x00D8AD19 File Offset: 0x00D88F19
		public static KurotatoBattleData Create()
		{
			return new KurotatoBattleData();
		}

		// Token: 0x06038F5F RID: 233311 RVA: 0x00D8AD20 File Offset: 0x00D88F20
		public void InitBattleSkillData()
		{
			KurotatoBattleSkillData kurotatoBattleSkillData = new KurotatoBattleSkillData(700105);
			kurotatoBattleSkillData.InitData("闪避");
			this.BattleSkillData["闪避"] = kurotatoBattleSkillData;
		}

		// Token: 0x06038F60 RID: 233312 RVA: 0x00D8AD54 File Offset: 0x00D88F54
		[return: Nullable(2)]
		public KurotatoBattleSkillData GetBattleSkillData(string actionName)
		{
			return this.BattleSkillData.GetValueOrDefault(actionName);
		}

		// Token: 0x06038F61 RID: 233313 RVA: 0x00D8AD64 File Offset: 0x00D88F64
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

		// Token: 0x06038F62 RID: 233314 RVA: 0x00D8ADB2 File Offset: 0x00D88FB2
		public void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCdNextTick(groupSkillCdInfo);
		}

		// Token: 0x06038F63 RID: 233315 RVA: 0x00D8ADBB File Offset: 0x00D88FBB
		public void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			this.RefreshSkillCdNextTick(groupSkillCdInfo);
		}

		// Token: 0x06038F64 RID: 233316 RVA: 0x00D8ADC4 File Offset: 0x00D88FC4
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

		// Token: 0x06038F65 RID: 233317 RVA: 0x00D8AE94 File Offset: 0x00D89094
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

		// Token: 0x06038F66 RID: 233318 RVA: 0x00D8AF10 File Offset: 0x00D89110
		public void SetBehaviorTreeVar(IDictionary<string, string> variableKeyNames)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (KeyValuePair<string, string> keyValuePair in variableKeyNames)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			this.BehaviorDelegate.SetBehaviorTreeVarRelation(dictionary);
		}

		// Token: 0x06038F67 RID: 233319 RVA: 0x00D8AF78 File Offset: 0x00D89178
		[NullableContext(2)]
		public VarDefinePb GetBehaviorTreeVar(EKurotatoSystemVarType varType)
		{
			return this.BehaviorDelegate.GetBehaviorTreeVar(varType.ToEnumString());
		}

		// Token: 0x06038F68 RID: 233320 RVA: 0x00D8AF8B File Offset: 0x00D8918B
		public int GetBehaviorTreeVarToNumber(EKurotatoSystemVarType varType)
		{
			return (int)this.BehaviorDelegate.GetBehaviorTreeVarToNumber(varType.ToEnumString());
		}

		// Token: 0x06038F69 RID: 233321 RVA: 0x00D8AF9F File Offset: 0x00D8919F
		public int GetCurrencyCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.Gold);
		}

		// Token: 0x06038F6A RID: 233322 RVA: 0x00D8AFA8 File Offset: 0x00D891A8
		public int GetRoleLevel()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.RoleLevel);
		}

		// Token: 0x06038F6B RID: 233323 RVA: 0x00D8AFB1 File Offset: 0x00D891B1
		public int GetRoleExp()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.TotalRoleExp);
		}

		// Token: 0x06038F6C RID: 233324 RVA: 0x00D8AFBA File Offset: 0x00D891BA
		public int GetBatchConfigId()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.BatchConfigId);
		}

		// Token: 0x06038F6D RID: 233325 RVA: 0x00D8AFC3 File Offset: 0x00D891C3
		public int GetBatch()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.Batch);
		}

		// Token: 0x06038F6E RID: 233326 RVA: 0x00D8AFCC File Offset: 0x00D891CC
		public EKurotatoBatchType GetBatchType()
		{
			return (EKurotatoBatchType)this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.BatchType);
		}

		// Token: 0x06038F6F RID: 233327 RVA: 0x00D8AFD5 File Offset: 0x00D891D5
		public int GetMaxBatch()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.MaxBatch);
		}

		// Token: 0x06038F70 RID: 233328 RVA: 0x00D8AFDE File Offset: 0x00D891DE
		public int GetChestCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.TreasureBoxCount);
		}

		// Token: 0x06038F71 RID: 233329 RVA: 0x00D8AFE8 File Offset: 0x00D891E8
		public int GetUpgradeCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.UpgradeCount);
		}

		// Token: 0x06038F72 RID: 233330 RVA: 0x00D8AFF2 File Offset: 0x00D891F2
		public int GetComboKillCount()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.ConsecutiveKillCount);
		}

		// Token: 0x06038F73 RID: 233331 RVA: 0x00D8AFFC File Offset: 0x00D891FC
		public int GetGoldGainEfficiency()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.GoldGainEfficiency);
		}

		// Token: 0x06038F74 RID: 233332 RVA: 0x00D8B006 File Offset: 0x00D89206
		public int GetSpareGold()
		{
			return this.GetBehaviorTreeVarToNumber(EKurotatoSystemVarType.SpareGold);
		}

		// Token: 0x06038F75 RID: 233333 RVA: 0x00D8B010 File Offset: 0x00D89210
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

		// Token: 0x06038F76 RID: 233334 RVA: 0x00D8B055 File Offset: 0x00D89255
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

		// Token: 0x06038F77 RID: 233335 RVA: 0x00D8B082 File Offset: 0x00D89282
		public bool IsPlayerPropertyLocked(int propId)
		{
			UKSC_AttrSet playerAttrSet = this.GetPlayerAttrSet();
			return playerAttrSet != null && playerAttrSet.IsAttrValueLocked((EKSC_AttrType)propId);
		}

		// Token: 0x06038F78 RID: 233336 RVA: 0x00D8B098 File Offset: 0x00D89298
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

		// Token: 0x06038F79 RID: 233337 RVA: 0x00D8B0C0 File Offset: 0x00D892C0
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

		// Token: 0x06038F7A RID: 233338 RVA: 0x00D8B0E2 File Offset: 0x00D892E2
		public void RemoveAllPlayerAttrListen(FOnKSCAllAttrChange delegateFunc)
		{
			UKSC_AttrSet playerAttrSet = this.GetPlayerAttrSet();
			if (playerAttrSet == null)
			{
				return;
			}
			playerAttrSet.RemoveAllAttrListen(delegateFunc);
		}

		// Token: 0x0401DD98 RID: 122264
		private const int DODGE_SKILL_ID = 700105;

		// Token: 0x0401DD99 RID: 122265
		public BehaviorTreeUpdateDelegateProxy BehaviorDelegate = new BehaviorTreeUpdateDelegateProxy();

		// Token: 0x0401DD9A RID: 122266
		private readonly Dictionary<string, KurotatoBattleSkillData> BattleSkillData = new Dictionary<string, KurotatoBattleSkillData>();

		// Token: 0x0401DD9B RID: 122267
		[Nullable(2)]
		private TimerHandle NextTickTimerId;

		// Token: 0x0401DD9C RID: 122268
		private readonly HashSet<KurotatoBattleSkillData> SkillCdChanged = new HashSet<KurotatoBattleSkillData>();
	}
}
