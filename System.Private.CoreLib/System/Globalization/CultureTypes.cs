using System;

namespace System.Globalization
{
	// Token: 0x020002DB RID: 731
	[Flags]
	public enum CultureTypes
	{
		// Token: 0x04000A00 RID: 2560
		NeutralCultures = 1,
		// Token: 0x04000A01 RID: 2561
		SpecificCultures = 2,
		// Token: 0x04000A02 RID: 2562
		InstalledWin32Cultures = 4,
		// Token: 0x04000A03 RID: 2563
		AllCultures = 7,
		// Token: 0x04000A04 RID: 2564
		UserCustomCulture = 8,
		// Token: 0x04000A05 RID: 2565
		ReplacementCultures = 16,
		// Token: 0x04000A06 RID: 2566
		[Obsolete("CultureTypes.WindowsOnlyCultures has been deprecated. Use other values in CultureTypes instead.")]
		WindowsOnlyCultures = 32,
		// Token: 0x04000A07 RID: 2567
		[Obsolete("CultureTypes.FrameworkCultures has been deprecated. Use other values in CultureTypes instead.")]
		FrameworkCultures = 64
	}
}
