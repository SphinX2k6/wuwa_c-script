using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x0200345E RID: 13406
	public class BattleNetController : IStaticVariableResetter
	{
		// Token: 0x0602234F RID: 140111 RVA: 0x009B039F File Offset: 0x009AE59F
		static BattleNetController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleNetController.CreateStaticDefaultValue), new Action(BattleNetController.ResetStaticDefaultValue));
		}

		// Token: 0x06022350 RID: 140112 RVA: 0x009B03BE File Offset: 0x009AE5BE
		public static void CreateStaticDefaultValue()
		{
			BattleNetController.LastRequestTime = 0.0;
			BattleNetController.LastBatchRequestTime = 0.0;
			BattleNetController.LastCollectRequestTime = 0.0;
		}

		// Token: 0x06022351 RID: 140113 RVA: 0x009B03EA File Offset: 0x009AE5EA
		public static void ResetStaticDefaultValue()
		{
			BattleNetController.LastRequestTime = 0.0;
			BattleNetController.LastBatchRequestTime = 0.0;
			BattleNetController.LastCollectRequestTime = 0.0;
		}

		// Token: 0x06022352 RID: 140114 RVA: 0x009B0418 File Offset: 0x009AE618
		public static UniTask<bool> RequestCaptureEntity(int entityId)
		{
			BattleNetController.<RequestCaptureEntity>d__6 <RequestCaptureEntity>d__;
			<RequestCaptureEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestCaptureEntity>d__.entityId = entityId;
			<RequestCaptureEntity>d__.<>1__state = -1;
			<RequestCaptureEntity>d__.<>t__builder.Start<BattleNetController.<RequestCaptureEntity>d__6>(ref <RequestCaptureEntity>d__);
			return <RequestCaptureEntity>d__.<>t__builder.Task;
		}

		// Token: 0x06022353 RID: 140115 RVA: 0x009B045C File Offset: 0x009AE65C
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

		// Token: 0x06022354 RID: 140116 RVA: 0x009B04A0 File Offset: 0x009AE6A0
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

		// Token: 0x04012D5D RID: 77149
		private const int REQUEST_TIME_GAP = 2000;

		// Token: 0x04012D5E RID: 77150
		private static double LastRequestTime;

		// Token: 0x04012D5F RID: 77151
		private static double LastBatchRequestTime;

		// Token: 0x04012D60 RID: 77152
		private static double LastCollectRequestTime;
	}
}
