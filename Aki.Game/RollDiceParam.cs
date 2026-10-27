using System;
using System.Runtime.CompilerServices;

// Token: 0x02001258 RID: 4696
[NullableContext(2)]
[Nullable(0)]
public class RollDiceParam : IRollDiceParam
{
	// Token: 0x17000AD9 RID: 2777
	// (get) Token: 0x06007F95 RID: 32661 RVA: 0x001B02EA File Offset: 0x001AE4EA
	// (set) Token: 0x06007F96 RID: 32662 RVA: 0x001B02F2 File Offset: 0x001AE4F2
	public float? AniProcess { get; set; }

	// Token: 0x17000ADA RID: 2778
	// (get) Token: 0x06007F97 RID: 32663 RVA: 0x001B02FB File Offset: 0x001AE4FB
	// (set) Token: 0x06007F98 RID: 32664 RVA: 0x001B0303 File Offset: 0x001AE503
	public int? AniNum { get; set; }

	// Token: 0x17000ADB RID: 2779
	// (get) Token: 0x06007F99 RID: 32665 RVA: 0x001B030C File Offset: 0x001AE50C
	// (set) Token: 0x06007F9A RID: 32666 RVA: 0x001B0314 File Offset: 0x001AE514
	[Nullable(1)]
	public int[] DicePoints { [NullableContext(1)] get; [NullableContext(1)] set; } = Array.Empty<int>();

	// Token: 0x17000ADC RID: 2780
	// (get) Token: 0x06007F9B RID: 32667 RVA: 0x001B031D File Offset: 0x001AE51D
	// (set) Token: 0x06007F9C RID: 32668 RVA: 0x001B0325 File Offset: 0x001AE525
	public bool? IsNormalTimer { get; set; }

	// Token: 0x17000ADD RID: 2781
	// (get) Token: 0x06007F9D RID: 32669 RVA: 0x001B032E File Offset: 0x001AE52E
	// (set) Token: 0x06007F9E RID: 32670 RVA: 0x001B0336 File Offset: 0x001AE536
	public ERollDiceCameraMode? CameraMode { get; set; }

	// Token: 0x17000ADE RID: 2782
	// (get) Token: 0x06007F9F RID: 32671 RVA: 0x001B033F File Offset: 0x001AE53F
	// (set) Token: 0x06007FA0 RID: 32672 RVA: 0x001B0347 File Offset: 0x001AE547
	public string BpDiceCase { get; set; }

	// Token: 0x17000ADF RID: 2783
	// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x001B0350 File Offset: 0x001AE550
	// (set) Token: 0x06007FA2 RID: 32674 RVA: 0x001B0358 File Offset: 0x001AE558
	public string DiceCameraCase { get; set; }
}
