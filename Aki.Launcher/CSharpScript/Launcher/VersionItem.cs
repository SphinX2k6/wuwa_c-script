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
		// Token: 0x060002A0 RID: 672 RVA: 0x0000D969 File Offset: 0x0000BB69
		public VersionItem()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000D994 File Offset: 0x0000BB94
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

		// Token: 0x040001A3 RID: 419
		public string Name = "";

		// Token: 0x040001A4 RID: 420
		public string Version = "";

		// Token: 0x040001A5 RID: 421
		public Dictionary<string, string> IndexSha1 = new Dictionary<string, string>();
	}
}
