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
		// Token: 0x060002A4 RID: 676 RVA: 0x0000DB34 File Offset: 0x0000BD34
		public RemoteVersionConfig()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000DB80 File Offset: 0x0000BD80
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

		// Token: 0x040001A6 RID: 422
		public string PackageVersion = "";

		// Token: 0x040001A7 RID: 423
		public string LauncherPackageVersion = "";

		// Token: 0x040001A8 RID: 424
		public string ChangeList = "";

		// Token: 0x040001A9 RID: 425
		public long? UpdateTime = new long?(0L);

		// Token: 0x040001AA RID: 426
		public Dictionary<string, VersionItem> ResVersions = new Dictionary<string, VersionItem>();
	}
}
