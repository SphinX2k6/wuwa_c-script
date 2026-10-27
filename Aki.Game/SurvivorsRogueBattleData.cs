using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.SkillButtonUi;

// Token: 0x02002AEC RID: 10988
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueBattleData : ISkillButtonUiEventInterface
{
	// Token: 0x06016DD1 RID: 93649 RVA: 0x005CD529 File Offset: 0x005CB729
	public static SurvivorsRogueBattleData Create()
	{
		return new SurvivorsRogueBattleData();
	}

	// Token: 0x06016DD2 RID: 93650 RVA: 0x005CD530 File Offset: 0x005CB730
	public void InitBattleSkillData()
	{
		this.BattleSkillData["技能1"] = this.CreateSkillData(220003, "技能1");
		this.BattleSkillData["闪避"] = this.CreateSkillData(100001, "闪避");
	}

	// Token: 0x06016DD3 RID: 93651 RVA: 0x005CD57D File Offset: 0x005CB77D
	private SurvivorsRogueBattleSkillData CreateSkillData(int skillId, string actionName)
	{
		SurvivorsRogueBattleSkillData survivorsRogueBattleSkillData = new SurvivorsRogueBattleSkillData(skillId);
		survivorsRogueBattleSkillData.InitData(actionName);
		return survivorsRogueBattleSkillData;
	}

	// Token: 0x06016DD4 RID: 93652 RVA: 0x005CD58C File Offset: 0x005CB78C
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

	// Token: 0x06016DD5 RID: 93653 RVA: 0x005CD5AC File Offset: 0x005CB7AC
	public void Clear()
	{
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = this.BehaviorDelegate;
		if (behaviorDelegate != null)
		{
			behaviorDelegate.Clear();
		}
		this.BattleSkillData.Clear();
	}

	// Token: 0x06016DD6 RID: 93654 RVA: 0x005CD5CA File Offset: 0x005CB7CA
	public bool IsCoinEfficiencyEnhance()
	{
		return true;
	}

	// Token: 0x06016DD7 RID: 93655 RVA: 0x005CD5D0 File Offset: 0x005CB7D0
	public void SetBehaviorTreeVar(Dictionary<string, string> variableKeyNames)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, string> keyValuePair in variableKeyNames)
		{
			dictionary[keyValuePair.Key] = keyValuePair.Value;
		}
		this.BehaviorDelegate.SetBehaviorTreeVarRelation(dictionary);
	}

	// Token: 0x06016DD8 RID: 93656 RVA: 0x005CD640 File Offset: 0x005CB840
	[NullableContext(2)]
	public VarDefinePb GetBehaviorTreeVar(ESurvivorsRougeSystemVarType varType)
	{
		return this.BehaviorDelegate.GetBehaviorTreeVar(varType.ToEnumString());
	}

	// Token: 0x06016DD9 RID: 93657 RVA: 0x005CD653 File Offset: 0x005CB853
	public int GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType varType)
	{
		return (int)this.BehaviorDelegate.GetBehaviorTreeVarToNumber(varType.ToEnumString());
	}

	// Token: 0x06016DDA RID: 93658 RVA: 0x005CD667 File Offset: 0x005CB867
	public int GetCurrencyCount()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.Gold);
	}

	// Token: 0x06016DDB RID: 93659 RVA: 0x005CD670 File Offset: 0x005CB870
	public int GetBatch()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.Batch);
	}

	// Token: 0x06016DDC RID: 93660 RVA: 0x005CD679 File Offset: 0x005CB879
	public int GetMaxBatch()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.MaxBatch);
	}

	// Token: 0x06016DDD RID: 93661 RVA: 0x005CD682 File Offset: 0x005CB882
	public int GetChestCount()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.TreasureBoxCount);
	}

	// Token: 0x06016DDE RID: 93662 RVA: 0x005CD68B File Offset: 0x005CB88B
	public int GetComboKillCount()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.ConsecutiveKillCount);
	}

	// Token: 0x06016DDF RID: 93663 RVA: 0x005CD694 File Offset: 0x005CB894
	public int GetGoldGainEfficiency()
	{
		return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.GoldGainEfficiency);
	}

	// Token: 0x17001E78 RID: 7800
	// (get) Token: 0x06016DE0 RID: 93664 RVA: 0x005CD69D File Offset: 0x005CB89D
	public bool EndlessWaveEnabled
	{
		get
		{
			return this.GetBehaviorTreeVarToNumber(ESurvivorsRougeSystemVarType.EndlessBatchLimit) == 1;
		}
	}

	// Token: 0x06016DE1 RID: 93665 RVA: 0x005CD6A9 File Offset: 0x005CB8A9
	public void EquipExplorePhantomSkill()
	{
	}

	// Token: 0x06016DE2 RID: 93666 RVA: 0x005CD6AB File Offset: 0x005CB8AB
	public void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
	{
		this.RefreshSkillCd(groupSkillCdInfo);
	}

	// Token: 0x06016DE3 RID: 93667 RVA: 0x005CD6B4 File Offset: 0x005CB8B4
	public void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
	{
		this.RefreshSkillCd(groupSkillCdInfo);
	}

	// Token: 0x06016DE4 RID: 93668 RVA: 0x005CD6C0 File Offset: 0x005CB8C0
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

	// Token: 0x0400A9C3 RID: 43459
	private const int ACTIVE_SKILL_ID = 220003;

	// Token: 0x0400A9C4 RID: 43460
	private const int DODGE_SKILL_ID = 100001;

	// Token: 0x0400A9C5 RID: 43461
	public BehaviorTreeUpdateDelegateProxy BehaviorDelegate = new BehaviorTreeUpdateDelegateProxy();

	// Token: 0x0400A9C6 RID: 43462
	private readonly Dictionary<string, SurvivorsRogueBattleSkillData> BattleSkillData = new Dictionary<string, SurvivorsRogueBattleSkillData>();
}
