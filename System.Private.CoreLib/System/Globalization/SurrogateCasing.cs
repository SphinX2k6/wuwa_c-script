using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x0200030F RID: 783
	internal static class SurrogateCasing
	{
		// Token: 0x06003915 RID: 14613 RVA: 0x000BCB36 File Offset: 0x000BAD36
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ToUpper(char h, char l, out char hr, out char lr)
		{
			UnicodeUtility.GetUtf16SurrogatesFromSupplementaryPlaneScalar(CharUnicodeInfo.ToUpper(UnicodeUtility.GetScalarFromUtf16SurrogatePair((uint)h, (uint)l)), out hr, out lr);
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x000BCB4B File Offset: 0x000BAD4B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ToLower(char h, char l, out char hr, out char lr)
		{
			UnicodeUtility.GetUtf16SurrogatesFromSupplementaryPlaneScalar(CharUnicodeInfo.ToLower(UnicodeUtility.GetScalarFromUtf16SurrogatePair((uint)h, (uint)l)), out hr, out lr);
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x000BCB60 File Offset: 0x000BAD60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool Equal(char h1, char l1, char h2, char l2)
		{
			char c;
			char c2;
			SurrogateCasing.ToUpper(h1, l1, out c, out c2);
			char c3;
			char c4;
			SurrogateCasing.ToUpper(h2, l2, out c3, out c4);
			return c == c3 && c2 == c4;
		}
	}
}
