using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005863 RID: 22627
	public class IFurnitureSlotComponentT
	{
		// Token: 0x1700A3EB RID: 41963
		// (get) Token: 0x06024AC3 RID: 150211 RVA: 0x00509C79 File Offset: 0x00507E79
		// (set) Token: 0x06024AC4 RID: 150212 RVA: 0x00509C81 File Offset: 0x00507E81
		public bool Disabled { get; set; }

		// Token: 0x1700A3EC RID: 41964
		// (get) Token: 0x06024AC5 RID: 150213 RVA: 0x00509C8A File Offset: 0x00507E8A
		// (set) Token: 0x06024AC6 RID: 150214 RVA: 0x00509C92 File Offset: 0x00507E92
		public List<IFurnitureSlotT> Slots { get; set; }

		// Token: 0x1700A3ED RID: 41965
		// (get) Token: 0x06024AC7 RID: 150215 RVA: 0x00509C9B File Offset: 0x00507E9B
		// (set) Token: 0x06024AC8 RID: 150216 RVA: 0x00509CA3 File Offset: 0x00507EA3
		public IFurnitureCameraT FurnitureCamera { get; set; }

		// Token: 0x1700A3EE RID: 41966
		// (get) Token: 0x06024AC9 RID: 150217 RVA: 0x00509CAC File Offset: 0x00507EAC
		// (set) Token: 0x06024ACA RID: 150218 RVA: 0x00509CB4 File Offset: 0x00507EB4
		public byte NullMask { get; set; }

		// Token: 0x06024ACB RID: 150219 RVA: 0x00509CBD File Offset: 0x00507EBD
		public IFurnitureSlotComponentT()
		{
			this.Disabled = false;
			this.Slots = null;
			this.FurnitureCamera = null;
			this.NullMask = 0;
		}
	}
}
