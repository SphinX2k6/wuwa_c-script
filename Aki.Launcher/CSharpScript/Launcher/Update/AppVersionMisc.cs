using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000086 RID: 134
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class AppVersionMisc
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x0002E3DC File Offset: 0x0002C5DC
		public void Init(UObject worldContext)
		{
			this.PackageVersion = UKuroLauncherLibrary.GetAppVersion();
			this.SetVersions(LauncherStorageLib.Instance.GetDeviceSavedString(this.GetUpdateVersionKey(), this.PackageVersion), LauncherStorageLib.Instance.GetDeviceSavedString(this.GetSaveUpdateVersionKey(), this.PackageVersion), this.GetRemoteVersion(), this.GetRemoteSha1Map());
			List<string> list = new List<string>();
			foreach (string text in this.LocalSaveResourceVersions)
			{
				if (!(text == this.PackageVersion) || this.BasePackageNeedDownloadRes)
				{
					list.Add(text);
				}
			}
			if (this.LocalSaveResourceVersion != this.LatestVersion && this.LatestVersion != this.PackageVersion)
			{
				list.Add(this.LatestVersion);
			}
			this.UpdateVersionNodes = list;
			this.UpdatePreVersionNodes = new List<string>();
			if (this.LatestVersion == this.PackageVersion && this.BasePackageNeedDownloadRes)
			{
				this.UpdatePreVersionNodes.Add(this.PackageVersion);
			}
			if (this.LatestVersion != this.PackageVersion)
			{
				this.UpdatePreVersionNodes.Add(this.PackageVersion);
			}
			for (int i = 0; i < this.UpdateVersionNodes.Count - 1; i++)
			{
				string item = this.UpdateVersionNodes[i];
				this.UpdatePreVersionNodes.Add(item);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0002E55C File Offset: 0x0002C75C
		protected unsafe void SetVersions(string resVersion, string resSaveVersion, string latestVersion, Dictionary<string, string> sha1Map)
		{
			List<string> list = new List<string>(resVersion.Split(',', StringSplitOptions.None));
			string text = list[list.Count - 1];
			List<string> list2 = new List<string>(resSaveVersion.Split(',', StringSplitOptions.None));
			string text2 = list2[list2.Count - 1];
			if (string.IsNullOrEmpty(latestVersion))
			{
				LauncherLog.Instance.Warn("远程版本号为空，使用包体版本号做为线上最新版本号", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.LocalResourceVersions = list;
				this.LocalResourceVersion = text;
				this.LocalSaveResourceVersions = list2;
				this.LocalSaveResourceVersion = text2;
				this.LatestVersion = this.PackageVersion;
				this.HasUpdatedResource = true;
				return;
			}
			this.LatestVersion = latestVersion;
			ValueTuple<bool, VersionInfo> valueTuple = VersionInfo.TryParse(latestVersion);
			bool item = valueTuple.Item1;
			VersionInfo item2 = valueTuple.Item2;
			ValueTuple<bool, VersionInfo> valueTuple2 = VersionInfo.TryParse(text);
			bool item3 = valueTuple2.Item1;
			VersionInfo item4 = valueTuple2.Item2;
			ValueTuple<bool, VersionInfo> valueTuple3 = VersionInfo.TryParse(text2);
			bool item5 = valueTuple3.Item1;
			VersionInfo item6 = valueTuple3.Item2;
			if (!item || item2 == null || !item3 || item4 == null || !item5 || item6 == null)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "转版本号失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", this.GetResType());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("latestVer", latestVersion);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("localVer", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("localSaveVer", text2);
				instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				throw new Exception("转版本号失败");
			}
			bool flag = false;
			bool flag2 = false;
			this.NeedRevertVersion = false;
			if (!VersionInfo.PackageEquals(item2, item4))
			{
				text = this.PackageVersion;
				list = new List<string>
				{
					text
				};
				flag = true;
			}
			else if (item2.Patch < item4.Patch)
			{
				this.NeedRevertVersion = true;
				for (int i = item2.Patch + 1; i <= item4.Patch; i++)
				{
					HashSet<string> revertVersions = this.RevertVersions;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
					defaultInterpolatedStringHandler.AppendFormatted<int>(item2.Major);
					defaultInterpolatedStringHandler.AppendLiteral(".");
					defaultInterpolatedStringHandler.AppendFormatted<int>(item2.Minor);
					defaultInterpolatedStringHandler.AppendLiteral(".");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i);
					revertVersions.Add(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			if (!VersionInfo.PackageEquals(item2, item4))
			{
				text2 = this.PackageVersion;
				list2 = new List<string>
				{
					text2
				};
				flag2 = true;
			}
			else if (item2.Patch < item6.Patch)
			{
				this.NeedRevertVersion = true;
				for (int j = item2.Patch + 1; j <= item6.Patch; j++)
				{
					HashSet<string> revertVersions2 = this.RevertVersions;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
					defaultInterpolatedStringHandler.AppendFormatted<int>(item2.Major);
					defaultInterpolatedStringHandler.AppendLiteral(".");
					defaultInterpolatedStringHandler.AppendFormatted<int>(item2.Minor);
					defaultInterpolatedStringHandler.AppendLiteral(".");
					defaultInterpolatedStringHandler.AppendFormatted<int>(j);
					revertVersions2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			if (this.NeedRevertVersion)
			{
				this.LocalResourceVersions = new List<string>();
				foreach (string item7 in list)
				{
					if (!this.RevertVersions.Contains(item7))
					{
						this.LocalResourceVersions.Add(item7);
					}
				}
				this.LocalResourceVersion = this.LocalResourceVersions[this.LocalResourceVersions.Count - 1];
				this.LocalSaveResourceVersions = new List<string>();
				foreach (string item8 in list2)
				{
					if (!this.RevertVersions.Contains(item8))
					{
						this.LocalSaveResourceVersions.Add(item8);
					}
				}
				this.LocalSaveResourceVersion = this.LocalSaveResourceVersions[this.LocalSaveResourceVersions.Count - 1];
				if (this.LocalResourceVersion == latestVersion)
				{
					flag = true;
				}
				if (this.LocalSaveResourceVersion == latestVersion)
				{
					flag2 = true;
				}
			}
			else
			{
				this.LocalResourceVersions = list;
				this.LocalResourceVersion = text;
				this.LocalSaveResourceVersions = list2;
				this.LocalSaveResourceVersion = text2;
			}
			if (flag)
			{
				this.UpdateVersion(null, true);
			}
			if (flag2)
			{
				this.UpdateSavedVersion(null, true);
			}
			this.BasePackageNeedDownloadRes = sha1Map.ContainsKey(this.PackageVersion);
			this.IndexSha1s = new List<string>();
			foreach (string text3 in this.LocalSaveResourceVersions)
			{
				if (!(text3 == this.PackageVersion) || this.BasePackageNeedDownloadRes)
				{
					this.IndexSha1s.Add(sha1Map[text3]);
				}
			}
			if (this.LocalSaveResourceVersion != this.LatestVersion)
			{
				this.IndexSha1s.Add(sha1Map[this.LatestVersion]);
			}
			this.HasUpdatedResource = ((this.LatestVersion == this.PackageVersion) ? (!this.BasePackageNeedDownloadRes) : (this.LocalResourceVersion == this.LatestVersion));
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0002EAA4 File Offset: 0x0002CCA4
		public bool NeedRevert()
		{
			return this.NeedRevertVersion;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0002EAAC File Offset: 0x0002CCAC
		public HashSet<string> GetRevertVersions()
		{
			return this.RevertVersions;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		public bool HasNewResourceVersionBaseOnPackage()
		{
			return this.PackageVersion != this.LatestVersion;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0002EAC7 File Offset: 0x0002CCC7
		public bool IsBasePackageSplited()
		{
			return this.BasePackageNeedDownloadRes;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0002EACF File Offset: 0x0002CCCF
		public bool IsFirstUpdateResources()
		{
			if (!(this.LatestVersion == this.PackageVersion))
			{
				return this.LatestVersion != this.LocalSaveResourceVersion;
			}
			return this.BasePackageNeedDownloadRes;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		public virtual bool NeedCheckAppRestart()
		{
			return true;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0002EAFF File Offset: 0x0002CCFF
		public bool HasUpdated()
		{
			return this.HasUpdatedResource;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0002EB07 File Offset: 0x0002CD07
		public string GetLatestVersion()
		{
			return this.LatestVersion;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0002EB10 File Offset: 0x0002CD10
		public void UpdateVersion(UObject worldContext, bool bNewPackage = false)
		{
			if (bNewPackage)
			{
				string value = string.Join(",", this.LocalResourceVersions);
				LauncherStorageLib.Instance.SetDeviceSavedString(this.GetUpdateVersionKey(), value);
				if (UKuroLauncherLibrary.NeedRestartApp() > 0)
				{
					UKuroLauncherLibrary.SetRestartApp(1);
				}
				return;
			}
			this.LocalResourceVersion = this.LatestVersion;
			if (this.LocalResourceVersions.Count <= 0 || this.LocalResourceVersions[this.LocalResourceVersions.Count - 1] != this.LatestVersion)
			{
				this.LocalResourceVersions.Add(this.LatestVersion);
			}
			string value2 = string.Join(",", this.LocalResourceVersions);
			LauncherStorageLib.Instance.SetDeviceSavedString(this.GetUpdateVersionKey(), value2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0002EBC8 File Offset: 0x0002CDC8
		public unsafe void UpdateSavedVersion(UObject worldContext, bool bNewPackage = false)
		{
			if (bNewPackage)
			{
				string text = string.Join(",", this.LocalSaveResourceVersions);
				LauncherLog instance = LauncherLog.Instance;
				string message = "UpdateSavedVersion";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", this.GetResType());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Versions", text);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				LauncherStorageLib.Instance.SetDeviceSavedString(this.GetSaveUpdateVersionKey(), text);
				if (UKuroLauncherLibrary.NeedRestartApp() > 0)
				{
					UKuroLauncherLibrary.SetRestartApp(1);
				}
				return;
			}
			this.LocalSaveResourceVersion = this.LatestVersion;
			if (this.LocalSaveResourceVersions.Count <= 0 || this.LocalSaveResourceVersions[this.LocalSaveResourceVersions.Count - 1] != this.LatestVersion)
			{
				this.LocalSaveResourceVersions.Add(this.LatestVersion);
			}
			string text2 = string.Join(",", this.LocalSaveResourceVersions);
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "UpdateSavedVersion";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Type", this.GetResType());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Versions", text2);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			LauncherStorageLib.Instance.SetDeviceSavedString(this.GetSaveUpdateVersionKey(), text2);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0002ED28 File Offset: 0x0002CF28
		public virtual void ClearAllPatchVersion(UObject worldContext)
		{
			LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetUpdateVersionKey());
			LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetSaveUpdateVersionKey());
			if (this.GetResType() == EResType.Launcher.ToEnumString())
			{
				LauncherStorageLib.Instance.DeleteDeviceSavedString("__kr_blvr__");
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		public List<PatchFileInfo> ReadPatchFileInfoList()
		{
			AppPathMisc pathMisc = new AppPathMisc();
			return ResourceUpdate.ReadPatchInfoList(this.GetIndexSavePaths(pathMisc), this.UpdatePreVersionNodes, this, pathMisc).Item2;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002EDA8 File Offset: 0x0002CFA8
		public string GetPackageVersion()
		{
			return this.PackageVersion;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		public List<string> GetIndexSha1s()
		{
			return this.IndexSha1s;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		public List<string> GetIndexSavePaths(AppPathMisc pathMisc)
		{
			List<string> list = new List<string>();
			foreach (string value in this.GetIndexFileNames())
			{
				List<string> list2 = list;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 4);
				defaultInterpolatedStringHandler.AppendFormatted(pathMisc.GetPatchSaveDir());
				defaultInterpolatedStringHandler.AppendFormatted(this.GetPackageVersion());
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(this.GetResType());
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return list;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0002EE68 File Offset: 0x0002D068
		public List<string> GetUpdatePreVersions()
		{
			return this.UpdatePreVersionNodes;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0002EE70 File Offset: 0x0002D070
		public List<string> GetIndexFileNames()
		{
			List<string> list = new List<string>();
			foreach (string str in this.UpdateVersionNodes)
			{
				list.Add(this.GetIndexFilePrefix() + str + ".txt");
			}
			return list;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		public string GetMountFilePath()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
			defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GameSavedDir());
			defaultInterpolatedStringHandler.AppendLiteral("Resources/");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetPackageVersion());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetMountFileName());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060004D7 RID: 1239
		protected abstract string GetMountFileName();

		// Token: 0x060004D8 RID: 1240
		public abstract string GetResType();

		// Token: 0x060004D9 RID: 1241
		protected abstract string GetUpdateVersionKey();

		// Token: 0x060004DA RID: 1242
		protected abstract string GetSaveUpdateVersionKey();

		// Token: 0x060004DB RID: 1243
		protected abstract string GetIndexFilePrefix();

		// Token: 0x060004DC RID: 1244
		protected abstract string GetRemoteVersion();

		// Token: 0x060004DD RID: 1245
		protected abstract Dictionary<string, string> GetRemoteSha1Map();

		// Token: 0x040002D1 RID: 721
		protected string PackageVersion = "";

		// Token: 0x040002D2 RID: 722
		protected string LocalResourceVersion = "";

		// Token: 0x040002D3 RID: 723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<string> LocalResourceVersions;

		// Token: 0x040002D4 RID: 724
		protected string LocalSaveResourceVersion = "";

		// Token: 0x040002D5 RID: 725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<string> LocalSaveResourceVersions;

		// Token: 0x040002D6 RID: 726
		protected string LatestVersion = "";

		// Token: 0x040002D7 RID: 727
		protected bool HasUpdatedResource;

		// Token: 0x040002D8 RID: 728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<string> IndexSha1s;

		// Token: 0x040002D9 RID: 729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<string> UpdateVersionNodes;

		// Token: 0x040002DA RID: 730
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<string> UpdatePreVersionNodes;

		// Token: 0x040002DB RID: 731
		private bool BasePackageNeedDownloadRes;

		// Token: 0x040002DC RID: 732
		private bool NeedRevertVersion;

		// Token: 0x040002DD RID: 733
		private readonly HashSet<string> RevertVersions = new HashSet<string>();
	}
}
