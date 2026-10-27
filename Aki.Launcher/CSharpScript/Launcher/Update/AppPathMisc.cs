using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000084 RID: 132
	[NullableContext(1)]
	[Nullable(0)]
	public class AppPathMisc
	{
		// Token: 0x060004B0 RID: 1200 RVA: 0x0002DF20 File Offset: 0x0002C120
		public string GetPatchSaveDir()
		{
			if (string.IsNullOrEmpty(this.SaveDir))
			{
				this.SaveDir = UKuroLauncherLibrary.GameSavedDir() + "Resources/";
			}
			return this.SaveDir;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0002DF4A File Offset: 0x0002C14A
		public string GetPlatform()
		{
			if (string.IsNullOrEmpty(this.Platform))
			{
				this.Platform = KuroApplication.IniPlatformNameIncludeEditor();
			}
			return this.Platform;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0002DF6A File Offset: 0x0002C16A
		public string GetInternalUseType()
		{
			if (string.IsNullOrEmpty(this.InternalUse))
			{
				this.InternalUse = UKuroLauncherLibrary.GetAppInternalUseType();
			}
			return this.InternalUse;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0002DF8C File Offset: 0x0002C18C
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

		// Token: 0x060004B4 RID: 1204 RVA: 0x0002E000 File Offset: 0x0002C200
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

		// Token: 0x060004B5 RID: 1205 RVA: 0x0002E068 File Offset: 0x0002C268
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

		// Token: 0x060004B6 RID: 1206 RVA: 0x0002E0CF File Offset: 0x0002C2CF
		public string GetResFilePath(string packageVersion, string patchVersion, string resType, string fileName)
		{
			return this.GetResFileDir(packageVersion, patchVersion, resType) + fileName;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0002E0E4 File Offset: 0x0002C2E4
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

		// Token: 0x060004B8 RID: 1208 RVA: 0x0002E15F File Offset: 0x0002C35F
		public string GetMountManifestPath(string packageVersion, string mountFileName)
		{
			return this.GetPatchSaveDir() + packageVersion + "/Mount/" + mountFileName;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0002E174 File Offset: 0x0002C374
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

		// Token: 0x060004BA RID: 1210 RVA: 0x0002E1E4 File Offset: 0x0002C3E4
		[NullableContext(0)]
		public ValueTuple<long, long> GetTotalAndFreeSpace([Nullable(1)] string dirPath)
		{
			long item = 0L;
			return new ValueTuple<long, long>(UKuroLauncherLibrary.GetTotalAndFreeSpace(dirPath, ref item), item);
		}

		// Token: 0x040002CD RID: 717
		private string SaveDir = "";

		// Token: 0x040002CE RID: 718
		private string Platform = "";

		// Token: 0x040002CF RID: 719
		private string InternalUse = "";
	}
}
