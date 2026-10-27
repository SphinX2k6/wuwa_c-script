using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200330E RID: 13070
[NullableContext(1)]
public interface IDbAssetElement
{
	// Token: 0x1700276E RID: 10094
	// (get) Token: 0x0601C77E RID: 116606
	// (set) Token: 0x0601C77F RID: 116607
	List<string> ActorClass { get; set; }

	// Token: 0x1700276F RID: 10095
	// (get) Token: 0x0601C780 RID: 116608
	// (set) Token: 0x0601C781 RID: 116609
	List<string> Animations { get; set; }

	// Token: 0x17002770 RID: 10096
	// (get) Token: 0x0601C782 RID: 116610
	// (set) Token: 0x0601C783 RID: 116611
	List<string> Effects { get; set; }

	// Token: 0x17002771 RID: 10097
	// (get) Token: 0x0601C784 RID: 116612
	// (set) Token: 0x0601C785 RID: 116613
	List<string> Audios { get; set; }

	// Token: 0x17002772 RID: 10098
	// (get) Token: 0x0601C786 RID: 116614
	// (set) Token: 0x0601C787 RID: 116615
	List<string> Meshes { get; set; }

	// Token: 0x17002773 RID: 10099
	// (get) Token: 0x0601C788 RID: 116616
	// (set) Token: 0x0601C789 RID: 116617
	List<string> Materials { get; set; }

	// Token: 0x17002774 RID: 10100
	// (get) Token: 0x0601C78A RID: 116618
	// (set) Token: 0x0601C78B RID: 116619
	List<string> AnimationBlueprints { get; set; }

	// Token: 0x17002775 RID: 10101
	// (get) Token: 0x0601C78C RID: 116620
	// (set) Token: 0x0601C78D RID: 116621
	List<string> Others { get; set; }
}
