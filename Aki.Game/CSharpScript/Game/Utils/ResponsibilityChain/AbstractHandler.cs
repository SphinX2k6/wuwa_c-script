using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.ResponsibilityChain
{
	// Token: 0x0200455B RID: 17755
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class AbstractHandler<[Nullable(0)] T> : IParameterHandler<T> where T : IParameterContext
	{
		// Token: 0x0602DDBA RID: 187834 RVA: 0x00A8C06E File Offset: 0x00A8A26E
		public IParameterHandler<T> SetNext(IParameterHandler<T> handler)
		{
			this.NextHandler = handler;
			return handler;
		}

		// Token: 0x0602DDBB RID: 187835 RVA: 0x00A8C078 File Offset: 0x00A8A278
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

		// Token: 0x0602DDBC RID: 187836 RVA: 0x00A8C120 File Offset: 0x00A8A320
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

		// Token: 0x0602DDBD RID: 187837
		protected abstract bool CanHandle(T context);

		// Token: 0x0602DDBE RID: 187838
		protected abstract bool ShouldStop(T context);

		// Token: 0x0602DDBF RID: 187839
		protected abstract void ExecuteProcessing(T context);

		// Token: 0x0602DDC0 RID: 187840
		protected abstract void ExecuteStopping(T context);

		// Token: 0x040187EB RID: 100331
		private const bool ENABLE_RESPONSIBILITY_CHAIN_LOG = true;

		// Token: 0x040187EC RID: 100332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IParameterHandler<T> NextHandler;
	}
}
