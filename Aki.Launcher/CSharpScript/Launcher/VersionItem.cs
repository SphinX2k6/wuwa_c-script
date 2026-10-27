using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher
{
	// Token: 0x02000062 RID: 98
	[NullableContext(1)]
	[Nullable(0)]
	public class VersionItem
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0000D649 File Offset: 0x0000B849
		public VersionItem()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000D674 File Offset: 0x0000B874
		public VersionItem(Partial<VersionItem> data)
		{
			this.Name = (data.GetValue<string>(([Nullable(1)] VersionItem v) => v.Name) ?? "");
			this.Version = (data.GetValue<string>(([Nullable(1)] VersionItem v) => v.Version) ?? "");
			this.IndexSha1 = new Dictionary<string, string>();
			Dictionary<string, string> value = data.GetValue<Dictionary<string, string>>(([Nullable(1)] VersionItem v) => v.IndexSha1);
			if (value != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in value)
				{
					this.IndexSha1[keyValuePair.Key] = keyValuePair.Value;
				}
			}
		}

		// Token: 0x04000197 RID: 407
		public string Name = "";

		// Token: 0x04000198 RID: 408
		public string Version = "";

		// Token: 0x04000199 RID: 409
		public Dictionary<string, string> IndexSha1 = new Dictionary<string, string>();
	}
}
