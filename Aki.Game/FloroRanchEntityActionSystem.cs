using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B21 RID: 6945
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityActionSystem : IStaticVariableResetter
{
	// Token: 0x0600CE1A RID: 52762 RVA: 0x002EEAE0 File Offset: 0x002ECCE0
	static FloroRanchEntityActionSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchEntityActionSystem.CreateStaticDefaultValue), new Action(FloroRanchEntityActionSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0600CE1B RID: 52763 RVA: 0x002EEAFF File Offset: 0x002ECCFF
	public static void CreateStaticDefaultValue()
	{
		FloroRanchEntityActionSystem.CurrentAction = null;
	}

	// Token: 0x0600CE1C RID: 52764 RVA: 0x002EEB07 File Offset: 0x002ECD07
	public static void ResetStaticDefaultValue()
	{
		FloroRanchEntityActionSystem.CurrentAction = null;
	}

	// Token: 0x0600CE1D RID: 52765 RVA: 0x002EEB10 File Offset: 0x002ECD10
	public static UniTask DayStart(FloroRanchDayStart dayStartData)
	{
		FloroRanchEntityActionSystem.<DayStart>d__4 <DayStart>d__;
		<DayStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DayStart>d__.dayStartData = dayStartData;
		<DayStart>d__.<>1__state = -1;
		<DayStart>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<DayStart>d__4>(ref <DayStart>d__);
		return <DayStart>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE1E RID: 52766 RVA: 0x002EEB54 File Offset: 0x002ECD54
	public static UniTask ExecuteActionList(List<FloroRanchUnitActionMsg> actionDataList)
	{
		FloroRanchEntityActionSystem.<ExecuteActionList>d__5 <ExecuteActionList>d__;
		<ExecuteActionList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteActionList>d__.actionDataList = actionDataList;
		<ExecuteActionList>d__.<>1__state = -1;
		<ExecuteActionList>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<ExecuteActionList>d__5>(ref <ExecuteActionList>d__);
		return <ExecuteActionList>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE1F RID: 52767 RVA: 0x002EEB98 File Offset: 0x002ECD98
	public static UniTask ExecuteWageSettleAction(FloroRanchWageSettleTask wageSettle)
	{
		FloroRanchEntityActionSystem.<ExecuteWageSettleAction>d__6 <ExecuteWageSettleAction>d__;
		<ExecuteWageSettleAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteWageSettleAction>d__.wageSettle = wageSettle;
		<ExecuteWageSettleAction>d__.<>1__state = -1;
		<ExecuteWageSettleAction>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<ExecuteWageSettleAction>d__6>(ref <ExecuteWageSettleAction>d__);
		return <ExecuteWageSettleAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE20 RID: 52768 RVA: 0x002EEBDC File Offset: 0x002ECDDC
	private static bool CheckCanExecuteAction()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanchEntityActionSystem ExecuteActionList 正在执行", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x0600CE21 RID: 52769 RVA: 0x002EEC12 File Offset: 0x002ECE12
	public static void Pause()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			FloroRanchEntityActionSystem.CurrentAction.Pause();
		}
	}

	// Token: 0x0600CE22 RID: 52770 RVA: 0x002EEC25 File Offset: 0x002ECE25
	public static void Resume()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			FloroRanchEntityActionSystem.CurrentAction.Resume();
		}
	}

	// Token: 0x0600CE23 RID: 52771 RVA: 0x002EEC38 File Offset: 0x002ECE38
	public static void Exit()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			FloroRanchEntityActionSystem.CurrentAction.Exit();
			FloroRanchEntityActionSystem.CurrentAction = null;
		}
	}

	// Token: 0x0600CE24 RID: 52772 RVA: 0x002EEC54 File Offset: 0x002ECE54
	public static FloroRanchActionDataBase CreateActionData(FloroRanchUnitActionMsg actionData)
	{
		switch (actionData.UnitActionType)
		{
		case FloroRanchUnitActionType.OpBuff:
			return new FloroRanchBuffUpdateActionData(actionData);
		case FloroRanchUnitActionType.OpUnit:
			return new FloroRanchEntityChangeActionData(actionData);
		case FloroRanchUnitActionType.UnitResourcesChange:
			return new FloroRanchResourceChangeActionData(actionData);
		case FloroRanchUnitActionType.Eating:
			return new FloroRanchEatGroupActionData(actionData);
		case FloroRanchUnitActionType.EvolveUpdate:
			return new FloroRanchEvolveUpdateActionData(actionData);
		case FloroRanchUnitActionType.Mix:
			return new FloroRanchFusionActionData(actionData);
		case FloroRanchUnitActionType.Sacrifice:
			return new FloroRanchSacrificeActionData(actionData);
		case FloroRanchUnitActionType.DebugActionInfo:
			return new FloroRanchDebugInfoActionData(actionData);
		case FloroRanchUnitActionType.BeEat:
			return new FloroRanchEatActionData(actionData);
		case FloroRanchUnitActionType.ChangePoint:
			return new FloroRanchChangePointActionData(actionData);
		case FloroRanchUnitActionType.ActionStop:
			return new FloroRanchActionStopActionData(actionData);
		case FloroRanchUnitActionType.ToyLvUp:
			return new FloroRanchToyLevelUpActionData(actionData);
		case FloroRanchUnitActionType.StageTributeChange:
			return new FloroRanchStageTributeChange(actionData);
		case FloroRanchUnitActionType.SelfDefineValue:
			return new FloroRanchSelfDefineValueActionData(actionData);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanchGamePlay;
		ELogAuthor author = ELogAuthor.BB;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 1);
		defaultInterpolatedStringHandler.AppendLiteral("FloroRanchEntityActionSystem CreateActionData 未知的行为类型:");
		defaultInterpolatedStringHandler.AppendFormatted<FloroRanchUnitActionType>(actionData.UnitActionType);
		instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		return new FloroRanchActionDataBase(actionData);
	}

	// Token: 0x0600CE25 RID: 52773 RVA: 0x002EED5C File Offset: 0x002ECF5C
	public static void DayEnd()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchGamePlayView);
		if (viewByName == null)
		{
			return;
		}
		((FloroRanchGamePlayView)viewByName).SetNewDayButtonActive(true);
	}

	// Token: 0x0600CE26 RID: 52774 RVA: 0x002EED8C File Offset: 0x002ECF8C
	public static UniTask AddEntities(List<FloroRanchPlayUnit> units)
	{
		FloroRanchEntityActionSystem.<AddEntities>d__13 <AddEntities>d__;
		<AddEntities>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddEntities>d__.units = units;
		<AddEntities>d__.<>1__state = -1;
		<AddEntities>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<AddEntities>d__13>(ref <AddEntities>d__);
		return <AddEntities>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE27 RID: 52775 RVA: 0x002EEDD0 File Offset: 0x002ECFD0
	public static UniTask AddEntity(FloroRanchPlayUnit unit)
	{
		FloroRanchEntityActionSystem.<AddEntity>d__14 <AddEntity>d__;
		<AddEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddEntity>d__.unit = unit;
		<AddEntity>d__.<>1__state = -1;
		<AddEntity>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<AddEntity>d__14>(ref <AddEntity>d__);
		return <AddEntity>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE28 RID: 52776 RVA: 0x002EEE14 File Offset: 0x002ED014
	public static UniTask RemoveEntity(int entityId)
	{
		FloroRanchEntityActionSystem.<RemoveEntity>d__15 <RemoveEntity>d__;
		<RemoveEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RemoveEntity>d__.entityId = entityId;
		<RemoveEntity>d__.<>1__state = -1;
		<RemoveEntity>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<RemoveEntity>d__15>(ref <RemoveEntity>d__);
		return <RemoveEntity>d__.<>t__builder.Task;
	}

	// Token: 0x04005E6D RID: 24173
	[Nullable(2)]
	private static FloroRanchAsyncActionBase CurrentAction;
}
