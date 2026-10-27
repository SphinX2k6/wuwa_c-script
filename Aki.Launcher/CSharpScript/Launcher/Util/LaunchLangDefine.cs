using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006D RID: 109
	[NullableContext(1)]
	[Nullable(0)]
	public class LaunchLangDefine
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0000EF8A File Offset: 0x0000D18A
		public LaunchLangDefine(int languageType, string languageCode, string audioCode)
		{
			this.LanguageType = languageType;
			this.LanguageCode = languageCode;
			this.AudioCode = audioCode;
		}

		// Token: 0x040001CF RID: 463
		public readonly int LanguageType;

		// Token: 0x040001D0 RID: 464
		public readonly string LanguageCode;

		// Token: 0x040001D1 RID: 465
		public readonly string AudioCode;
	}
}
