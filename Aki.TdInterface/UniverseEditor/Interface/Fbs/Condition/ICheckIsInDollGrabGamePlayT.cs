using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A91 RID: 19089
	public class ICheckIsInDollGrabGamePlayT
	{
		// Token: 0x17008A4E RID: 35406
		// (get) Token: 0x0601DF0E RID: 122638 RVA: 0x004345CE File Offset: 0x004327CE
		// (set) Token: 0x0601DF0F RID: 122639 RVA: 0x004345D6 File Offset: 0x004327D6
		public ECondition Type { get; set; }

		// Token: 0x17008A4F RID: 35407
		// (get) Token: 0x0601DF10 RID: 122640 RVA: 0x004345DF File Offset: 0x004327DF
		// (set) Token: 0x0601DF11 RID: 122641 RVA: 0x004345E7 File Offset: 0x004327E7
		public bool IsIn { get; set; }

		// Token: 0x17008A50 RID: 35408
		// (get) Token: 0x0601DF12 RID: 122642 RVA: 0x004345F0 File Offset: 0x004327F0
		// (set) Token: 0x0601DF13 RID: 122643 RVA: 0x004345F8 File Offset: 0x004327F8
		public int DollGrabEntityId { get; set; }

		// Token: 0x0601DF14 RID: 122644 RVA: 0x00434601 File Offset: 0x00432801
		public ICheckIsInDollGrabGamePlayT()
		{
			this.Type = ECondition.CompareVar;
			this.IsIn = false;
			this.DollGrabEntityId = 0;
		}
	}
}
