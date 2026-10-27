using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher
{
	// Token: 0x02000063 RID: 99
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoteConfig
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x0000D798 File Offset: 0x0000B998
		public RemoteConfig()
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
		public RemoteConfig(Partial<RemoteConfig> data)
		{
			this.PackageVersion = (data.GetValue<string>(([Nullable(1)] RemoteConfig r) => r.PackageVersion) ?? "");
			this.LauncherPackageVersion = (data.GetValue<string>(([Nullable(1)] RemoteConfig r) => r.LauncherPackageVersion) ?? "");
			this.LauncherVersion = (data.GetValue<string>(([Nullable(1)] RemoteConfig r) => r.LauncherVersion) ?? "");
			this.ResourceVersion = (data.GetValue<string>(([Nullable(1)] RemoteConfig r) => r.ResourceVersion) ?? "");
			this.ChangeList = (data.GetValue<string>(([Nullable(1)] RemoteConfig r) => r.ChangeList) ?? "");
			this.UpdateTime = data.GetValue<long?>((RemoteConfig r) => r.UpdateTime);
			this.LauncherIndexSha1 = new Dictionary<string, string>();
			Dictionary<string, string> value = data.GetValue<Dictionary<string, string>>(([Nullable(1)] RemoteConfig d) => d.LauncherIndexSha1);
			if (value != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in value)
				{
					this.LauncherIndexSha1[keyValuePair.Key] = keyValuePair.Value;
				}
			}
			this.ResourceIndexSha1 = new Dictionary<string, string>();
			Dictionary<string, string> value2 = data.GetValue<Dictionary<string, string>>(([Nullable(1)] RemoteConfig d) => d.ResourceIndexSha1);
			if (value2 != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair2 in value2)
				{
					this.ResourceIndexSha1[keyValuePair2.Key] = keyValuePair2.Value;
				}
			}
			this.Versions = new List<VersionItem>();
			List<VersionItem> value3 = data.GetValue<List<VersionItem>>(([Nullable(1)] RemoteConfig d) => d.Versions);
			if (value3 != null)
			{
				foreach (VersionItem value4 in value3)
				{
					this.Versions.Add(new VersionItem(new Partial<VersionItem>(value4)));
				}
			}
		}

		// Token: 0x0400019A RID: 410
		public string PackageVersion = "";

		// Token: 0x0400019B RID: 411
		public string LauncherPackageVersion = "";

		// Token: 0x0400019C RID: 412
		public string LauncherVersion = "";

		// Token: 0x0400019D RID: 413
		public string ResourceVersion = "";

		// Token: 0x0400019E RID: 414
		public string ChangeList = "";

		// Token: 0x0400019F RID: 415
		public long? UpdateTime = new long?(0L);

		// Token: 0x040001A0 RID: 416
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> LauncherIndexSha1;

		// Token: 0x040001A1 RID: 417
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> ResourceIndexSha1;

		// Token: 0x040001A2 RID: 418
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<VersionItem> Versions;
	}
}
