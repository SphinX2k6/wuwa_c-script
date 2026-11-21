using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200026F RID: 623
	public class IGrayBoxItem
	{
		// Token: 0x04000A45 RID: 2629
		public int Divisor;

		// Token: 0x04000A46 RID: 2630
		public int Left;

		// Token: 0x04000A47 RID: 2631
		public int Right;

		// Token: 0x04000A48 RID: 2632
		[Nullable(2)]
		public HashSet<int> PlayerIds;
	}
}
