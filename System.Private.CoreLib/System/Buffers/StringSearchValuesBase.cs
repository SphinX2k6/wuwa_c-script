using System;
using System.Collections.Generic;

namespace System.Buffers
{
	// Token: 0x02000399 RID: 921
	internal abstract class StringSearchValuesBase : SearchValues<string>
	{
		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x000CA1F1 File Offset: 0x000C83F1
		protected bool HasUniqueValues
		{
			get
			{
				return this._uniqueValues != null;
			}
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x000CA1FF File Offset: 0x000C83FF
		public StringSearchValuesBase(HashSet<string> uniqueValues)
		{
			this._uniqueValues = uniqueValues;
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x000CA20E File Offset: 0x000C840E
		internal override bool ContainsCore(string value)
		{
			return this._uniqueValues.Contains(value);
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x000CA21C File Offset: 0x000C841C
		internal override string[] GetValues()
		{
			string[] array = new string[this._uniqueValues.Count];
			this._uniqueValues.CopyTo(array);
			return array;
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x000CA247 File Offset: 0x000C8447
		internal sealed override int IndexOfAny(ReadOnlySpan<string> span)
		{
			return this.IndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(span);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x000CA250 File Offset: 0x000C8450
		internal sealed override int IndexOfAnyExcept(ReadOnlySpan<string> span)
		{
			return this.IndexOfAny<IndexOfAnyAsciiSearcher.Negate>(span);
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x000CA259 File Offset: 0x000C8459
		internal sealed override int LastIndexOfAny(ReadOnlySpan<string> span)
		{
			return this.LastIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(span);
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x000CA262 File Offset: 0x000C8462
		internal sealed override int LastIndexOfAnyExcept(ReadOnlySpan<string> span)
		{
			return this.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate>(span);
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x000CA26C File Offset: 0x000C846C
		private unsafe int IndexOfAny<TNegator>(ReadOnlySpan<string> span) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			for (int i = 0; i < span.Length; i++)
			{
				if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(this.ContainsCore(*span[i])))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x000CA2AC File Offset: 0x000C84AC
		private unsafe int LastIndexOfAny<TNegator>(ReadOnlySpan<string> span) where TNegator : struct, IndexOfAnyAsciiSearcher.INegator
		{
			for (int i = span.Length - 1; i >= 0; i--)
			{
				if (IndexOfAnyAsciiSearcher.INegator.NegateIfNeeded(this.ContainsCore(*span[i])))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x04000CC4 RID: 3268
		private readonly HashSet<string> _uniqueValues;
	}
}
