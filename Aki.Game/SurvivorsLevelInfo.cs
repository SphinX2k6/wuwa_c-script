using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002106 RID: 8454
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsLevelInfo : ISurvivorsLevelInfo
{
	// Token: 0x17001F35 RID: 7989
	// (get) Token: 0x06014BBE RID: 84926 RVA: 0x00609504 File Offset: 0x00607704
	// (set) Token: 0x06014BBF RID: 84927 RVA: 0x0060950C File Offset: 0x0060770C
	public int LevelId { get; set; }

	// Token: 0x17001F36 RID: 7990
	// (get) Token: 0x06014BC0 RID: 84928 RVA: 0x00609515 File Offset: 0x00607715
	// (set) Token: 0x06014BC1 RID: 84929 RVA: 0x0060951D File Offset: 0x0060771D
	public long OpenTime { get; set; }

	// Token: 0x17001F37 RID: 7991
	// (get) Token: 0x06014BC2 RID: 84930 RVA: 0x00609526 File Offset: 0x00607726
	// (set) Token: 0x06014BC3 RID: 84931 RVA: 0x0060952E File Offset: 0x0060772E
	public bool IsEndlessMode { get; set; }

	// Token: 0x17001F38 RID: 7992
	// (get) Token: 0x06014BC4 RID: 84932 RVA: 0x00609537 File Offset: 0x00607737
	// (set) Token: 0x06014BC5 RID: 84933 RVA: 0x0060953F File Offset: 0x0060773F
	public ModeInfo Info { get; set; }
}
