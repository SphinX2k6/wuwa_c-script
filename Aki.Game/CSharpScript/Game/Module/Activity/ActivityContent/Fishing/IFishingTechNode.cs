using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065FB RID: 26107
	public interface IFishingTechNode
	{
		// Token: 0x170095D6 RID: 38358
		// (get) Token: 0x06041701 RID: 268033
		// (set) Token: 0x06041702 RID: 268034
		int ConfigId { get; set; }

		// Token: 0x170095D7 RID: 38359
		// (get) Token: 0x06041703 RID: 268035
		// (set) Token: 0x06041704 RID: 268036
		EFishingTechNodeType NodeType { get; set; }

		// Token: 0x170095D8 RID: 38360
		// (get) Token: 0x06041705 RID: 268037
		// (set) Token: 0x06041706 RID: 268038
		int Area { get; set; }

		// Token: 0x170095D9 RID: 38361
		// (get) Token: 0x06041707 RID: 268039
		// (set) Token: 0x06041708 RID: 268040
		int PreNode { get; set; }
	}
}
