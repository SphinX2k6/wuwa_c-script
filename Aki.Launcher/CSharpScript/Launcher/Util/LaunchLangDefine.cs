using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006F RID: 111
	[NullableContext(1)]
	[Nullable(0)]
	public class LaunchLangDefine
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x0000F4B2 File Offset: 0x0000D6B2
		public LaunchLangDefine(int languageType, string languageCode, string audioCode)
		{
			this.LanguageType = languageType;
			this.LanguageCode = languageCode;
			this.AudioCode = audioCode;
		}

		// Token: 0x040001F7 RID: 503
		public readonly int LanguageType;

		// Token: 0x040001F8 RID: 504
		public readonly string LanguageCode;

		// Token: 0x040001F9 RID: 505
		public readonly string AudioCode;
	}
}
