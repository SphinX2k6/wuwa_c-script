using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000019 RID: 25
	[NullableContext(1)]
	[Nullable(0)]
	public static class UniTaskExtension
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000AC68 File Offset: 0x00008E68
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

		// Token: 0x060000B0 RID: 176 RVA: 0x0000ACB4 File Offset: 0x00008EB4
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

		// Token: 0x060000B1 RID: 177 RVA: 0x0000AD00 File Offset: 0x00008F00
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

		// Token: 0x060000B2 RID: 178 RVA: 0x0000AD4C File Offset: 0x00008F4C
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

		// Token: 0x060000B3 RID: 179 RVA: 0x0000AD98 File Offset: 0x00008F98
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

		// Token: 0x060000B4 RID: 180 RVA: 0x0000ADEC File Offset: 0x00008FEC
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

		// Token: 0x060000B5 RID: 181 RVA: 0x0000AE40 File Offset: 0x00009040
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

		// Token: 0x060000B6 RID: 182 RVA: 0x0000AE94 File Offset: 0x00009094
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

		// Token: 0x060000B7 RID: 183 RVA: 0x0000AEE8 File Offset: 0x000090E8
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

		// Token: 0x060000B8 RID: 184 RVA: 0x0000AF3C File Offset: 0x0000913C
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

		// Token: 0x060000B9 RID: 185 RVA: 0x0000AF90 File Offset: 0x00009190
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

		// Token: 0x060000BA RID: 186 RVA: 0x0000AFE4 File Offset: 0x000091E4
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
