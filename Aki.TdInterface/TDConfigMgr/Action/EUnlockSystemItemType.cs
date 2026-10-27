using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016EF RID: 5871
	[EnumExtensions]
	public enum EUnlockSystemItemType
	{
		// Token: 0x04004F6F RID: 20335
		CookSystem,
		// Token: 0x04004F70 RID: 20336
		AtlasSystem,
		// Token: 0x04004F71 RID: 20337
		AchievementSystem,
		// Token: 0x04004F72 RID: 20338
		[EnumStringMember("MemoirsSystem")]
		PhotoMemoryCollect,
		// Token: 0x04004F73 RID: 20339
		DangoCollect
	}
}
