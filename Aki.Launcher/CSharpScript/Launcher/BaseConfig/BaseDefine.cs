using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000270 RID: 624
	[NullableContext(1)]
	[Nullable(0)]
	public static class BaseDefine
	{
		// Token: 0x06000F33 RID: 3891 RVA: 0x00058EC6 File Offset: 0x000570C6
		public static string GetPublicConfigPath()
		{
			return UBlueprintPathsLibrary.ProjectConfigDir() + "/Kuro/KuroPublicConfig.ini";
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00058ED7 File Offset: 0x000570D7
		public static string GetLocalGameDataPath()
		{
			return UBlueprintPathsLibrary.ProjectConfigDir() + "../Saved/SaveGames/AkiSaveGame.conf";
		}

		// Token: 0x04000A12 RID: 2578
		public const int TRYLIMIT = 10;

		// Token: 0x04000A13 RID: 2579
		public const string USESDK = "1";

		// Token: 0x04000A14 RID: 2580
		public const string SDKON = "sdkon";

		// Token: 0x04000A15 RID: 2581
		public const string SDKOFF = "sdkoff";

		// Token: 0x04000A16 RID: 2582
		public const string EDITOR = "editor";

		// Token: 0x04000A17 RID: 2583
		public const string PACK = "pack";

		// Token: 0x04000A18 RID: 2584
		public const bool TESTCDNON = false;

		// Token: 0x04000A19 RID: 2585
		public const string TESTNOTICEURL = "";
	}
}
