using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher
{
	// Token: 0x02000065 RID: 101
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoteVersionConfig
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x0000DE54 File Offset: 0x0000C054
		public RemoteVersionConfig()
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
		public RemoteVersionConfig(Partial<RemoteVersionConfig> data)
		{
			this.PackageVersion = (data.GetValue<string>(([Nullable(1)] RemoteVersionConfig r) => r.PackageVersion) ?? "");
			this.LauncherPackageVersion = (data.GetValue<string>(([Nullable(1)] RemoteVersionConfig r) => r.LauncherPackageVersion) ?? "");
			this.ChangeList = (data.GetValue<string>(([Nullable(1)] RemoteVersionConfig r) => r.ChangeList) ?? "");
			this.UpdateTime = data.GetValue<long?>((RemoteVersionConfig r) => r.UpdateTime);
			this.ResVersions = new Dictionary<string, VersionItem>();
			Dictionary<string, VersionItem> value = data.GetValue<Dictionary<string, VersionItem>>(([Nullable(1)] RemoteVersionConfig d) => d.ResVersions);
			if (value != null)
			{
				foreach (KeyValuePair<string, VersionItem> keyValuePair in value)
				{
					this.ResVersions[keyValuePair.Key] = new VersionItem(new Partial<VersionItem>(keyValuePair.Value));
				}
			}
		}

		// Token: 0x040001B2 RID: 434
		public string PackageVersion = "";

		// Token: 0x040001B3 RID: 435
		public string LauncherPackageVersion = "";

		// Token: 0x040001B4 RID: 436
		public string ChangeList = "";

		// Token: 0x040001B5 RID: 437
		public long? UpdateTime = new long?(0L);

		// Token: 0x040001B6 RID: 438
		public Dictionary<string, VersionItem> ResVersions = new Dictionary<string, VersionItem>();
	}
}
