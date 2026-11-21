using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000230 RID: 560
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ResVersionInfo
	{
		// Token: 0x06000E65 RID: 3685 RVA: 0x00057BE8 File Offset: 0x00055DE8
		public ResVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap)
		{
			this.PackageVersion = packageVersion;
			this.RemoteVersion = remoteVersion;
			this.RemoteManifestHashMap = remoteManifestHashMap;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00057C38 File Offset: 0x00055E38
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00057E18 File Offset: 0x00056018
		public bool NeedRevertVersion
		{
			get
			{
				return this.NeedRevert;
			}
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00057E20 File Offset: 0x00056020
		public string GetPackageVersion()
		{
			return this.PackageVersion;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00057E28 File Offset: 0x00056028
		public string LatestVersion
		{
			get
			{
				return this.RemoteVersion;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00057E30 File Offset: 0x00056030
		public string CurrentVersion
		{
			get
			{
				return this.LocalCurrentVersion;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00057E38 File Offset: 0x00056038
		public string RecordVersion
		{
			get
			{
				return this.VersionRecord;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00057E40 File Offset: 0x00056040
		public string RecordPackageVersion
		{
			get
			{
				return this.PackageVersionRecord;
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00057E48 File Offset: 0x00056048
		public void SetPackageVersionRecord(string version)
		{
			this.PackageVersionRecord = version;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00057E54 File Offset: 0x00056054
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00057E80 File Offset: 0x00056080
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

		// Token: 0x06000E70 RID: 3696 RVA: 0x00057EAB File Offset: 0x000560AB
		public string GetMountFileName()
		{
			return "Mount" + this.GetResType() + ".txt";
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00057EC2 File Offset: 0x000560C2
		public virtual string GetManifestFileName()
		{
			return "Manifest" + this.GetResType();
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00057ED4 File Offset: 0x000560D4
		protected virtual string GetVersionRecordKey()
		{
			return "Version_" + this.GetResType();
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00057EE6 File Offset: 0x000560E6
		public virtual bool HasContentOnRemote()
		{
			return this.PackageVersion != this.RemoteVersion || this.ManifestHash.Length > 0;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00057F0C File Offset: 0x0005610C
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

		// Token: 0x06000E75 RID: 3701 RVA: 0x00057FAA File Offset: 0x000561AA
		public virtual bool RecordUse(bool bUse)
		{
			return true;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00057FAD File Offset: 0x000561AD
		public int GetMountOrder()
		{
			return this.MountOrder;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00057FB8 File Offset: 0x000561B8
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

		// Token: 0x06000E78 RID: 3704 RVA: 0x00058038 File Offset: 0x00056238
		protected virtual bool ClearUseRecord()
		{
			return true;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0005803B File Offset: 0x0005623B
		public virtual bool IsLangRes()
		{
			return false;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0005803E File Offset: 0x0005623E
		public virtual void ForceUpdate()
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00058040 File Offset: 0x00056240
		public virtual bool SkipUpdate()
		{
			return false;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00058043 File Offset: 0x00056243
		public virtual bool NeedRecordMount()
		{
			return true;
		}

		// Token: 0x06000E7D RID: 3709
		public abstract string GetResType();

		// Token: 0x0400092F RID: 2351
		protected string VersionRecord = "";

		// Token: 0x04000930 RID: 2352
		protected string PackageVersionRecord = "";

		// Token: 0x04000931 RID: 2353
		protected string LocalCurrentVersion = "";

		// Token: 0x04000932 RID: 2354
		protected bool NeedRevert;

		// Token: 0x04000933 RID: 2355
		private int MountOrder = 4;

		// Token: 0x04000934 RID: 2356
		protected readonly string PackageVersion;

		// Token: 0x04000935 RID: 2357
		protected readonly string RemoteVersion;

		// Token: 0x04000936 RID: 2358
		protected readonly Dictionary<string, string> RemoteManifestHashMap;
	}
}
