using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200476C RID: 18284
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayEntityActionExecutor : IStaticVariableResetter
	{
		// Token: 0x0602FCBC RID: 195772 RVA: 0x00B12AF6 File Offset: 0x00B10CF6
		static GameplayEntityActionExecutor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameplayEntityActionExecutor.CreateStaticDefaultValue), new Action(GameplayEntityActionExecutor.ResetStaticDefaultValue));
		}

		// Token: 0x0602FCBD RID: 195773 RVA: 0x00B12B15 File Offset: 0x00B10D15
		public static void CreateStaticDefaultValue()
		{
			GameplayEntityActionExecutor._executionContextStack = new List<IGameplayEntityExecutionContext>();
		}

		// Token: 0x0602FCBE RID: 195774 RVA: 0x00B12B21 File Offset: 0x00B10D21
		public static void ResetStaticDefaultValue()
		{
			GameplayEntityActionExecutor._executionContextStack = null;
		}

		// Token: 0x0602FCBF RID: 195775 RVA: 0x00B12B2C File Offset: 0x00B10D2C
		public static UniTask ExecuteActionList(WuWaGoGameModeBase gameMode, IReadOnlyList<ActionInfo> actionList)
		{
			GameplayEntityActionExecutor.<ExecuteActionList>d__5 <ExecuteActionList>d__;
			<ExecuteActionList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteActionList>d__.gameMode = gameMode;
			<ExecuteActionList>d__.actionList = actionList;
			<ExecuteActionList>d__.<>1__state = -1;
			<ExecuteActionList>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteActionList>d__5>(ref <ExecuteActionList>d__);
			return <ExecuteActionList>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC0 RID: 195776 RVA: 0x00B12B78 File Offset: 0x00B10D78
		public static UniTask ExecutePullRodImmediately(WuWaGoGameModeBase gameMode, WuWaGoPullRodEntity pullRod)
		{
			GameplayEntityActionExecutor.<ExecutePullRodImmediately>d__6 <ExecutePullRodImmediately>d__;
			<ExecutePullRodImmediately>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecutePullRodImmediately>d__.gameMode = gameMode;
			<ExecutePullRodImmediately>d__.pullRod = pullRod;
			<ExecutePullRodImmediately>d__.<>1__state = -1;
			<ExecutePullRodImmediately>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecutePullRodImmediately>d__6>(ref <ExecutePullRodImmediately>d__);
			return <ExecutePullRodImmediately>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC1 RID: 195777 RVA: 0x00B12BC4 File Offset: 0x00B10DC4
		private static void PrepareLinkedPullRodPresentation(int sourcePbDataId, EGameplayEntityState targetState)
		{
			IGameplayEntityExecutionContext currentExecutionContext = GameplayEntityActionExecutor.GetCurrentExecutionContext();
			WuWaGoGameModeBase wuWaGoGameModeBase = (currentExecutionContext != null) ? currentExecutionContext.GameMode : null;
			if (wuWaGoGameModeBase == null)
			{
				return;
			}
			foreach (int pbDataId in wuWaGoGameModeBase.GameplayEntityLinkService.GetLinkedGroupPbDataIds(sourcePbDataId))
			{
				PullRodController pullRodController = wuWaGoGameModeBase.GetEntityControllerByPbDataId(pbDataId) as PullRodController;
				if (pullRodController != null)
				{
					pullRodController.PrepareInteractPresentation(targetState);
				}
			}
		}

		// Token: 0x0602FCC2 RID: 195778 RVA: 0x00B12C40 File Offset: 0x00B10E40
		[NullableContext(0)]
		private static UniTask<bool> WaitForLinkedPullRodPresentation(int sourcePbDataId)
		{
			GameplayEntityActionExecutor.<WaitForLinkedPullRodPresentation>d__8 <WaitForLinkedPullRodPresentation>d__;
			<WaitForLinkedPullRodPresentation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WaitForLinkedPullRodPresentation>d__.sourcePbDataId = sourcePbDataId;
			<WaitForLinkedPullRodPresentation>d__.<>1__state = -1;
			<WaitForLinkedPullRodPresentation>d__.<>t__builder.Start<GameplayEntityActionExecutor.<WaitForLinkedPullRodPresentation>d__8>(ref <WaitForLinkedPullRodPresentation>d__);
			return <WaitForLinkedPullRodPresentation>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC3 RID: 195779 RVA: 0x00B12C84 File Offset: 0x00B10E84
		private static UniTask ExecuteActionListInternal(IReadOnlyList<ActionInfo> actionList)
		{
			GameplayEntityActionExecutor.<ExecuteActionListInternal>d__9 <ExecuteActionListInternal>d__;
			<ExecuteActionListInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteActionListInternal>d__.actionList = actionList;
			<ExecuteActionListInternal>d__.<>1__state = -1;
			<ExecuteActionListInternal>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteActionListInternal>d__9>(ref <ExecuteActionListInternal>d__);
			return <ExecuteActionListInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC4 RID: 195780 RVA: 0x00B12CC8 File Offset: 0x00B10EC8
		private static UniTask ExecuteWuWaGoAction(ActionInfo actionInfo)
		{
			GameplayEntityActionExecutor.<ExecuteWuWaGoAction>d__10 <ExecuteWuWaGoAction>d__;
			<ExecuteWuWaGoAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteWuWaGoAction>d__.actionInfo = actionInfo;
			<ExecuteWuWaGoAction>d__.<>1__state = -1;
			<ExecuteWuWaGoAction>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteWuWaGoAction>d__10>(ref <ExecuteWuWaGoAction>d__);
			return <ExecuteWuWaGoAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC5 RID: 195781 RVA: 0x00B12D0C File Offset: 0x00B10F0C
		private static UniTask ExecuteSingleEntityStateChange(int entityId, string stateTag)
		{
			GameplayEntityActionExecutor.<ExecuteSingleEntityStateChange>d__11 <ExecuteSingleEntityStateChange>d__;
			<ExecuteSingleEntityStateChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteSingleEntityStateChange>d__.entityId = entityId;
			<ExecuteSingleEntityStateChange>d__.stateTag = stateTag;
			<ExecuteSingleEntityStateChange>d__.<>1__state = -1;
			<ExecuteSingleEntityStateChange>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteSingleEntityStateChange>d__11>(ref <ExecuteSingleEntityStateChange>d__);
			return <ExecuteSingleEntityStateChange>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC6 RID: 195782 RVA: 0x00B12D58 File Offset: 0x00B10F58
		private static UniTask ExecuteEntityController(int pbDataId)
		{
			GameplayEntityActionExecutor.<ExecuteEntityController>d__12 <ExecuteEntityController>d__;
			<ExecuteEntityController>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteEntityController>d__.pbDataId = pbDataId;
			<ExecuteEntityController>d__.<>1__state = -1;
			<ExecuteEntityController>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteEntityController>d__12>(ref <ExecuteEntityController>d__);
			return <ExecuteEntityController>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC7 RID: 195783 RVA: 0x00B12D9C File Offset: 0x00B10F9C
		private static bool BeginExecutionContextIfNeeded(WuWaGoGameModeBase gameMode)
		{
			if (GameplayEntityActionExecutor.GetCurrentExecutionContext() != null)
			{
				return false;
			}
			GameplayEntityActionExecutor._executionContextStack.Add(new GameplayEntityExecutionContext
			{
				GameMode = gameMode,
				ExecutingPullRodGroups = new HashSet<int>(),
				PendingBowTrapPbDataIds = new HashSet<int>(),
				PendingMovableFloorPbDataIds = new HashSet<int>()
			});
			return true;
		}

		// Token: 0x0602FCC8 RID: 195784 RVA: 0x00B12DEC File Offset: 0x00B10FEC
		private static UniTask EndExecutionContextIfNeeded(bool isRootExecution)
		{
			GameplayEntityActionExecutor.<EndExecutionContextIfNeeded>d__14 <EndExecutionContextIfNeeded>d__;
			<EndExecutionContextIfNeeded>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndExecutionContextIfNeeded>d__.isRootExecution = isRootExecution;
			<EndExecutionContextIfNeeded>d__.<>1__state = -1;
			<EndExecutionContextIfNeeded>d__.<>t__builder.Start<GameplayEntityActionExecutor.<EndExecutionContextIfNeeded>d__14>(ref <EndExecutionContextIfNeeded>d__);
			return <EndExecutionContextIfNeeded>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCC9 RID: 195785 RVA: 0x00B12E2F File Offset: 0x00B1102F
		[NullableContext(2)]
		private static IGameplayEntityExecutionContext GetCurrentExecutionContext()
		{
			if (GameplayEntityActionExecutor._executionContextStack.Count != 0)
			{
				List<IGameplayEntityExecutionContext> executionContextStack = GameplayEntityActionExecutor._executionContextStack;
				return executionContextStack[executionContextStack.Count - 1];
			}
			return null;
		}

		// Token: 0x0602FCCA RID: 195786 RVA: 0x00B12E54 File Offset: 0x00B11054
		private static void QueuePendingBowTrap(int pbDataId)
		{
			IGameplayEntityExecutionContext currentExecutionContext = GameplayEntityActionExecutor.GetCurrentExecutionContext();
			if (currentExecutionContext == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "弓箭批量执行上下文不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", pbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			currentExecutionContext.PendingBowTrapPbDataIds.Add(pbDataId);
		}

		// Token: 0x0602FCCB RID: 195787 RVA: 0x00B12EA8 File Offset: 0x00B110A8
		private static void QueuePendingMovableFloor(int pbDataId)
		{
			IGameplayEntityExecutionContext currentExecutionContext = GameplayEntityActionExecutor.GetCurrentExecutionContext();
			if (currentExecutionContext == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "移动板批量执行上下文不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", pbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			currentExecutionContext.PendingMovableFloorPbDataIds.Add(pbDataId);
		}

		// Token: 0x0602FCCC RID: 195788 RVA: 0x00B12EFC File Offset: 0x00B110FC
		private static UniTask FlushPendingBowTraps(IGameplayEntityExecutionContext context)
		{
			GameplayEntityActionExecutor.<FlushPendingBowTraps>d__18 <FlushPendingBowTraps>d__;
			<FlushPendingBowTraps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushPendingBowTraps>d__.context = context;
			<FlushPendingBowTraps>d__.<>1__state = -1;
			<FlushPendingBowTraps>d__.<>t__builder.Start<GameplayEntityActionExecutor.<FlushPendingBowTraps>d__18>(ref <FlushPendingBowTraps>d__);
			return <FlushPendingBowTraps>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCCD RID: 195789 RVA: 0x00B12F40 File Offset: 0x00B11140
		private static UniTask FlushPendingMovableFloors(IGameplayEntityExecutionContext context)
		{
			GameplayEntityActionExecutor.<FlushPendingMovableFloors>d__19 <FlushPendingMovableFloors>d__;
			<FlushPendingMovableFloors>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushPendingMovableFloors>d__.context = context;
			<FlushPendingMovableFloors>d__.<>1__state = -1;
			<FlushPendingMovableFloors>d__.<>t__builder.Start<GameplayEntityActionExecutor.<FlushPendingMovableFloors>d__19>(ref <FlushPendingMovableFloors>d__);
			return <FlushPendingMovableFloors>d__.<>t__builder.Task;
		}

		// Token: 0x04019C94 RID: 105620
		private const string DAMAGE_BATCH_REASON_IMMEDIATE_BOW_TRAP = "ImmediateBowTrapActionList";

		// Token: 0x04019C95 RID: 105621
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<IGameplayEntityExecutionContext> _executionContextStack;
	}
}
