using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005579 RID: 21881
	public interface IFishingTechNode
	{
		// Token: 0x17006938 RID: 26936
		// (get) Token: 0x060363C6 RID: 222150
		// (set) Token: 0x060363C7 RID: 222151
		int ConfigId { get; set; }

		// Token: 0x17006939 RID: 26937
		// (get) Token: 0x060363C8 RID: 222152
		// (set) Token: 0x060363C9 RID: 222153
		EFishingTechNodeType NodeType { get; set; }

		// Token: 0x1700693A RID: 26938
		// (get) Token: 0x060363CA RID: 222154
		// (set) Token: 0x060363CB RID: 222155
		int Area { get; set; }

		// Token: 0x1700693B RID: 26939
		// (get) Token: 0x060363CC RID: 222156
		// (set) Token: 0x060363CD RID: 222157
		int PreNode { get; set; }
	}
}
