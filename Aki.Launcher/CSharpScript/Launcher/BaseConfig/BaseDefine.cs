using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000277 RID: 631
	[NullableContext(1)]
	[Nullable(0)]
	public static class BaseDefine
	{
		// Token: 0x06000F7E RID: 3966 RVA: 0x0005BE6D File Offset: 0x0005A06D
		public static string GetPublicConfigPath()
		{
			return UBlueprintPathsLibrary.ProjectConfigDir() + "/Kuro/KuroPublicConfig.ini";
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0005BE7E File Offset: 0x0005A07E
		public static string GetLocalGameDataPath()
		{
			return UBlueprintPathsLibrary.ProjectConfigDir() + "../Saved/SaveGames/AkiSaveGame.conf";
		}

		// Token: 0x04000A60 RID: 2656
		public const int TRYLIMIT = 10;

		// Token: 0x04000A61 RID: 2657
		public const string USESDK = "1";

		// Token: 0x04000A62 RID: 2658
		public const string SDKON = "sdkon";

		// Token: 0x04000A63 RID: 2659
		public const string SDKOFF = "sdkoff";

		// Token: 0x04000A64 RID: 2660
		public const string EDITOR = "editor";

		// Token: 0x04000A65 RID: 2661
		public const string PACK = "pack";

		// Token: 0x04000A66 RID: 2662
		public const bool TESTCDNON = false;

		// Token: 0x04000A67 RID: 2663
		public const string TESTNOTICEURL = "";
	}
}
