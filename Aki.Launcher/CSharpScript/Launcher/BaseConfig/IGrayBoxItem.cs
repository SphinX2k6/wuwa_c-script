using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000268 RID: 616
	public class IGrayBoxItem
	{
		// Token: 0x040009F7 RID: 2551
		public int Divisor;

		// Token: 0x040009F8 RID: 2552
		public int Left;

		// Token: 0x040009F9 RID: 2553
		public int Right;

		// Token: 0x040009FA RID: 2554
		[Nullable(2)]
		public HashSet<int> PlayerIds;
	}
}
