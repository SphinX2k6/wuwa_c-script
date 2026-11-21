using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.SkillButtonUi;

// Token: 0x02002068 RID: 8296
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueBattleData : ISkillButtonUiEventInterface
{
	// Token: 0x06014802 RID: 83970 RVA: 0x005FA0A9 File Offset: 0x005F82A9
	public static SurvivorsRogueBattleData Create()
	{
		return new SurvivorsRogueBattleData();
	}

	// Token: 0x06014803 RID: 83971 RVA: 0x005FA0B0 File Offset: 0x005F82B0
	public void InitBattleSkillData()
	{
		this.BattleSkillData["技能1"] = this.CreateSkillData(220003, "技能1");
		this.BattleSkillData["闪避"] = this.CreateSkillData(100001, "闪避");
	}

	// Token: 0x06014804 RID: 83972 RVA: 0x005FA0FD File Offset: 0x005F82FD
	private SurvivorsRogueBattleSkillData CreateSkillData(int skillId, string actionName)
	{
		SurvivorsRogueBattleSkillData survivorsRogueBattleSkillData = new SurvivorsRogueBattleSkillData(skillId);
		survivorsRogueBattleSkillData.InitData(actionName);
		return survivorsRogueBattleSkillData;
	}

	// Token: 0x06014805 RID: 83973 RVA: 0x005FA10C File Offset: 0x005F830C
	[return: Nullable(2)]
	public SurvivorsRogueBattleSkillData GetBattleSkillData(string actionName)
	{
		SurvivorsRogueBattleSkillData result;
		if (!this.BattleSkillData.TryGetValue(actionName, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06014806 RID: 83974 RVA: 0x005FA12C File Offset: 0x005F832C
	public void Clear()
	{
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = this.BehaviorDelegate;
		if (behaviorDelegate != null)
		{
			behaviorDelegate.Clear();
		}
		this.BattleSkillData.Clear();
	}

	// Token: 0x06014807 RID: 83975 RVA: 0x005FA14A File Offset: 0x005F834A
	public bool IsCoinEfficiencyEnhance()
	{
		return true;
	}

	// Token: 0x06014808 RID: 83976 RVA: 0x005FA150 File Offset: 0x005F8350
	public void SetBehaviorTreeVar(Dictionary<string, string> variableKeyNames)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, string> keyValuePair in variableKeyNames)
		{
			dictionary[keyValuePair.Key] = keyValuePair.Value;
		}
		this.BehaviorDelegate.SetBehaviorTreeVarRelation(dictionary);
	}

	// Token: 0x06014809 RID: 83977 RVA: 0x005FA1C0 File Offset: 0x005F83C0
	[NullableContext(2)]
	public VarDefinePb GetBehaviorTreeVar(ESurvivorsRougeSystemVarType varType)
	{
		return this.BehaviorDelegate.GetBehaviorTreeVar(varType.ToEnumString());
	}

	// Token: 0x0601480A RID: 83978 RVA: 0x005FA1D3 File Offset: 0x005F83D3
	public int GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType varType)
	{
		return (int)this.BehaviorDelegate.GetBehaviorTreeVarToNumber(varType.ToEnumString());
	}

	// Token: 0x0601480B RID: 83979 RVA: 0x005FA1E7 File Offset: 0x005F83E7
	public int GetCurrencyCount()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.Gold);
	}

	// Token: 0x0601480C RID: 83980 RVA: 0x005FA1F0 File Offset: 0x005F83F0
	public int GetBatch()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.Batch);
	}

	// Token: 0x0601480D RID: 83981 RVA: 0x005FA1F9 File Offset: 0x005F83F9
	public int GetMaxBatch()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.MaxBatch);
	}

	// Token: 0x0601480E RID: 83982 RVA: 0x005FA202 File Offset: 0x005F8402
	public int GetChestCount()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.TreasureBoxCount);
	}

	// Token: 0x0601480F RID: 83983 RVA: 0x005FA20B File Offset: 0x005F840B
	public int GetComboKillCount()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.ConsecutiveKillCount);
	}

	// Token: 0x06014810 RID: 83984 RVA: 0x005FA214 File Offset: 0x005F8414
	public int GetGoldGainEfficiency()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.GoldGainEfficiency);
	}

	// Token: 0x17001ED0 RID: 7888
	// (get) Token: 0x06014811 RID: 83985 RVA: 0x005FA21D File Offset: 0x005F841D
	public bool EndlessWaveEnabled
	{
		get
		{
			return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.EndlessBatchLimit) == 1;
		}
	}

	// Token: 0x06014812 RID: 83986 RVA: 0x005FA229 File Offset: 0x005F8429
	public void EquipExplorePhantomSkill()
	{
	}

	// Token: 0x06014813 RID: 83987 RVA: 0x005FA22B File Offset: 0x005F842B
	public void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
	{
		this.RefreshSkillCd(groupSkillCdInfo);
	}

	// Token: 0x06014814 RID: 83988 RVA: 0x005FA234 File Offset: 0x005F8434
	public void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
	{
		this.RefreshSkillCd(groupSkillCdInfo);
	}

	// Token: 0x06014815 RID: 83989 RVA: 0x005FA240 File Offset: 0x005F8440
	private void RefreshSkillCd(GroupSkillCdInfo groupSkillCdInfo)
	{
		foreach (int num in groupSkillCdInfo.SkillCdInfoMap.Keys)
		{
			foreach (SurvivorsRogueBattleSkillData survivorsRogueBattleSkillData in this.BattleSkillData.Values)
			{
				if (survivorsRogueBattleSkillData.GetSkillId() == num)
				{
					survivorsRogueBattleSkillData.RefreshSkillCd();
					EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, survivorsRogueBattleSkillData.GetButtonType());
				}
			}
		}
	}

	// Token: 0x0400ADC9 RID: 44489
	private const int ACTIVE_SKILL_ID = 220003;

	// Token: 0x0400ADCA RID: 44490
	private const int DODGE_SKILL_ID = 100001;

	// Token: 0x0400ADCB RID: 44491
	public BehaviorTreeUpdateDelegateProxy BehaviorDelegate = new BehaviorTreeUpdateDelegateProxy();

	// Token: 0x0400ADCC RID: 44492
	private readonly Dictionary<string, SurvivorsRogueBattleSkillData> BattleSkillData = new Dictionary<string, SurvivorsRogueBattleSkillData>();
}
