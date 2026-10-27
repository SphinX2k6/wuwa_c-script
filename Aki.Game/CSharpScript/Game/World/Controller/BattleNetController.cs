using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02004536 RID: 17718
	public class BattleNetController : IStaticVariableResetter
	{
		// Token: 0x0602DC72 RID: 187506 RVA: 0x00A84EAF File Offset: 0x00A830AF
		static BattleNetController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleNetController.CreateStaticDefaultValue), new Action(BattleNetController.ResetStaticDefaultValue));
		}

		// Token: 0x0602DC73 RID: 187507 RVA: 0x00A84ECE File Offset: 0x00A830CE
		public static void CreateStaticDefaultValue()
		{
			BattleNetController.LastRequestTime = 0.0;
			BattleNetController.LastBatchRequestTime = 0.0;
			BattleNetController.LastCollectRequestTime = 0.0;
		}

		// Token: 0x0602DC74 RID: 187508 RVA: 0x00A84EFA File Offset: 0x00A830FA
		public static void ResetStaticDefaultValue()
		{
			BattleNetController.LastRequestTime = 0.0;
			BattleNetController.LastBatchRequestTime = 0.0;
			BattleNetController.LastCollectRequestTime = 0.0;
		}

		// Token: 0x0602DC75 RID: 187509 RVA: 0x00A84F28 File Offset: 0x00A83128
		public static UniTask<bool> RequestCaptureEntity(int entityId)
		{
			BattleNetController.<RequestCaptureEntity>d__6 <RequestCaptureEntity>d__;
			<RequestCaptureEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestCaptureEntity>d__.entityId = entityId;
			<RequestCaptureEntity>d__.<>1__state = -1;
			<RequestCaptureEntity>d__.<>t__builder.Start<BattleNetController.<RequestCaptureEntity>d__6>(ref <RequestCaptureEntity>d__);
			return <RequestCaptureEntity>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC76 RID: 187510 RVA: 0x00A84F6C File Offset: 0x00A8316C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<List<int>> RequestBatchCaptureEntity(List<int> entityIds)
		{
			BattleNetController.<RequestBatchCaptureEntity>d__7 <RequestBatchCaptureEntity>d__;
			<RequestBatchCaptureEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<int>>.Create();
			<RequestBatchCaptureEntity>d__.entityIds = entityIds;
			<RequestBatchCaptureEntity>d__.<>1__state = -1;
			<RequestBatchCaptureEntity>d__.<>t__builder.Start<BattleNetController.<RequestBatchCaptureEntity>d__7>(ref <RequestBatchCaptureEntity>d__);
			return <RequestBatchCaptureEntity>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC77 RID: 187511 RVA: 0x00A84FB0 File Offset: 0x00A831B0
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<List<long>> RequestBatchCollect(List<long> entityCreatureIds)
		{
			BattleNetController.<RequestBatchCollect>d__9 <RequestBatchCollect>d__;
			<RequestBatchCollect>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<long>>.Create();
			<RequestBatchCollect>d__.entityCreatureIds = entityCreatureIds;
			<RequestBatchCollect>d__.<>1__state = -1;
			<RequestBatchCollect>d__.<>t__builder.Start<BattleNetController.<RequestBatchCollect>d__9>(ref <RequestBatchCollect>d__);
			return <RequestBatchCollect>d__.<>t__builder.Task;
		}

		// Token: 0x0401872A RID: 100138
		private const int REQUEST_TIME_GAP = 2000;

		// Token: 0x0401872B RID: 100139
		private static double LastRequestTime;

		// Token: 0x0401872C RID: 100140
		private static double LastBatchRequestTime;

		// Token: 0x0401872D RID: 100141
		private static double LastCollectRequestTime;
	}
}
