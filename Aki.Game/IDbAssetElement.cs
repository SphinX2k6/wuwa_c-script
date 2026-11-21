using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002880 RID: 10368
[NullableContext(1)]
public interface IDbAssetElement
{
	// Token: 0x17002B0B RID: 11019
	// (get) Token: 0x0601A477 RID: 107639
	// (set) Token: 0x0601A478 RID: 107640
	List<string> ActorClass { get; set; }

	// Token: 0x17002B0C RID: 11020
	// (get) Token: 0x0601A479 RID: 107641
	// (set) Token: 0x0601A47A RID: 107642
	List<string> Animations { get; set; }

	// Token: 0x17002B0D RID: 11021
	// (get) Token: 0x0601A47B RID: 107643
	// (set) Token: 0x0601A47C RID: 107644
	List<string> Effects { get; set; }

	// Token: 0x17002B0E RID: 11022
	// (get) Token: 0x0601A47D RID: 107645
	// (set) Token: 0x0601A47E RID: 107646
	List<string> Audios { get; set; }

	// Token: 0x17002B0F RID: 11023
	// (get) Token: 0x0601A47F RID: 107647
	// (set) Token: 0x0601A480 RID: 107648
	List<string> Meshes { get; set; }

	// Token: 0x17002B10 RID: 11024
	// (get) Token: 0x0601A481 RID: 107649
	// (set) Token: 0x0601A482 RID: 107650
	List<string> Materials { get; set; }

	// Token: 0x17002B11 RID: 11025
	// (get) Token: 0x0601A483 RID: 107651
	// (set) Token: 0x0601A484 RID: 107652
	List<string> AnimationBlueprints { get; set; }

	// Token: 0x17002B12 RID: 11026
	// (get) Token: 0x0601A485 RID: 107653
	// (set) Token: 0x0601A486 RID: 107654
	List<string> Others { get; set; }
}
