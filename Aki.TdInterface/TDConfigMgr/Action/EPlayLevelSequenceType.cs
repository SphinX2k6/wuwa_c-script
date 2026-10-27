using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001679 RID: 5753
	[EnumExtensions]
	public enum EPlayLevelSequenceType
	{
		// Token: 0x04004D16 RID: 19734
		[EnumStringMember("direct")]
		Direct,
		// Token: 0x04004D17 RID: 19735
		[EnumStringMember("shortestPath")]
		ShortestPath,
		// Token: 0x04004D18 RID: 19736
		[EnumStringMember("loop")]
		Loop,
		// Token: 0x04004D19 RID: 19737
		[EnumStringMember("instant")]
		Instant
	}
}
