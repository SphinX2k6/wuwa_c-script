using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x0200021B RID: 539
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DecoderReplacementFallback : DecoderFallback
	{
		// Token: 0x0600299B RID: 10651 RVA: 0x000820B4 File Offset: 0x000802B4
		public DecoderReplacementFallback() : this("?")
		{
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000820C4 File Offset: 0x000802C4
		public DecoderReplacementFallback(string replacement)
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x0008213E File Offset: 0x0008033E
		public string DefaultString
		{
			get
			{
				return this._strDefault;
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00082146 File Offset: 0x00080346
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return new DecoderReplacementFallbackBuffer(this);
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x0008214E File Offset: 0x0008034E
		public override int MaxCharCount
		{
			get
			{
				return this._strDefault.Length;
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0008215C File Offset: 0x0008035C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			DecoderReplacementFallback decoderReplacementFallback = value as DecoderReplacementFallback;
			return decoderReplacementFallback != null && this._strDefault == decoderReplacementFallback._strDefault;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00082186 File Offset: 0x00080386
		public override int GetHashCode()
		{
			return this._strDefault.GetHashCode();
		}

		// Token: 0x04000745 RID: 1861
		internal static readonly DecoderReplacementFallback s_default = new DecoderReplacementFallback();

		// Token: 0x04000746 RID: 1862
		private readonly string _strDefault;
	}
}
