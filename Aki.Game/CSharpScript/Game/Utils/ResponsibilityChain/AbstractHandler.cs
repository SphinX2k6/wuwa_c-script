using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.ResponsibilityChain
{
	// Token: 0x02003483 RID: 13443
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class AbstractHandler<[Nullable(0)] T> : IParameterHandler<T> where T : IParameterContext
	{
		// Token: 0x0602249C RID: 140444 RVA: 0x009B7786 File Offset: 0x009B5986
		public IParameterHandler<T> SetNext(IParameterHandler<T> handler)
		{
			this.NextHandler = handler;
			return handler;
		}

		// Token: 0x0602249D RID: 140445 RVA: 0x009B7790 File Offset: 0x009B5990
		public unsafe bool Handle(T context)
		{
			if (this.CanHandle(context))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ResponsibilityChain;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "AbstractHandler ExecuteProcessing";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Current Handler:", base.GetType().Name);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "NextHandler:";
				IParameterHandler<T> nextHandler = this.NextHandler;
				ptr = new ValueTuple<string, object>(item, (nextHandler != null) ? nextHandler.GetType().Name : null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.ExecuteProcessing(context);
				return true;
			}
			IParameterHandler<T> nextHandler2 = this.NextHandler;
			return nextHandler2 != null && nextHandler2.Handle(context);
		}

		// Token: 0x0602249E RID: 140446 RVA: 0x009B7838 File Offset: 0x009B5A38
		public unsafe bool Stop(T context)
		{
			if (this.ShouldStop(context))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ResponsibilityChain;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "AbstractHandler ExecuteStopping";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Current Handler:", base.GetType().Name);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "NextHandler:";
				IParameterHandler<T> nextHandler = this.NextHandler;
				ptr = new ValueTuple<string, object>(item, (nextHandler != null) ? nextHandler.GetType().Name : null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.ExecuteStopping(context);
				return true;
			}
			IParameterHandler<T> nextHandler2 = this.NextHandler;
			return nextHandler2 != null && nextHandler2.Stop(context);
		}

		// Token: 0x0602249F RID: 140447
		protected abstract bool CanHandle(T context);

		// Token: 0x060224A0 RID: 140448
		protected abstract bool ShouldStop(T context);

		// Token: 0x060224A1 RID: 140449
		protected abstract void ExecuteProcessing(T context);

		// Token: 0x060224A2 RID: 140450
		protected abstract void ExecuteStopping(T context);

		// Token: 0x04012E25 RID: 77349
		private const bool ENABLE_RESPONSIBILITY_CHAIN_LOG = true;

		// Token: 0x04012E26 RID: 77350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IParameterHandler<T> NextHandler;
	}
}
