using System;
using System.Runtime.CompilerServices;

// Token: 0x02001257 RID: 4695
[NullableContext(2)]
public interface IRollDiceParam
{
	// Token: 0x17000AD2 RID: 2770
	// (get) Token: 0x06007F87 RID: 32647
	// (set) Token: 0x06007F88 RID: 32648
	float? AniProcess { get; set; }

	// Token: 0x17000AD3 RID: 2771
	// (get) Token: 0x06007F89 RID: 32649
	// (set) Token: 0x06007F8A RID: 32650
	int? AniNum { get; set; }

	// Token: 0x17000AD4 RID: 2772
	// (get) Token: 0x06007F8B RID: 32651
	// (set) Token: 0x06007F8C RID: 32652
	[Nullable(1)]
	int[] DicePoints { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000AD5 RID: 2773
	// (get) Token: 0x06007F8D RID: 32653
	// (set) Token: 0x06007F8E RID: 32654
	bool? IsNormalTimer { get; set; }

	// Token: 0x17000AD6 RID: 2774
	// (get) Token: 0x06007F8F RID: 32655
	// (set) Token: 0x06007F90 RID: 32656
	ERollDiceCameraMode? CameraMode { get; set; }

	// Token: 0x17000AD7 RID: 2775
	// (get) Token: 0x06007F91 RID: 32657
	// (set) Token: 0x06007F92 RID: 32658
	string BpDiceCase { get; set; }

	// Token: 0x17000AD8 RID: 2776
	// (get) Token: 0x06007F93 RID: 32659
	// (set) Token: 0x06007F94 RID: 32660
	string DiceCameraCase { get; set; }
}
