using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x0200021C RID: 540
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x060029A3 RID: 10659 RVA: 0x0008219F File Offset: 0x0008039F
		public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
		{
			this._strDefault = fallback.DefaultString;
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000821C1 File Offset: 0x000803C1
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			if (this._fallbackCount >= 1)
			{
				DecoderFallbackBuffer.ThrowLastBytesRecursive(bytesUnknown);
			}
			if (this._strDefault.Length == 0)
			{
				return false;
			}
			this._fallbackCount = this._strDefault.Length;
			this._fallbackIndex = -1;
			return true;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000821FC File Offset: 0x000803FC
		public override char GetNextChar()
		{
			this._fallbackCount--;
			this._fallbackIndex++;
			if (this._fallbackCount < 0)
			{
				return '\0';
			}
			if (this._fallbackCount == 2147483647)
			{
				this._fallbackCount = -1;
				return '\0';
			}
			return this._strDefault[this._fallbackIndex];
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00082257 File Offset: 0x00080457
		public override bool MovePrevious()
		{
			if (this._fallbackCount >= -1 && this._fallbackIndex >= 0)
			{
				this._fallbackIndex--;
				this._fallbackCount++;
				return true;
			}
			return false;
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x0008228A File Offset: 0x0008048A
		public override int Remaining
		{
			get
			{
				if (this._fallbackCount >= 0)
				{
					return this._fallbackCount;
				}
				return 0;
			}
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x0008229D File Offset: 0x0008049D
		public override void Reset()
		{
			this._fallbackCount = -1;
			this._fallbackIndex = -1;
			this.byteStart = null;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000822B5 File Offset: 0x000804B5
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return this._strDefault.Length;
		}

		// Token: 0x04000747 RID: 1863
		private readonly string _strDefault;

		// Token: 0x04000748 RID: 1864
		private int _fallbackCount = -1;

		// Token: 0x04000749 RID: 1865
		private int _fallbackIndex = -1;
	}
}
