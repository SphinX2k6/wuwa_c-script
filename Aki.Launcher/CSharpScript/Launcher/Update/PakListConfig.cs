using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000091 RID: 145
	[NullableContext(1)]
	[Nullable(0)]
	public class PakListConfig
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x000302F1 File Offset: 0x0002E4F1
		public PakListConfig()
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0003031C File Offset: 0x0002E51C
		public PakListConfig(Partial<PakListConfig> data)
		{
			this.Hash = (data.GetValue<string>(([Nullable(1)] PakListConfig d) => d.Hash) ?? "");
			this.Random = (data.GetValue<string>(([Nullable(1)] PakListConfig d) => d.Random) ?? "");
			this.Key = (data.GetValue<string>(([Nullable(1)] PakListConfig d) => d.Key) ?? "");
			this.UpdateTime = data.GetValue<int>((PakListConfig d) => d.UpdateTime);
		}

		// Token: 0x0400031D RID: 797
		public string Hash = "";

		// Token: 0x0400031E RID: 798
		public string Random = "";

		// Token: 0x0400031F RID: 799
		public string Key = "";

		// Token: 0x04000320 RID: 800
		public int UpdateTime;
	}
}
