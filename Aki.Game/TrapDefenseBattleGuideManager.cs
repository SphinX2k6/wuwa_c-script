using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001203 RID: 4611
public class TrapDefenseBattleGuideManager : IStaticVariableResetter
{
	// Token: 0x0600B743 RID: 46915 RVA: 0x00361C1D File Offset: 0x0035FE1D
	static TrapDefenseBattleGuideManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrapDefenseBattleGuideManager.CreateStaticDefaultValue), new Action(TrapDefenseBattleGuideManager.ResetStaticDefaultValue));
	}

	// Token: 0x0600B744 RID: 46916 RVA: 0x00361C3C File Offset: 0x0035FE3C
	public static void CreateStaticDefaultValue()
	{
		TrapDefenseBattleGuideManager.CurrentDataMap = new Dictionary<ETrapDefensePlayerOperationType, TrapDefenseBattleGuideData>();
	}

	// Token: 0x0600B745 RID: 46917 RVA: 0x00361C48 File Offset: 0x0035FE48
	public static void ResetStaticDefaultValue()
	{
		TrapDefenseBattleGuideManager.CurrentDataMap = null;
	}

	// Token: 0x0600B746 RID: 46918 RVA: 0x00361C50 File Offset: 0x0035FE50
	public static void Initialize()
	{
	}

	// Token: 0x0600B747 RID: 46919 RVA: 0x00361C52 File Offset: 0x0035FE52
	public static void Clear()
	{
		TrapDefenseBattleGuideManager.CurrentDataMap.Clear();
	}

	// Token: 0x0600B748 RID: 46920 RVA: 0x00361C60 File Offset: 0x0035FE60
	[NullableContext(1)]
	public static void RegisterBehaviorTreeGuideData(TrapDefensePlayerOperationConstraint param)
	{
		if (param.IsConstrained)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.TowerDefenseBattle;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "注册塔防行为约束";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", param.DisableOperation.Type);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TrapDefenseBattleGuideData trapDefenseBattleGuideData = new TrapDefenseBattleGuideData();
			trapDefenseBattleGuideData.BanType = param.DisableOperation.Type;
			trapDefenseBattleGuideData.Tips = param.TidPromptTxt;
			TrapDefenseBattleGuideManager.CurrentDataMap[param.DisableOperation.Type] = trapDefenseBattleGuideData;
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.TowerDefenseBattle;
		ELogAuthor author2 = ELogAuthor.XXJ;
		string message2 = "删除塔防行为约束";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", param.DisableOperation.Type);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		TrapDefenseBattleGuideManager.CurrentDataMap.Remove(param.DisableOperation.Type);
	}

	// Token: 0x0600B749 RID: 46921 RVA: 0x00361D38 File Offset: 0x0035FF38
	public static bool CheckCanExecuteAndShowFailTips(ETrapDefensePlayerOperationType type)
	{
		if (TrapDefenseBattleGuideManager.CurrentDataMap.Count <= 0)
		{
			return true;
		}
		TrapDefenseBattleGuideData trapDefenseBattleGuideData;
		if (TrapDefenseBattleGuideManager.CurrentDataMap.TryGetValue(type, out trapDefenseBattleGuideData))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId(trapDefenseBattleGuideData.Tips, Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x040069C8 RID: 27080
	[Nullable(1)]
	private static Dictionary<ETrapDefensePlayerOperationType, TrapDefenseBattleGuideData> CurrentDataMap;
}
