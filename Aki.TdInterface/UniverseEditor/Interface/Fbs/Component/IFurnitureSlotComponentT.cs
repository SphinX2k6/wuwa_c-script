using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E0 RID: 21216
	public class IFurnitureSlotComponentT
	{
		// Token: 0x17009BBA RID: 39866
		// (get) Token: 0x06022A29 RID: 141865 RVA: 0x004CD14D File Offset: 0x004CB34D
		// (set) Token: 0x06022A2A RID: 141866 RVA: 0x004CD155 File Offset: 0x004CB355
		public bool Disabled { get; set; }

		// Token: 0x17009BBB RID: 39867
		// (get) Token: 0x06022A2B RID: 141867 RVA: 0x004CD15E File Offset: 0x004CB35E
		// (set) Token: 0x06022A2C RID: 141868 RVA: 0x004CD166 File Offset: 0x004CB366
		public List<IFurnitureSlotT> Slots { get; set; }

		// Token: 0x17009BBC RID: 39868
		// (get) Token: 0x06022A2D RID: 141869 RVA: 0x004CD16F File Offset: 0x004CB36F
		// (set) Token: 0x06022A2E RID: 141870 RVA: 0x004CD177 File Offset: 0x004CB377
		public IFurnitureCameraT FurnitureCamera { get; set; }

		// Token: 0x17009BBD RID: 39869
		// (get) Token: 0x06022A2F RID: 141871 RVA: 0x004CD180 File Offset: 0x004CB380
		// (set) Token: 0x06022A30 RID: 141872 RVA: 0x004CD188 File Offset: 0x004CB388
		public byte NullMask { get; set; }

		// Token: 0x06022A31 RID: 141873 RVA: 0x004CD191 File Offset: 0x004CB391
		public IFurnitureSlotComponentT()
		{
			this.Disabled = false;
			this.Slots = null;
			this.FurnitureCamera = null;
			this.NullMask = 0;
		}
	}
}
