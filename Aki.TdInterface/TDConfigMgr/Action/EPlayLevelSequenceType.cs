using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017EC RID: 6124
	[EnumExtensions]
	public enum EPlayLevelSequenceType
	{
		// Token: 0x0400511B RID: 20763
		[EnumStringMember("direct")]
		Direct,
		// Token: 0x0400511C RID: 20764
		[EnumStringMember("shortestPath")]
		ShortestPath,
		// Token: 0x0400511D RID: 20765
		[EnumStringMember("loop")]
		Loop,
		// Token: 0x0400511E RID: 20766
		[EnumStringMember("instant")]
		Instant
	}
}
