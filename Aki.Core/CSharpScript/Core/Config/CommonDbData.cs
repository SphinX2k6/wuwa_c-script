using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000161 RID: 353
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonDbData
	{
		// Token: 0x06000C30 RID: 3120 RVA: 0x00039F3F File Offset: 0x0003813F
		public CommonDbData(int incrementId, string dbName, string command, string culture)
		{
			this.IncrementId = incrementId;
			this.DbName = dbName;
			this.Command = command;
			this.Culture = culture;
		}

		// Token: 0x04000719 RID: 1817
		public const int UNVALID_INCREMENT_ID = 0;

		// Token: 0x0400071A RID: 1818
		public string DbName;

		// Token: 0x0400071B RID: 1819
		public string Command;

		// Token: 0x0400071C RID: 1820
		public int IncrementId;

		// Token: 0x0400071D RID: 1821
		public string Culture;
	}
}
