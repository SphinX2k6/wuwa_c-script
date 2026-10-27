using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022B RID: 555
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ResVersionInfo
	{
		// Token: 0x06000E24 RID: 3620 RVA: 0x000550E0 File Offset: 0x000532E0
		public ResVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap)
		{
			this.PackageVersion = packageVersion;
			this.RemoteVersion = remoteVersion;
			this.RemoteManifestHashMap = remoteManifestHashMap;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00055130 File Offset: 0x00053330
		public unsafe virtual void Init()
		{
			this.VersionRecord = LauncherStorageLib.Instance.GetDeviceSavedString(this.GetVersionRecordKey(), "");
			VersionInfo item = VersionInfo.TryParse(this.PackageVersion).Item2;
			VersionInfo item2 = VersionInfo.TryParse((this.VersionRecord != null && this.VersionRecord != "") ? this.VersionRecord : this.PackageVersion).Item2;
			VersionInfo item3 = VersionInfo.TryParse(this.RemoteVersion).Item2;
			this.MountOrder = item3.Patch + 4;
			this.NeedRevert = !VersionInfo.LessThanOrEqual(item2, item3);
			this.PackageVersionRecord = item2.ToString(2) + ".0";
			this.LocalCurrentVersion = (VersionInfo.PackageEquals(item, item2) ? ((this.VersionRecord != null && this.VersionRecord != "") ? this.VersionRecord : this.PackageVersion) : this.PackageVersion);
			LauncherLog instance = LauncherLog.Instance;
			string message = "inited res version.";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("record", this.VersionRecord);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("remote", this.RemoteVersion);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("recordPackage", this.PackageVersionRecord);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("package", this.PackageVersion);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("localCurPackage", this.LocalCurrentVersion);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("needRevert", this.NeedRevert);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("res", this.GetResType());
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00055310 File Offset: 0x00053510
		public bool NeedRevertVersion
		{
			get
			{
				return this.NeedRevert;
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00055318 File Offset: 0x00053518
		public string GetPackageVersion()
		{
			return this.PackageVersion;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00055320 File Offset: 0x00053520
		public string LatestVersion
		{
			get
			{
				return this.RemoteVersion;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00055328 File Offset: 0x00053528
		public string CurrentVersion
		{
			get
			{
				return this.LocalCurrentVersion;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00055330 File Offset: 0x00053530
		public string RecordVersion
		{
			get
			{
				return this.VersionRecord;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00055338 File Offset: 0x00053538
		public string RecordPackageVersion
		{
			get
			{
				return this.PackageVersionRecord;
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00055340 File Offset: 0x00053540
		public void SetPackageVersionRecord(string version)
		{
			this.PackageVersionRecord = version;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0005534C File Offset: 0x0005354C
		public virtual string ManifestHash
		{
			get
			{
				string text;
				this.RemoteManifestHashMap.TryGetValue(this.RemoteVersion, out text);
				if (text == null)
				{
					return "";
				}
				return text;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00055378 File Offset: 0x00053578
		public string RevertManifestHash
		{
			get
			{
				string text;
				this.RemoteManifestHashMap.TryGetValue(this.RecordVersion, out text);
				if (text == null)
				{
					return "";
				}
				return text;
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000553A3 File Offset: 0x000535A3
		public string GetMountFileName()
		{
			return "Mount" + this.GetResType() + ".txt";
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000553BA File Offset: 0x000535BA
		public virtual string GetManifestFileName()
		{
			return "Manifest" + this.GetResType();
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000553CC File Offset: 0x000535CC
		protected virtual string GetVersionRecordKey()
		{
			return "Version_" + this.GetResType();
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000553DE File Offset: 0x000535DE
		public virtual bool HasContentOnRemote()
		{
			return this.PackageVersion != this.RemoteVersion || this.ManifestHash.Length > 0;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00055404 File Offset: 0x00053604
		public unsafe virtual bool UpdateVersionRecord()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "update res version.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("res", this.GetResType());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ver", this.RemoteVersion);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!LauncherStorageLib.Instance.SetDeviceSavedString(this.GetVersionRecordKey(), this.RemoteVersion))
			{
				return false;
			}
			this.VersionRecord = this.RemoteVersion;
			if (!this.RecordUse(true))
			{
				return false;
			}
			this.Init();
			return true;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000554A2 File Offset: 0x000536A2
		public virtual bool RecordUse(bool bUse)
		{
			return true;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000554A5 File Offset: 0x000536A5
		public int GetMountOrder()
		{
			return this.MountOrder;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000554B0 File Offset: 0x000536B0
		public virtual bool ClearVersionRecord()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "clear res version.";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", this.GetResType());
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (!LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetVersionRecordKey()))
			{
				return false;
			}
			if (this.GetResType() == EResType.Launcher.ToEnumString() && !LauncherStorageLib.Instance.DeleteDeviceSavedString("__kr_blvr__"))
			{
				return false;
			}
			if (!this.ClearUseRecord())
			{
				return false;
			}
			this.Init();
			return true;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00055530 File Offset: 0x00053730
		protected virtual bool ClearUseRecord()
		{
			return true;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00055533 File Offset: 0x00053733
		public virtual bool IsLangRes()
		{
			return false;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00055536 File Offset: 0x00053736
		public virtual void ForceUpdate()
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00055538 File Offset: 0x00053738
		public virtual bool SkipUpdate()
		{
			return false;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0005553B File Offset: 0x0005373B
		public virtual bool NeedRecordMount()
		{
			return true;
		}

		// Token: 0x06000E3C RID: 3644
		public abstract string GetResType();

		// Token: 0x040008ED RID: 2285
		protected string VersionRecord = "";

		// Token: 0x040008EE RID: 2286
		protected string PackageVersionRecord = "";

		// Token: 0x040008EF RID: 2287
		protected string LocalCurrentVersion = "";

		// Token: 0x040008F0 RID: 2288
		protected bool NeedRevert;

		// Token: 0x040008F1 RID: 2289
		private int MountOrder = 4;

		// Token: 0x040008F2 RID: 2290
		protected readonly string PackageVersion;

		// Token: 0x040008F3 RID: 2291
		protected readonly string RemoteVersion;

		// Token: 0x040008F4 RID: 2292
		protected readonly Dictionary<string, string> RemoteManifestHashMap;
	}
}
