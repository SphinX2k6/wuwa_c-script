using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	public class AppPathMisc
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x0002F488 File Offset: 0x0002D688
		public string GetPatchSaveDir()
		{
			if (string.IsNullOrEmpty(this.SaveDir))
			{
				this.SaveDir = UKuroLauncherLibrary.GameSavedDir() + "Resources/";
			}
			return this.SaveDir;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0002F4B2 File Offset: 0x0002D6B2
		public string GetPlatform()
		{
			if (string.IsNullOrEmpty(this.Platform))
			{
				this.Platform = KuroApplication.IniPlatformNameIncludeEditor();
			}
			return this.Platform;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0002F4D2 File Offset: 0x0002D6D2
		public string GetInternalUseType()
		{
			if (string.IsNullOrEmpty(this.InternalUse))
			{
				this.InternalUse = UKuroLauncherLibrary.GetAppInternalUseType();
			}
			return this.InternalUse;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0002F4F4 File Offset: 0x0002D6F4
		public string GetManifestRoute(string resUri, string latestVersion, string manifestName)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 4);
			defaultInterpolatedStringHandler.AppendFormatted(resUri);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetPlatform());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(latestVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(manifestName);
			defaultInterpolatedStringHandler.AppendLiteral(".txt");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0002F568 File Offset: 0x0002D768
		public string GetResFileRoute(string resUri, string latestVersion, string fileName)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
			defaultInterpolatedStringHandler.AppendFormatted(resUri);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetPlatform());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(latestVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(fileName);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0002F5D0 File Offset: 0x0002D7D0
		public string GetManifestPath(string packageVersion, string latestVersion, string manifestName)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 4);
			defaultInterpolatedStringHandler.AppendFormatted(this.GetPatchSaveDir());
			defaultInterpolatedStringHandler.AppendFormatted(packageVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/ResManifest/");
			defaultInterpolatedStringHandler.AppendFormatted(manifestName);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(latestVersion);
			defaultInterpolatedStringHandler.AppendLiteral(".txt");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0002F637 File Offset: 0x0002D837
		public string GetResFilePath(string packageVersion, string patchVersion, string resType, string fileName)
		{
			return this.GetResFileDir(packageVersion, patchVersion, resType) + fileName;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0002F64C File Offset: 0x0002D84C
		public string GetResFileDir(string packageVersion, string patchVersion, string resType)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
			defaultInterpolatedStringHandler.AppendFormatted(this.GetPatchSaveDir());
			defaultInterpolatedStringHandler.AppendFormatted(packageVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(resType);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(patchVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!CSharpScript.Launcher.Platform.Platform.Instance.IsPs5Platform())
			{
				return text;
			}
			return text.ToLower();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0002F6C7 File Offset: 0x0002D8C7
		public string GetMountManifestPath(string packageVersion, string mountFileName)
		{
			return this.GetPatchSaveDir() + packageVersion + "/Mount/" + mountFileName;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002F6DC File Offset: 0x0002D8DC
		public string GetDiffFilePath(string packageVersion, string latestVersion, string resType, string fileName)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 5);
			defaultInterpolatedStringHandler.AppendFormatted(this.GetPatchSaveDir());
			defaultInterpolatedStringHandler.AppendFormatted(packageVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/Diff/");
			defaultInterpolatedStringHandler.AppendFormatted(resType);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(latestVersion);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(fileName);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002F74C File Offset: 0x0002D94C
		[NullableContext(0)]
		public ValueTuple<long, long> GetTotalAndFreeSpace([Nullable(1)] string dirPath)
		{
			long item = 0L;
			return new ValueTuple<long, long>(UKuroLauncherLibrary.GetTotalAndFreeSpace(dirPath, ref item), item);
		}

		// Token: 0x040002FB RID: 763
		private string SaveDir = "";

		// Token: 0x040002FC RID: 764
		private string Platform = "";

		// Token: 0x040002FD RID: 765
		private string InternalUse = "";
	}
}
