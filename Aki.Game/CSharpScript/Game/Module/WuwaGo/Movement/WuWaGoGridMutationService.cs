using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200472F RID: 18223
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoGridMutationService : IWuWaGoGridMutationService
	{
		// Token: 0x0602F9DA RID: 195034 RVA: 0x00B07A56 File Offset: 0x00B05C56
		public WuWaGoGridMutationService(WuWaGoGameData data)
		{
		}

		// Token: 0x0602F9DB RID: 195035 RVA: 0x00B07A68 File Offset: 0x00B05C68
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<IWuWaGoMovableFloorBatchResult> ExecuteMovableFloorBatch(IReadOnlyList<MovableFloorController> controllers, string batchSource)
		{
			WuWaGoGridMutationService.<ExecuteMovableFloorBatch>d__3 <ExecuteMovableFloorBatch>d__;
			<ExecuteMovableFloorBatch>d__.<>t__builder = AsyncUniTaskMethodBuilder<IWuWaGoMovableFloorBatchResult>.Create();
			<ExecuteMovableFloorBatch>d__.<>4__this = this;
			<ExecuteMovableFloorBatch>d__.controllers = controllers;
			<ExecuteMovableFloorBatch>d__.batchSource = batchSource;
			<ExecuteMovableFloorBatch>d__.<>1__state = -1;
			<ExecuteMovableFloorBatch>d__.<>t__builder.Start<WuWaGoGridMutationService.<ExecuteMovableFloorBatch>d__3>(ref <ExecuteMovableFloorBatch>d__);
			return <ExecuteMovableFloorBatch>d__.<>t__builder.Task;
		}

		// Token: 0x0602F9DC RID: 195036 RVA: 0x00B07ABC File Offset: 0x00B05CBC
		private unsafe bool ValidateMovableFloorBatchRequests(IReadOnlyList<IMovableFloorMoveRequest> requests, string batchSource)
		{
			HashSet<string> hashSet = new HashSet<string>(from request in requests
			select request.RelocationRequest.OldKey);
			HashSet<string> hashSet2 = new HashSet<string>();
			WuWaGoGameData wuWaGoGameData = this.<data>P;
			foreach (IMovableFloorMoveRequest movableFloorMoveRequest in requests)
			{
				IWuWaGoGridRelocationRequest relocationRequest = movableFloorMoveRequest.RelocationRequest;
				if (!hashSet2.Add(relocationRequest.TargetKey))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.WuWaGo;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "移动板批量提交失败：目标坐标重复";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("batchSource", batchSource);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entityId", movableFloorMoveRequest.Controller.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pbDataId", movableFloorMoveRequest.Controller.Entity.EntityPbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("targetKey", relocationRequest.TargetKey);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					return false;
				}
				WuWaGoGrid gridByKey = wuWaGoGameData.GetGridByKey(relocationRequest.TargetKey);
				if (gridByKey != null && !hashSet.Contains(relocationRequest.TargetKey))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.WuWaGo;
					ELogAuthor author2 = ELogAuthor.YSQ;
					string message2 = "移动板批量提交失败：目标坐标被非本批次Grid占用";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("batchSource", batchSource);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("entityId", movableFloorMoveRequest.Controller.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("pbDataId", movableFloorMoveRequest.Controller.Entity.EntityPbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("targetKey", relocationRequest.TargetKey);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("occupiedGridId", gridByKey.Id);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602F9DD RID: 195037 RVA: 0x00B07D30 File Offset: 0x00B05F30
		private unsafe void RollbackMovableFloorBatchRequests(IReadOnlyList<IMovableFloorMoveRequest> requests, string batchSource)
		{
			foreach (IMovableFloorMoveRequest movableFloorMoveRequest in requests)
			{
				movableFloorMoveRequest.Controller.CancelPendingMove();
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WuWaGo;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "移动板批量提交已回滚";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("batchSource", batchSource);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", requests.Count);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602F9DE RID: 195038 RVA: 0x00B07DDC File Offset: 0x00B05FDC
		private IReadOnlyList<IGridMoveParticipantExecution> CollectParticipantExecutions(IReadOnlyList<IMovableFloorMoveRequest> requests)
		{
			Dictionary<string, IGridMoveParticipantExecution> dictionary = new Dictionary<string, IGridMoveParticipantExecution>();
			foreach (IMovableFloorMoveRequest movableFloorMoveRequest in requests)
			{
				foreach (IWuWaGoGridMoveParticipant wuWaGoGridMoveParticipant in movableFloorMoveRequest.RelocationRequest.Participants)
				{
					if (!dictionary.ContainsKey(wuWaGoGridMoveParticipant.ParticipantKey))
					{
						dictionary.Add(wuWaGoGridMoveParticipant.ParticipantKey, new GridMoveParticipantExecution
						{
							Participant = wuWaGoGridMoveParticipant,
							Context = movableFloorMoveRequest.RelocationRequest
						});
					}
				}
			}
			return dictionary.Values.ToList<IGridMoveParticipantExecution>();
		}

		// Token: 0x0602F9DF RID: 195039 RVA: 0x00B07EA0 File Offset: 0x00B060A0
		private void RunBeforeGridMoveParticipants(IReadOnlyList<IGridMoveParticipantExecution> executions)
		{
			foreach (IGridMoveParticipantExecution gridMoveParticipantExecution in executions)
			{
				Action<IWuWaGoGridRelocationContext> beforeGridMove = gridMoveParticipantExecution.Participant.BeforeGridMove;
				if (beforeGridMove != null)
				{
					beforeGridMove(gridMoveParticipantExecution.Context);
				}
			}
		}

		// Token: 0x0602F9E0 RID: 195040 RVA: 0x00B07F00 File Offset: 0x00B06100
		private UniTask RunAfterGridMoveParticipants(IReadOnlyList<IGridMoveParticipantExecution> executions)
		{
			WuWaGoGridMutationService.<RunAfterGridMoveParticipants>d__8 <RunAfterGridMoveParticipants>d__;
			<RunAfterGridMoveParticipants>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunAfterGridMoveParticipants>d__.executions = executions;
			<RunAfterGridMoveParticipants>d__.<>1__state = -1;
			<RunAfterGridMoveParticipants>d__.<>t__builder.Start<WuWaGoGridMutationService.<RunAfterGridMoveParticipants>d__8>(ref <RunAfterGridMoveParticipants>d__);
			return <RunAfterGridMoveParticipants>d__.<>t__builder.Task;
		}

		// Token: 0x0602F9E1 RID: 195041 RVA: 0x00B07F44 File Offset: 0x00B06144
		private IReadOnlyList<int> CollectMovedRoleIds(IReadOnlyList<IGridMoveParticipantExecution> executions)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (IGridMoveParticipantExecution gridMoveParticipantExecution in executions)
			{
				int? movedRoleId = gridMoveParticipantExecution.Participant.MovedRoleId;
				if (movedRoleId != null)
				{
					hashSet.Add(movedRoleId.Value);
				}
			}
			return hashSet.ToList<int>();
		}

		// Token: 0x0602F9E2 RID: 195042 RVA: 0x00B07FB4 File Offset: 0x00B061B4
		private IWuWaGoMovableFloorBatchResult CreateMovableFloorBatchResult(bool committed, [Nullable(2)] IReadOnlyList<int> movedRoleIds = null)
		{
			return new WuWaGoMovableFloorBatchResult
			{
				Committed = committed,
				MovedRoleIds = (movedRoleIds ?? new List<int>())
			};
		}

		// Token: 0x0602F9E3 RID: 195043 RVA: 0x00B07FD4 File Offset: 0x00B061D4
		[NullableContext(0)]
		private UniTask<bool> PlayRelocationPresentation([Nullable(1)] IMovableFloorMoveRequest request)
		{
			WuWaGoGridMutationService.<PlayRelocationPresentation>d__11 <PlayRelocationPresentation>d__;
			<PlayRelocationPresentation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayRelocationPresentation>d__.<>4__this = this;
			<PlayRelocationPresentation>d__.request = request;
			<PlayRelocationPresentation>d__.<>1__state = -1;
			<PlayRelocationPresentation>d__.<>t__builder.Start<WuWaGoGridMutationService.<PlayRelocationPresentation>d__11>(ref <PlayRelocationPresentation>d__);
			return <PlayRelocationPresentation>d__.<>t__builder.Task;
		}

		// Token: 0x0602F9E4 RID: 195044 RVA: 0x00B08020 File Offset: 0x00B06220
		private float? ResolveMoveSpeed()
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int? num = (setting != null) ? new int?(setting.MovableFloorMoveSpeed) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					num2 = num;
					if (num2 == null)
					{
						return null;
					}
					return new float?((float)num2.GetValueOrDefault());
				}
			}
			BP_WuWaGo_C setting2 = WuWaGoGlobal.Setting;
			int? num4 = (setting2 != null) ? new int?(setting2.SingleGridSize) : null;
			if ((num4 ?? 0) != 0)
			{
				int? num2 = num4;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() <= num3 & num2 != null))
				{
					num2 = num4;
					float? num5 = (num2 != null) ? new float?((float)num2.GetValueOrDefault()) : null;
					float num6 = (float)WuWaGoGridMutationService.LegacyMoveDurationPerGridMs / 1000f;
					if (num5 == null)
					{
						return null;
					}
					return new float?(num5.GetValueOrDefault() / num6);
				}
			}
			return null;
		}

		// Token: 0x04019B5E RID: 105310
		[CompilerGenerated]
		private WuWaGoGameData <data>P = data;

		// Token: 0x04019B5F RID: 105311
		private static readonly int LegacyMoveDurationPerGridMs = 150;
	}
}
