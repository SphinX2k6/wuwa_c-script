using System;
using System.Collections.Generic;

namespace System.Runtime.Loader
{
	// Token: 0x0200053C RID: 1340
	internal struct LibraryNameVariation
	{
		// Token: 0x06004967 RID: 18791 RVA: 0x000F31D9 File Offset: 0x000F13D9
		public LibraryNameVariation(string prefix, string suffix)
		{
			this.Prefix = prefix;
			this.Suffix = suffix;
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x000F31E9 File Offset: 0x000F13E9
		internal static IEnumerable<LibraryNameVariation> DetermineLibraryNameVariations(string libName, bool isRelativePath)
		{
			yield return new LibraryNameVariation(string.Empty, string.Empty);
			if (isRelativePath && !libName.EndsWith('.') && !libName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) && !libName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				yield return new LibraryNameVariation(string.Empty, ".dll");
			}
			yield break;
		}

		// Token: 0x040011AF RID: 4527
		public string Prefix;

		// Token: 0x040011B0 RID: 4528
		public string Suffix;
	}
}
