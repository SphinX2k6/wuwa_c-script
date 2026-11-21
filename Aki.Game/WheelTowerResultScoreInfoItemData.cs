using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;

// Token: 0x02000A69 RID: 2665
[NullableContext(1)]
[Nullable(0)]
internal class WheelTowerResultScoreInfoItemData
{
	// Token: 0x17000D9B RID: 3483
	// (get) Token: 0x06007194 RID: 29076 RVA: 0x0022DDCD File Offset: 0x0022BFCD
	// (set) Token: 0x06007195 RID: 29077 RVA: 0x0022DDD5 File Offset: 0x0022BFD5
	public string Desc { get; set; } = string.Empty;

	// Token: 0x17000D9C RID: 3484
	// (get) Token: 0x06007196 RID: 29078 RVA: 0x0022DDDE File Offset: 0x0022BFDE
	// (set) Token: 0x06007197 RID: 29079 RVA: 0x0022DDE6 File Offset: 0x0022BFE6
	public string Score { get; set; } = string.Empty;

	// Token: 0x17000D9D RID: 3485
	// (get) Token: 0x06007198 RID: 29080 RVA: 0x0022DDEF File Offset: 0x0022BFEF
	// (set) Token: 0x06007199 RID: 29081 RVA: 0x0022DDF7 File Offset: 0x0022BFF7
	public EScoreLevel ScoreLevel { get; set; }
}
