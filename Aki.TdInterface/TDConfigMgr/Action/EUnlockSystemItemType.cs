using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200186B RID: 6251
	[EnumExtensions]
	public enum EUnlockSystemItemType
	{
		// Token: 0x0400539C RID: 21404
		CookSystem,
		// Token: 0x0400539D RID: 21405
		AtlasSystem,
		// Token: 0x0400539E RID: 21406
		AchievementSystem,
		// Token: 0x0400539F RID: 21407
		[EnumStringMember("MemoirsSystem")]
		PhotoMemoryCollect,
		// Token: 0x040053A0 RID: 21408
		DangoCollect
	}
}
