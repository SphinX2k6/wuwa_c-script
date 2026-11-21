using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001BC RID: 444
	[NullableContext(1)]
	[Nullable(0)]
	public static class StringNormalizationExtensions
	{
		// Token: 0x060021A1 RID: 8609 RVA: 0x00066833 File Offset: 0x00064A33
		public static bool IsNormalized(this string strInput)
		{
			return strInput.IsNormalized(NormalizationForm.FormC);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0006683C File Offset: 0x00064A3C
		public static bool IsNormalized(this string strInput, NormalizationForm normalizationForm)
		{
			ArgumentNullException.ThrowIfNull(strInput, "strInput");
			return strInput.IsNormalized(normalizationForm);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00066850 File Offset: 0x00064A50
		public static string Normalize(this string strInput)
		{
			return strInput.Normalize(NormalizationForm.FormC);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00066859 File Offset: 0x00064A59
		public static string Normalize(this string strInput, NormalizationForm normalizationForm)
		{
			ArgumentNullException.ThrowIfNull(strInput, "strInput");
			return strInput.Normalize(normalizationForm);
		}
	}
}
