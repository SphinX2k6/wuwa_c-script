using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740A RID: 29706
	public class IPetalGrabMoveLinearT
	{
		// Token: 0x1700DA43 RID: 55875
		// (get) Token: 0x06033FB0 RID: 212912 RVA: 0x00701D22 File Offset: 0x006FFF22
		// (set) Token: 0x06033FB1 RID: 212913 RVA: 0x00701D2A File Offset: 0x006FFF2A
		public EPetalGrabMoveType Type { get; set; }

		// Token: 0x1700DA44 RID: 55876
		// (get) Token: 0x06033FB2 RID: 212914 RVA: 0x00701D33 File Offset: 0x006FFF33
		// (set) Token: 0x06033FB3 RID: 212915 RVA: 0x00701D3B File Offset: 0x006FFF3B
		public int StartHalfWidth { get; set; }

		// Token: 0x1700DA45 RID: 55877
		// (get) Token: 0x06033FB4 RID: 212916 RVA: 0x00701D44 File Offset: 0x006FFF44
		// (set) Token: 0x06033FB5 RID: 212917 RVA: 0x00701D4C File Offset: 0x006FFF4C
		public int EndHalfWidth { get; set; }

		// Token: 0x06033FB6 RID: 212918 RVA: 0x00701D55 File Offset: 0x006FFF55
		public IPetalGrabMoveLinearT()
		{
			this.Type = EPetalGrabMoveType.Linear;
			this.StartHalfWidth = 0;
			this.EndHalfWidth = 0;
		}
	}
}
