using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200023D RID: 573
	[EnumExtensions]
	public enum EResType
	{
		// Token: 0x04000940 RID: 2368
		Launcher,
		// Token: 0x04000941 RID: 2369
		Resource,
		// Token: 0x04000942 RID: 2370
		Lang,
		// Token: 0x04000943 RID: 2371
		Video,
		// Token: 0x04000944 RID: 2372
		[EnumStringMember("Option")]
		Optional
	}
}
