using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FE0 RID: 4064
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityActionSystem : IStaticVariableResetter
{
	// Token: 0x0600A22B RID: 41515 RVA: 0x002F9BC0 File Offset: 0x002F7DC0
	static FloroRanchEntityActionSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchEntityActionSystem.CreateStaticDefaultValue), new Action(FloroRanchEntityActionSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0600A22C RID: 41516 RVA: 0x002F9BDF File Offset: 0x002F7DDF
	public static void CreateStaticDefaultValue()
	{
		FloroRanchEntityActionSystem.CurrentAction = null;
	}

	// Token: 0x0600A22D RID: 41517 RVA: 0x002F9BE7 File Offset: 0x002F7DE7
	public static void ResetStaticDefaultValue()
	{
		FloroRanchEntityActionSystem.CurrentAction = null;
	}

	// Token: 0x0600A22E RID: 41518 RVA: 0x002F9BF0 File Offset: 0x002F7DF0
	public static UniTask DayStart(FloroRanchDayStart dayStartData)
	{
		FloroRanchEntityActionSystem.<DayStart>d__4 <DayStart>d__;
		<DayStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DayStart>d__.dayStartData = dayStartData;
		<DayStart>d__.<>1__state = -1;
		<DayStart>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<DayStart>d__4>(ref <DayStart>d__);
		return <DayStart>d__.<>t__builder.Task;
	}

	// Token: 0x0600A22F RID: 41519 RVA: 0x002F9C34 File Offset: 0x002F7E34
	public static UniTask ExecuteActionList(List<FloroRanchUnitActionMsg> actionDataList)
	{
		FloroRanchEntityActionSystem.<ExecuteActionList>d__5 <ExecuteActionList>d__;
		<ExecuteActionList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteActionList>d__.actionDataList = actionDataList;
		<ExecuteActionList>d__.<>1__state = -1;
		<ExecuteActionList>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<ExecuteActionList>d__5>(ref <ExecuteActionList>d__);
		return <ExecuteActionList>d__.<>t__builder.Task;
	}

	// Token: 0x0600A230 RID: 41520 RVA: 0x002F9C78 File Offset: 0x002F7E78
	public static UniTask ExecuteWageSettleAction(FloroRanchWageSettleTask wageSettle)
	{
		FloroRanchEntityActionSystem.<ExecuteWageSettleAction>d__6 <ExecuteWageSettleAction>d__;
		<ExecuteWageSettleAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteWageSettleAction>d__.wageSettle = wageSettle;
		<ExecuteWageSettleAction>d__.<>1__state = -1;
		<ExecuteWageSettleAction>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<ExecuteWageSettleAction>d__6>(ref <ExecuteWageSettleAction>d__);
		return <ExecuteWageSettleAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600A231 RID: 41521 RVA: 0x002F9CBC File Offset: 0x002F7EBC
	private static bool CheckCanExecuteAction()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanchEntityActionSystem ExecuteActionList 正在执行", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x0600A232 RID: 41522 RVA: 0x002F9CF2 File Offset: 0x002F7EF2
	public static void Pause()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			FloroRanchEntityActionSystem.CurrentAction.Pause();
		}
	}

	// Token: 0x0600A233 RID: 41523 RVA: 0x002F9D05 File Offset: 0x002F7F05
	public static void Resume()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			FloroRanchEntityActionSystem.CurrentAction.Resume();
		}
	}

	// Token: 0x0600A234 RID: 41524 RVA: 0x002F9D18 File Offset: 0x002F7F18
	public static void Exit()
	{
		if (FloroRanchEntityActionSystem.CurrentAction != null)
		{
			FloroRanchEntityActionSystem.CurrentAction.Exit();
			FloroRanchEntityActionSystem.CurrentAction = null;
		}
	}

	// Token: 0x0600A235 RID: 41525 RVA: 0x002F9D34 File Offset: 0x002F7F34
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

	// Token: 0x0600A236 RID: 41526 RVA: 0x002F9E3C File Offset: 0x002F803C
	public static void DayEnd()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchGamePlayView);
		if (viewByName == null)
		{
			return;
		}
		((FloroRanchGamePlayView)viewByName).SetNewDayButtonActive(true);
	}

	// Token: 0x0600A237 RID: 41527 RVA: 0x002F9E6C File Offset: 0x002F806C
	public static UniTask AddEntities(List<FloroRanchPlayUnit> units)
	{
		FloroRanchEntityActionSystem.<AddEntities>d__13 <AddEntities>d__;
		<AddEntities>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddEntities>d__.units = units;
		<AddEntities>d__.<>1__state = -1;
		<AddEntities>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<AddEntities>d__13>(ref <AddEntities>d__);
		return <AddEntities>d__.<>t__builder.Task;
	}

	// Token: 0x0600A238 RID: 41528 RVA: 0x002F9EB0 File Offset: 0x002F80B0
	public static UniTask AddEntity(FloroRanchPlayUnit unit)
	{
		FloroRanchEntityActionSystem.<AddEntity>d__14 <AddEntity>d__;
		<AddEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddEntity>d__.unit = unit;
		<AddEntity>d__.<>1__state = -1;
		<AddEntity>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<AddEntity>d__14>(ref <AddEntity>d__);
		return <AddEntity>d__.<>t__builder.Task;
	}

	// Token: 0x0600A239 RID: 41529 RVA: 0x002F9EF4 File Offset: 0x002F80F4
	public static UniTask RemoveEntity(int entityId)
	{
		FloroRanchEntityActionSystem.<RemoveEntity>d__15 <RemoveEntity>d__;
		<RemoveEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RemoveEntity>d__.entityId = entityId;
		<RemoveEntity>d__.<>1__state = -1;
		<RemoveEntity>d__.<>t__builder.Start<FloroRanchEntityActionSystem.<RemoveEntity>d__15>(ref <RemoveEntity>d__);
		return <RemoveEntity>d__.<>t__builder.Task;
	}

	// Token: 0x04005F3C RID: 24380
	[Nullable(2)]
	private static FloroRanchAsyncActionBase CurrentAction;
}
