using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x0200001A RID: 26
	[NullableContext(1)]
	[Nullable(0)]
	public static class UniTaskExtension
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000E410 File Offset: 0x0000C610
		[NullableContext(2)]
		public static UniTask Finally(this UniTask task, Action onFinally)
		{
			UniTaskExtension.<Finally>d__0 <Finally>d__;
			<Finally>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Finally>d__.task = task;
			<Finally>d__.onFinally = onFinally;
			<Finally>d__.<>1__state = -1;
			<Finally>d__.<>t__builder.Start<UniTaskExtension.<Finally>d__0>(ref <Finally>d__);
			return <Finally>d__.<>t__builder.Task;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000E45C File Offset: 0x0000C65C
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<TR> Finally<TR>([Nullable(new byte[]
		{
			0,
			1
		})] this UniTask<TR> task, Action onFinally)
		{
			UniTaskExtension.<Finally>d__1<TR> <Finally>d__;
			<Finally>d__.<>t__builder = AsyncUniTaskMethodBuilder<TR>.Create();
			<Finally>d__.task = task;
			<Finally>d__.onFinally = onFinally;
			<Finally>d__.<>1__state = -1;
			<Finally>d__.<>t__builder.Start<UniTaskExtension.<Finally>d__1<TR>>(ref <Finally>d__);
			return <Finally>d__.<>t__builder.Task;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		public static UniTask Then(this UniTask task, Action onComplete)
		{
			UniTaskExtension.<Then>d__2 <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__2>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		public static UniTask Then<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this UniTask<T> task, Action<T> onComplete)
		{
			UniTaskExtension.<Then>d__3<T> <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__3<T>>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000E540 File Offset: 0x0000C740
		public static UniTask Then(this UniTask task, Action onComplete, Action onFault)
		{
			UniTaskExtension.<Then>d__4 <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__4>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000E594 File Offset: 0x0000C794
		public static UniTask Then(this UniTask task, Action onComplete, Action<Exception> onFault)
		{
			UniTaskExtension.<Then>d__5 <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__5>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		public static UniTask Then<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this UniTask<T> task, Action<T> onComplete, Action onFault)
		{
			UniTaskExtension.<Then>d__6<T> <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__6<T>>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000E63C File Offset: 0x0000C83C
		public static UniTask Then<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this UniTask<T> task, Action<T> onComplete, Action<Exception> onFault)
		{
			UniTaskExtension.<Then>d__7<T> <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__7<T>>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000E690 File Offset: 0x0000C890
		public static UniTask Then(this UniTask task, UniTask onComplete, Action onFault)
		{
			UniTaskExtension.<Then>d__8 <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__8>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		public static UniTask Then(this UniTask task, UniTask onComplete, Action<Exception> onFault)
		{
			UniTaskExtension.<Then>d__9 <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__9>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000E738 File Offset: 0x0000C938
		public static UniTask Then<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this UniTask<T> task, Func<T, UniTask> onComplete, Action onFault)
		{
			UniTaskExtension.<Then>d__10<T> <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__10<T>>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000E78C File Offset: 0x0000C98C
		public static UniTask Then<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this UniTask<T> task, Func<T, UniTask> onComplete, Action<Exception> onFault)
		{
			UniTaskExtension.<Then>d__11<T> <Then>d__;
			<Then>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Then>d__.task = task;
			<Then>d__.onComplete = onComplete;
			<Then>d__.onFault = onFault;
			<Then>d__.<>1__state = -1;
			<Then>d__.<>t__builder.Start<UniTaskExtension.<Then>d__11<T>>(ref <Then>d__);
			return <Then>d__.<>t__builder.Task;
		}
	}
}
