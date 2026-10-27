using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000023 RID: 35
	[NullableContext(1)]
	public interface ILog
	{
		// Token: 0x060000F0 RID: 240
		void Error(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);

		// Token: 0x060000F1 RID: 241 RVA: 0x0000B3F1 File Offset: 0x000095F1
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

		// Token: 0x060000F2 RID: 242
		void ErrorWithLogList(ELogModule module, ELogAuthor author, string message, [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] LogList<ValueTuple<string, object>> pairs);

		// Token: 0x060000F3 RID: 243
		void ErrorWithStack(ELogModule module, ELogAuthor author, string message, Exception error, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);

		// Token: 0x060000F4 RID: 244
		void Warn(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);

		// Token: 0x060000F5 RID: 245
		void Info(ELogModule module, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs);
	}
}
