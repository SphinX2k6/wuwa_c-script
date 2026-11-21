using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000094 RID: 148
	[NullableContext(1)]
	[Nullable(0)]
	public class PakListConfig
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x00031859 File Offset: 0x0002FA59
		public PakListConfig()
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00031884 File Offset: 0x0002FA84
		public PakListConfig(Partial<PakListConfig> data)
		{
			this.Hash = (data.GetValue<string>(([Nullable(1)] PakListConfig d) => d.Hash) ?? "");
			this.Random = (data.GetValue<string>(([Nullable(1)] PakListConfig d) => d.Random) ?? "");
			this.Key = (data.GetValue<string>(([Nullable(1)] PakListConfig d) => d.Key) ?? "");
			this.UpdateTime = data.GetValue<int>((PakListConfig d) => d.UpdateTime);
		}

		// Token: 0x0400034B RID: 843
		public string Hash = "";

		// Token: 0x0400034C RID: 844
		public string Random = "";

		// Token: 0x0400034D RID: 845
		public string Key = "";

		// Token: 0x0400034E RID: 846
		public int UpdateTime;
	}
}
