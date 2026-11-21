using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000377 RID: 887
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	[DebuggerTypeProxy(typeof(SearchValuesDebugView<>))]
	public class SearchValues<T> where T : IEquatable<T>
	{
		// Token: 0x06003BCE RID: 15310 RVA: 0x00005ACC File Offset: 0x00003CCC
		private protected SearchValues()
		{
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x000C7206 File Offset: 0x000C5406
		internal virtual T[] GetValues()
		{
			throw new UnreachableException();
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x000C720D File Offset: 0x000C540D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(T value)
		{
			return this.ContainsCore(value);
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x000C7206 File Offset: 0x000C5406
		internal virtual bool ContainsCore(T value)
		{
			throw new UnreachableException();
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x000C7206 File Offset: 0x000C5406
		internal virtual int IndexOfAny(ReadOnlySpan<T> span)
		{
			throw new UnreachableException();
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x000C7206 File Offset: 0x000C5406
		internal virtual int IndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			throw new UnreachableException();
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x000C7206 File Offset: 0x000C5406
		internal virtual int LastIndexOfAny(ReadOnlySpan<T> span)
		{
			throw new UnreachableException();
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x000C7206 File Offset: 0x000C5406
		internal virtual int LastIndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			throw new UnreachableException();
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x000C7216 File Offset: 0x000C5416
		internal virtual bool ContainsAny(ReadOnlySpan<T> span)
		{
			return this.IndexOfAny(span) >= 0;
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x000C7225 File Offset: 0x000C5425
		internal virtual bool ContainsAnyExcept(ReadOnlySpan<T> span)
		{
			return this.IndexOfAnyExcept(span) >= 0;
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x000C7206 File Offset: 0x000C5406
		internal virtual int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			throw new UnreachableException();
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x000C7234 File Offset: 0x000C5434
		[Nullable(1)]
		private unsafe string DebuggerDisplay
		{
			get
			{
				T[] values = this.GetValues();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler.AppendFormatted(base.GetType().Name);
				defaultInterpolatedStringHandler.AppendLiteral(", Count = ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(values.Length);
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				if (values.Length != 0)
				{
					text += ", Values = ";
					text += ((typeof(T) == typeof(char)) ? ("\"" + new string(*Unsafe.As<T[], char[]>(ref values)) + "\"") : string.Join<T>(",", values));
				}
				return text;
			}
		}
	}
}
