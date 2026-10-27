using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F7 RID: 20727
	public class IDynamicPortalCreatorComponentT
	{
		// Token: 0x170096F5 RID: 38645
		// (get) Token: 0x06021611 RID: 136721 RVA: 0x004A29B5 File Offset: 0x004A0BB5
		// (set) Token: 0x06021612 RID: 136722 RVA: 0x004A29BD File Offset: 0x004A0BBD
		public bool Disabled { get; set; }

		// Token: 0x170096F6 RID: 38646
		// (get) Token: 0x06021613 RID: 136723 RVA: 0x004A29C6 File Offset: 0x004A0BC6
		// (set) Token: 0x06021614 RID: 136724 RVA: 0x004A29CE File Offset: 0x004A0BCE
		public IDynamicPortalByBulletT Model { get; set; }

		// Token: 0x170096F7 RID: 38647
		// (get) Token: 0x06021615 RID: 136725 RVA: 0x004A29D7 File Offset: 0x004A0BD7
		// (set) Token: 0x06021616 RID: 136726 RVA: 0x004A29DF File Offset: 0x004A0BDF
		public byte NullMask { get; set; }

		// Token: 0x06021617 RID: 136727 RVA: 0x004A29E8 File Offset: 0x004A0BE8
		public IDynamicPortalCreatorComponentT()
		{
			this.Disabled = false;
			this.Model = null;
			this.NullMask = 0;
		}
	}
}
