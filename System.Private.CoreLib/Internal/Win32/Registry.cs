using System;

namespace Internal.Win32
{
	// Token: 0x0200006A RID: 106
	internal static class Registry
	{
		// Token: 0x040001D8 RID: 472
		public static readonly RegistryKey CurrentUser = RegistryKey.OpenBaseKey((IntPtr)(-2147483647));

		// Token: 0x040001D9 RID: 473
		public static readonly RegistryKey LocalMachine = RegistryKey.OpenBaseKey((IntPtr)(-2147483646));
	}
}
