using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002B8A RID: 11146
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsLevelInfo : ISurvivorsLevelInfo
{
	// Token: 0x17001EDD RID: 7901
	// (get) Token: 0x0601718D RID: 94605 RVA: 0x005DC924 File Offset: 0x005DAB24
	// (set) Token: 0x0601718E RID: 94606 RVA: 0x005DC92C File Offset: 0x005DAB2C
	public int LevelId { get; set; }

	// Token: 0x17001EDE RID: 7902
	// (get) Token: 0x0601718F RID: 94607 RVA: 0x005DC935 File Offset: 0x005DAB35
	// (set) Token: 0x06017190 RID: 94608 RVA: 0x005DC93D File Offset: 0x005DAB3D
	public long OpenTime { get; set; }

	// Token: 0x17001EDF RID: 7903
	// (get) Token: 0x06017191 RID: 94609 RVA: 0x005DC946 File Offset: 0x005DAB46
	// (set) Token: 0x06017192 RID: 94610 RVA: 0x005DC94E File Offset: 0x005DAB4E
	public bool IsEndlessMode { get; set; }

	// Token: 0x17001EE0 RID: 7904
	// (get) Token: 0x06017193 RID: 94611 RVA: 0x005DC957 File Offset: 0x005DAB57
	// (set) Token: 0x06017194 RID: 94612 RVA: 0x005DC95F File Offset: 0x005DAB5F
	public ModeInfo Info { get; set; }
}
