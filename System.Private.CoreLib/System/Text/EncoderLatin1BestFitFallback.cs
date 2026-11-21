using System;

namespace System.Text
{
	// Token: 0x02000223 RID: 547
	internal sealed class EncoderLatin1BestFitFallback : EncoderFallback
	{
		// Token: 0x060029E8 RID: 10728 RVA: 0x000826B8 File Offset: 0x000808B8
		private EncoderLatin1BestFitFallback()
		{
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00082C28 File Offset: 0x00080E28
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new EncoderLatin1BestFitFallbackBuffer();
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x000070DD File Offset: 0x000052DD
		public override int MaxCharCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0400075A RID: 1882
		internal static readonly EncoderLatin1BestFitFallback SingletonInstance = new EncoderLatin1BestFitFallback();
	}
}
