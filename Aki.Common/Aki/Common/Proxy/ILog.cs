using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000024 RID: 36
	[NullableContext(1)]
	public interface ILog
	{
		// Token: 0x0600015D RID: 349
		void Error(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);

		// Token: 0x0600015E RID: 350 RVA: 0x0000EBBD File Offset: 0x0000CDBD
		void Error(ELogModule module, ELogAuthor author, string message, [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs)
		{
			this.ErrorWithLogList(module, author, message, pairs);
		}

		// Token: 0x0600015F RID: 351
		void ErrorWithLogList(ELogModule module, ELogAuthor author, string message, [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x06000160 RID: 352
		void ErrorWithStack(ELogModule module, ELogAuthor author, string message, Exception error, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);

		// Token: 0x06000161 RID: 353
		void Warn(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);

		// Token: 0x06000162 RID: 354
		void Info(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);
	}
}
