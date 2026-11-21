using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000166 RID: 358
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonDbData
	{
		// Token: 0x06000C8F RID: 3215 RVA: 0x0003AC83 File Offset: 0x00038E83
		public CommonDbData(int incrementId, string dbName, string command, string culture)
		{
			this.IncrementId = incrementId;
			this.DbName = dbName;
			this.Command = command;
			this.Culture = culture;
		}

		// Token: 0x04000728 RID: 1832
		public const int UNVALID_INCREMENT_ID = 0;

		// Token: 0x04000729 RID: 1833
		public string DbName;

		// Token: 0x0400072A RID: 1834
		public string Command;

		// Token: 0x0400072B RID: 1835
		public int IncrementId;

		// Token: 0x0400072C RID: 1836
		public string Culture;
	}
}
