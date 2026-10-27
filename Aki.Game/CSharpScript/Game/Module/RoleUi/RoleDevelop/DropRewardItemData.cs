using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D1D RID: 19741
	public class DropRewardItemData : IDropRewardItemData
	{
		// Token: 0x17007E10 RID: 32272
		// (get) Token: 0x06033026 RID: 208934 RVA: 0x00BE1C2A File Offset: 0x00BDFE2A
		// (set) Token: 0x06033027 RID: 208935 RVA: 0x00BE1C32 File Offset: 0x00BDFE32
		public int ItemId { get; set; }

		// Token: 0x17007E11 RID: 32273
		// (get) Token: 0x06033028 RID: 208936 RVA: 0x00BE1C3B File Offset: 0x00BDFE3B
		// (set) Token: 0x06033029 RID: 208937 RVA: 0x00BE1C43 File Offset: 0x00BDFE43
		public int Count { get; set; }

		// Token: 0x17007E12 RID: 32274
		// (get) Token: 0x0603302A RID: 208938 RVA: 0x00BE1C4C File Offset: 0x00BDFE4C
		// (set) Token: 0x0603302B RID: 208939 RVA: 0x00BE1C54 File Offset: 0x00BDFE54
		public bool HaveFinish { get; set; }
	}
}
