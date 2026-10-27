using System;
using System.Runtime.CompilerServices;

// Token: 0x020019A9 RID: 6569
[NullableContext(1)]
public interface ISpineAnimationQueueParam
{
	// Token: 0x1700100C RID: 4108
	// (get) Token: 0x0600BF99 RID: 49049
	// (set) Token: 0x0600BF9A RID: 49050
	int LayerIndex { get; set; }

	// Token: 0x1700100D RID: 4109
	// (get) Token: 0x0600BF9B RID: 49051
	// (set) Token: 0x0600BF9C RID: 49052
	string AnimationName { get; set; }

	// Token: 0x1700100E RID: 4110
	// (get) Token: 0x0600BF9D RID: 49053
	// (set) Token: 0x0600BF9E RID: 49054
	bool Loop { get; set; }
}
