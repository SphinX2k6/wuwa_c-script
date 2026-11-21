using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.Unicode;

namespace System.Globalization
{
	// Token: 0x02000312 RID: 786
	[NullableContext(1)]
	[Nullable(0)]
	public class TextElementEnumerator : IEnumerator
	{
		// Token: 0x06003945 RID: 14661 RVA: 0x000BCF4D File Offset: 0x000BB14D
		internal TextElementEnumerator(string str, int startIndex)
		{
			this._str = str;
			this._strStartIndex = startIndex;
			this.Reset();
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x000BCF6C File Offset: 0x000BB16C
		public bool MoveNext()
		{
			this._currentTextElementSubstr = null;
			int num = this._currentTextElementOffset + this._currentTextElementLength;
			this._currentTextElementOffset = num;
			this._currentTextElementLength = 0;
			if (num >= this._str.Length)
			{
				return false;
			}
			this._currentTextElementLength = TextSegmentationUtility.GetLengthOfFirstUtf16ExtendedGraphemeCluster(this._str.AsSpan(num));
			return true;
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x000BCFC4 File Offset: 0x000BB1C4
		public object Current
		{
			get
			{
				return this.GetTextElement();
			}
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x000BCFCC File Offset: 0x000BB1CC
		public string GetTextElement()
		{
			string text = this._currentTextElementSubstr;
			if (text == null)
			{
				if (this._currentTextElementOffset >= this._str.Length)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
				}
				text = this._str.Substring(this._currentTextElementOffset, this._currentTextElementLength);
				this._currentTextElementSubstr = text;
			}
			return text;
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x000BD021 File Offset: 0x000BB221
		public int ElementIndex
		{
			get
			{
				if (this._currentTextElementOffset >= this._str.Length)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
				}
				return this._currentTextElementOffset - this._strStartIndex;
			}
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x000BD04E File Offset: 0x000BB24E
		public void Reset()
		{
			this._currentTextElementOffset = this._str.Length;
			this._currentTextElementLength = this._strStartIndex - this._str.Length;
			this._currentTextElementSubstr = null;
		}

		// Token: 0x04000B5B RID: 2907
		private readonly string _str;

		// Token: 0x04000B5C RID: 2908
		private readonly int _strStartIndex;

		// Token: 0x04000B5D RID: 2909
		private int _currentTextElementOffset;

		// Token: 0x04000B5E RID: 2910
		private int _currentTextElementLength;

		// Token: 0x04000B5F RID: 2911
		private string _currentTextElementSubstr;
	}
}
