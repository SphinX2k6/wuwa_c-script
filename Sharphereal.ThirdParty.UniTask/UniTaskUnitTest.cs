using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Sharphereal.UniTaskExtensions
{
	// Token: 0x02000002 RID: 2
	public class UniTaskUnitTest
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public UniTask<bool> Run()
		{
			UniTaskUnitTest.<Run>d__1 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<UniTaskUnitTest.<Run>d__1>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002094 File Offset: 0x00000294
		private UniTask<bool> TestYield()
		{
			UniTaskUnitTest.<TestYield>d__2 <TestYield>d__;
			<TestYield>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TestYield>d__.<>1__state = -1;
			<TestYield>d__.<>t__builder.Start<UniTaskUnitTest.<TestYield>d__2>(ref <TestYield>d__);
			return <TestYield>d__.<>t__builder.Task;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020D0 File Offset: 0x000002D0
		private UniTask<bool> TestEndOfFrame()
		{
			UniTaskUnitTest.<TestEndOfFrame>d__3 <TestEndOfFrame>d__;
			<TestEndOfFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TestEndOfFrame>d__.<>1__state = -1;
			<TestEndOfFrame>d__.<>t__builder.Start<UniTaskUnitTest.<TestEndOfFrame>d__3>(ref <TestEndOfFrame>d__);
			return <TestEndOfFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000210C File Offset: 0x0000030C
		private UniTask<bool> TestNextFrame()
		{
			UniTaskUnitTest.<TestNextFrame>d__4 <TestNextFrame>d__;
			<TestNextFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TestNextFrame>d__.<>1__state = -1;
			<TestNextFrame>d__.<>t__builder.Start<UniTaskUnitTest.<TestNextFrame>d__4>(ref <TestNextFrame>d__);
			return <TestNextFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002148 File Offset: 0x00000348
		private UniTask<bool> TestWaitForSeconds()
		{
			UniTaskUnitTest.<TestWaitForSeconds>d__5 <TestWaitForSeconds>d__;
			<TestWaitForSeconds>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TestWaitForSeconds>d__.<>1__state = -1;
			<TestWaitForSeconds>d__.<>t__builder.Start<UniTaskUnitTest.<TestWaitForSeconds>d__5>(ref <TestWaitForSeconds>d__);
			return <TestWaitForSeconds>d__.<>t__builder.Task;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002184 File Offset: 0x00000384
		private UniTask<bool> TestDelay()
		{
			UniTaskUnitTest.<TestDelay>d__6 <TestDelay>d__;
			<TestDelay>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TestDelay>d__.<>1__state = -1;
			<TestDelay>d__.<>t__builder.Start<UniTaskUnitTest.<TestDelay>d__6>(ref <TestDelay>d__);
			return <TestDelay>d__.<>t__builder.Task;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021C0 File Offset: 0x000003C0
		private UniTask<int> TestTaskCompletionSource()
		{
			UniTaskUnitTest.<TestTaskCompletionSource>d__7 <TestTaskCompletionSource>d__;
			<TestTaskCompletionSource>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<TestTaskCompletionSource>d__.<>4__this = this;
			<TestTaskCompletionSource>d__.<>1__state = -1;
			<TestTaskCompletionSource>d__.<>t__builder.Start<UniTaskUnitTest.<TestTaskCompletionSource>d__7>(ref <TestTaskCompletionSource>d__);
			return <TestTaskCompletionSource>d__.<>t__builder.Task;
		}

		// Token: 0x04000001 RID: 1
		[Nullable(2)]
		private UniTaskCompletionSource<int> _tcs1;
	}
}
