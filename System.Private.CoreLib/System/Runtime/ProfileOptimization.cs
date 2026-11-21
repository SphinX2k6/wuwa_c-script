using System;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace System.Runtime
{
	// Token: 0x02000506 RID: 1286
	public static class ProfileOptimization
	{
		// Token: 0x06004844 RID: 18500 RVA: 0x000F0ACE File Offset: 0x000EECCE
		[NullableContext(1)]
		public static void SetProfileRoot(string directoryPath)
		{
			AssemblyLoadContext.Default.SetProfileOptimizationRoot(directoryPath);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x000F0ADB File Offset: 0x000EECDB
		[NullableContext(2)]
		public static void StartProfile(string profile)
		{
			AssemblyLoadContext.Default.StartProfileOptimization(profile);
		}
	}
}
