using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000226 RID: 550
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class EncoderReplacementFallback : EncoderFallback
	{
		// Token: 0x06002A04 RID: 10756 RVA: 0x0008337B File Offset: 0x0008157B
		public EncoderReplacementFallback() : this("?")
		{
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00083388 File Offset: 0x00081588
		public EncoderReplacementFallback(string replacement)
		{
			ArgumentNullException.ThrowIfNull(replacement, "replacement");
			bool flag = false;
			foreach (char c in replacement)
			{
				if (char.IsSurrogate(c))
				{
					if (char.IsHighSurrogate(c))
					{
						if (flag)
						{
							break;
						}
						flag = true;
					}
					else
					{
						if (!flag)
						{
							flag = true;
							break;
						}
						flag = false;
					}
				}
				else if (flag)
				{
					break;
				}
			}
			if (flag)
			{
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex, "replacement");
			}
			this._strDefault = replacement;
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x00083402 File Offset: 0x00081602
		public string DefaultString
		{
			get
			{
				return this._strDefault;
			}
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x0008340A File Offset: 0x0008160A
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new EncoderReplacementFallbackBuffer(this);
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x00083412 File Offset: 0x00081612
		public override int MaxCharCount
		{
			get
			{
				return this._strDefault.Length;
			}
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00083420 File Offset: 0x00081620
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			EncoderReplacementFallback encoderReplacementFallback = value as EncoderReplacementFallback;
			return encoderReplacementFallback != null && this._strDefault == encoderReplacementFallback._strDefault;
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x0008344A File Offset: 0x0008164A
		public override int GetHashCode()
		{
			return this._strDefault.GetHashCode();
		}

		// Token: 0x04000763 RID: 1891
		internal static readonly EncoderReplacementFallback s_default = new EncoderReplacementFallback();

		// Token: 0x04000764 RID: 1892
		private readonly string _strDefault;
	}
}
