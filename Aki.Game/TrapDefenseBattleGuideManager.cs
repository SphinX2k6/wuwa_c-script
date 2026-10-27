using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001D41 RID: 7489
public class TrapDefenseBattleGuideManager : IStaticVariableResetter
{
	// Token: 0x0600E326 RID: 58150 RVA: 0x003561ED File Offset: 0x003543ED
	static TrapDefenseBattleGuideManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrapDefenseBattleGuideManager.CreateStaticDefaultValue), new Action(TrapDefenseBattleGuideManager.ResetStaticDefaultValue));
	}

	// Token: 0x0600E327 RID: 58151 RVA: 0x0035620C File Offset: 0x0035440C
	public static void CreateStaticDefaultValue()
	{
		TrapDefenseBattleGuideManager.CurrentDataMap = new Dictionary<ETrapDefensePlayerOperationType, TrapDefenseBattleGuideData>();
	}

	// Token: 0x0600E328 RID: 58152 RVA: 0x00356218 File Offset: 0x00354418
	public static void ResetStaticDefaultValue()
	{
		TrapDefenseBattleGuideManager.CurrentDataMap = null;
	}

	// Token: 0x0600E329 RID: 58153 RVA: 0x00356220 File Offset: 0x00354420
	public static void Initialize()
	{
	}

	// Token: 0x0600E32A RID: 58154 RVA: 0x00356222 File Offset: 0x00354422
	public static void Clear()
	{
		TrapDefenseBattleGuideManager.CurrentDataMap.Clear();
	}

	// Token: 0x0600E32B RID: 58155 RVA: 0x00356230 File Offset: 0x00354430
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

	// Token: 0x0600E32C RID: 58156 RVA: 0x00356308 File Offset: 0x00354508
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

	// Token: 0x040068E9 RID: 26857
	[Nullable(1)]
	private static Dictionary<ETrapDefensePlayerOperationType, TrapDefenseBattleGuideData> CurrentDataMap;
}
