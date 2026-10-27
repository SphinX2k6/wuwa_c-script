using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056ED RID: 22253
	public interface IKurotatoAttrSelectCardData
	{
		// Token: 0x170087DA RID: 34778
		// (get) Token: 0x06038995 RID: 231829
		// (set) Token: 0x06038996 RID: 231830
		int ItemId { get; set; }

		// Token: 0x170087DB RID: 34779
		// (get) Token: 0x06038997 RID: 231831
		// (set) Token: 0x06038998 RID: 231832
		int SelectionId { get; set; }

		// Token: 0x170087DC RID: 34780
		// (get) Token: 0x06038999 RID: 231833
		// (set) Token: 0x0603899A RID: 231834
		bool IsRecommend { get; set; }

		// Token: 0x170087DD RID: 34781
		// (get) Token: 0x0603899B RID: 231835
		// (set) Token: 0x0603899C RID: 231836
		EKurotatoAttrSelectType SelectType { get; set; }
	}
}
