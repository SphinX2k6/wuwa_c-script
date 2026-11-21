using System;
using System.Runtime.CompilerServices;

// Token: 0x0200070B RID: 1803
[NullableContext(2)]
public interface IRollDiceParam
{
	// Token: 0x17000AF2 RID: 2802
	// (get) Token: 0x0600531E RID: 21278
	// (set) Token: 0x0600531F RID: 21279
	float? AniProcess { get; set; }

	// Token: 0x17000AF3 RID: 2803
	// (get) Token: 0x06005320 RID: 21280
	// (set) Token: 0x06005321 RID: 21281
	int? AniNum { get; set; }

	// Token: 0x17000AF4 RID: 2804
	// (get) Token: 0x06005322 RID: 21282
	// (set) Token: 0x06005323 RID: 21283
	[Nullable(1)]
	int[] DicePoints { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000AF5 RID: 2805
	// (get) Token: 0x06005324 RID: 21284
	// (set) Token: 0x06005325 RID: 21285
	bool? IsNormalTimer { get; set; }

	// Token: 0x17000AF6 RID: 2806
	// (get) Token: 0x06005326 RID: 21286
	// (set) Token: 0x06005327 RID: 21287
	ERollDiceCameraMode? CameraMode { get; set; }

	// Token: 0x17000AF7 RID: 2807
	// (get) Token: 0x06005328 RID: 21288
	// (set) Token: 0x06005329 RID: 21289
	string BpDiceCase { get; set; }

	// Token: 0x17000AF8 RID: 2808
	// (get) Token: 0x0600532A RID: 21290
	// (set) Token: 0x0600532B RID: 21291
	string DiceCameraCase { get; set; }
}
