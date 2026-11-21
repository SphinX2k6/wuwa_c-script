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
	// Token: 0x0200369D RID: 13981
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayEntityActionExecutor : IStaticVariableResetter
	{
		// Token: 0x06024486 RID: 148614 RVA: 0x00A42AB6 File Offset: 0x00A40CB6
		static GameplayEntityActionExecutor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameplayEntityActionExecutor.CreateStaticDefaultValue), new Action(GameplayEntityActionExecutor.ResetStaticDefaultValue));
		}

		// Token: 0x06024487 RID: 148615 RVA: 0x00A42AD5 File Offset: 0x00A40CD5
		public static void CreateStaticDefaultValue()
		{
			GameplayEntityActionExecutor._executionContextStack = new List<IGameplayEntityExecutionContext>();
		}

		// Token: 0x06024488 RID: 148616 RVA: 0x00A42AE1 File Offset: 0x00A40CE1
		public static void ResetStaticDefaultValue()
		{
			GameplayEntityActionExecutor._executionContextStack = null;
		}

		// Token: 0x06024489 RID: 148617 RVA: 0x00A42AEC File Offset: 0x00A40CEC
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

		// Token: 0x0602448A RID: 148618 RVA: 0x00A42B38 File Offset: 0x00A40D38
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

		// Token: 0x0602448B RID: 148619 RVA: 0x00A42B84 File Offset: 0x00A40D84
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

		// Token: 0x0602448C RID: 148620 RVA: 0x00A42C00 File Offset: 0x00A40E00
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

		// Token: 0x0602448D RID: 148621 RVA: 0x00A42C44 File Offset: 0x00A40E44
		private static UniTask ExecuteActionListInternal(IReadOnlyList<ActionInfo> actionList)
		{
			GameplayEntityActionExecutor.<ExecuteActionListInternal>d__9 <ExecuteActionListInternal>d__;
			<ExecuteActionListInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteActionListInternal>d__.actionList = actionList;
			<ExecuteActionListInternal>d__.<>1__state = -1;
			<ExecuteActionListInternal>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteActionListInternal>d__9>(ref <ExecuteActionListInternal>d__);
			return <ExecuteActionListInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0602448E RID: 148622 RVA: 0x00A42C88 File Offset: 0x00A40E88
		private static UniTask ExecuteWuWaGoAction(ActionInfo actionInfo)
		{
			GameplayEntityActionExecutor.<ExecuteWuWaGoAction>d__10 <ExecuteWuWaGoAction>d__;
			<ExecuteWuWaGoAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteWuWaGoAction>d__.actionInfo = actionInfo;
			<ExecuteWuWaGoAction>d__.<>1__state = -1;
			<ExecuteWuWaGoAction>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteWuWaGoAction>d__10>(ref <ExecuteWuWaGoAction>d__);
			return <ExecuteWuWaGoAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602448F RID: 148623 RVA: 0x00A42CCC File Offset: 0x00A40ECC
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

		// Token: 0x06024490 RID: 148624 RVA: 0x00A42D18 File Offset: 0x00A40F18
		private static UniTask ExecuteEntityController(int pbDataId)
		{
			GameplayEntityActionExecutor.<ExecuteEntityController>d__12 <ExecuteEntityController>d__;
			<ExecuteEntityController>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteEntityController>d__.pbDataId = pbDataId;
			<ExecuteEntityController>d__.<>1__state = -1;
			<ExecuteEntityController>d__.<>t__builder.Start<GameplayEntityActionExecutor.<ExecuteEntityController>d__12>(ref <ExecuteEntityController>d__);
			return <ExecuteEntityController>d__.<>t__builder.Task;
		}

		// Token: 0x06024491 RID: 148625 RVA: 0x00A42D5C File Offset: 0x00A40F5C
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

		// Token: 0x06024492 RID: 148626 RVA: 0x00A42DAC File Offset: 0x00A40FAC
		private static UniTask EndExecutionContextIfNeeded(bool isRootExecution)
		{
			GameplayEntityActionExecutor.<EndExecutionContextIfNeeded>d__14 <EndExecutionContextIfNeeded>d__;
			<EndExecutionContextIfNeeded>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndExecutionContextIfNeeded>d__.isRootExecution = isRootExecution;
			<EndExecutionContextIfNeeded>d__.<>1__state = -1;
			<EndExecutionContextIfNeeded>d__.<>t__builder.Start<GameplayEntityActionExecutor.<EndExecutionContextIfNeeded>d__14>(ref <EndExecutionContextIfNeeded>d__);
			return <EndExecutionContextIfNeeded>d__.<>t__builder.Task;
		}

		// Token: 0x06024493 RID: 148627 RVA: 0x00A42DEF File Offset: 0x00A40FEF
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

		// Token: 0x06024494 RID: 148628 RVA: 0x00A42E14 File Offset: 0x00A41014
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

		// Token: 0x06024495 RID: 148629 RVA: 0x00A42E68 File Offset: 0x00A41068
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

		// Token: 0x06024496 RID: 148630 RVA: 0x00A42EBC File Offset: 0x00A410BC
		private static UniTask FlushPendingBowTraps(IGameplayEntityExecutionContext context)
		{
			GameplayEntityActionExecutor.<FlushPendingBowTraps>d__18 <FlushPendingBowTraps>d__;
			<FlushPendingBowTraps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushPendingBowTraps>d__.context = context;
			<FlushPendingBowTraps>d__.<>1__state = -1;
			<FlushPendingBowTraps>d__.<>t__builder.Start<GameplayEntityActionExecutor.<FlushPendingBowTraps>d__18>(ref <FlushPendingBowTraps>d__);
			return <FlushPendingBowTraps>d__.<>t__builder.Task;
		}

		// Token: 0x06024497 RID: 148631 RVA: 0x00A42F00 File Offset: 0x00A41100
		private static UniTask FlushPendingMovableFloors(IGameplayEntityExecutionContext context)
		{
			GameplayEntityActionExecutor.<FlushPendingMovableFloors>d__19 <FlushPendingMovableFloors>d__;
			<FlushPendingMovableFloors>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushPendingMovableFloors>d__.context = context;
			<FlushPendingMovableFloors>d__.<>1__state = -1;
			<FlushPendingMovableFloors>d__.<>t__builder.Start<GameplayEntityActionExecutor.<FlushPendingMovableFloors>d__19>(ref <FlushPendingMovableFloors>d__);
			return <FlushPendingMovableFloors>d__.<>t__builder.Task;
		}

		// Token: 0x04014344 RID: 82756
		private const string DAMAGE_BATCH_REASON_IMMEDIATE_BOW_TRAP = "ImmediateBowTrapActionList";

		// Token: 0x04014345 RID: 82757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<IGameplayEntityExecutionContext> _executionContextStack;
	}
}
