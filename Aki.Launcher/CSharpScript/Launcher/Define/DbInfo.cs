using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000239 RID: 569
	[NullableContext(1)]
	[Nullable(0)]
	public class DbInfo
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00055AF0 File Offset: 0x00053CF0
		public string ConfigDbPath { get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00055AF8 File Offset: 0x00053CF8
		public string TextDb { get; }

		// Token: 0x06000E6F RID: 3695 RVA: 0x00055B00 File Offset: 0x00053D00
		public DbInfo(string configDbPath, string textDb)
		{
			this.ConfigDbPath = configDbPath;
			this.TextDb = textDb;
		}
	}
}
