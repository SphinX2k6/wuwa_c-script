using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B9 RID: 30137
	public class IRemoveBuffFromEntityT
	{
		// Token: 0x1700DD97 RID: 56727
		// (get) Token: 0x06034DEE RID: 216558 RVA: 0x0071B3EC File Offset: 0x007195EC
		// (set) Token: 0x06034DEF RID: 216559 RVA: 0x0071B3F4 File Offset: 0x007195F4
		public int EntityId { get; set; }

		// Token: 0x1700DD98 RID: 56728
		// (get) Token: 0x06034DF0 RID: 216560 RVA: 0x0071B3FD File Offset: 0x007195FD
		// (set) Token: 0x06034DF1 RID: 216561 RVA: 0x0071B405 File Offset: 0x00719605
		public List<int> EntityIds { get; set; }

		// Token: 0x1700DD99 RID: 56729
		// (get) Token: 0x06034DF2 RID: 216562 RVA: 0x0071B40E File Offset: 0x0071960E
		// (set) Token: 0x06034DF3 RID: 216563 RVA: 0x0071B416 File Offset: 0x00719616
		public List<long> BuffIds { get; set; }

		// Token: 0x1700DD9A RID: 56730
		// (get) Token: 0x06034DF4 RID: 216564 RVA: 0x0071B41F File Offset: 0x0071961F
		// (set) Token: 0x06034DF5 RID: 216565 RVA: 0x0071B427 File Offset: 0x00719627
		public byte NullMask { get; set; }

		// Token: 0x06034DF6 RID: 216566 RVA: 0x0071B430 File Offset: 0x00719630
		public IRemoveBuffFromEntityT()
		{
			this.EntityId = 0;
			this.EntityIds = null;
			this.BuffIds = null;
			this.NullMask = 0;
		}
	}
}
