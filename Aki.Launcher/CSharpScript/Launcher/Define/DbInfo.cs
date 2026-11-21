using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200023E RID: 574
	[NullableContext(1)]
	[Nullable(0)]
	public class DbInfo
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x000585F8 File Offset: 0x000567F8
		public string ConfigDbPath { get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00058600 File Offset: 0x00056800
		public string TextDb { get; }

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00058608 File Offset: 0x00056808
		public DbInfo(string configDbPath, string textDb)
		{
			this.ConfigDbPath = configDbPath;
			this.TextDb = textDb;
		}
	}
}
