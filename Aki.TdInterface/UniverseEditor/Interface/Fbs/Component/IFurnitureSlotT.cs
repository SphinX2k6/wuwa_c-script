using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052DD RID: 21213
	public class IFurnitureSlotT
	{
		// Token: 0x17009BB0 RID: 39856
		// (get) Token: 0x06022A03 RID: 141827 RVA: 0x004CCBDB File Offset: 0x004CADDB
		// (set) Token: 0x06022A04 RID: 141828 RVA: 0x004CCBE3 File Offset: 0x004CADE3
		public IFurnitureCameraT SlotCamera { get; set; }

		// Token: 0x17009BB1 RID: 39857
		// (get) Token: 0x06022A05 RID: 141829 RVA: 0x004CCBEC File Offset: 0x004CADEC
		// (set) Token: 0x06022A06 RID: 141830 RVA: 0x004CCBF4 File Offset: 0x004CADF4
		public ISlotShapeT SlotShape { get; set; }

		// Token: 0x17009BB2 RID: 39858
		// (get) Token: 0x06022A07 RID: 141831 RVA: 0x004CCBFD File Offset: 0x004CADFD
		// (set) Token: 0x06022A08 RID: 141832 RVA: 0x004CCC05 File Offset: 0x004CAE05
		public int FurnitureTag { get; set; }

		// Token: 0x17009BB3 RID: 39859
		// (get) Token: 0x06022A09 RID: 141833 RVA: 0x004CCC0E File Offset: 0x004CAE0E
		// (set) Token: 0x06022A0A RID: 141834 RVA: 0x004CCC16 File Offset: 0x004CAE16
		public List<int> ExcludedFurnitureIds { get; set; }

		// Token: 0x17009BB4 RID: 39860
		// (get) Token: 0x06022A0B RID: 141835 RVA: 0x004CCC1F File Offset: 0x004CAE1F
		// (set) Token: 0x06022A0C RID: 141836 RVA: 0x004CCC27 File Offset: 0x004CAE27
		public byte NullMask { get; set; }

		// Token: 0x06022A0D RID: 141837 RVA: 0x004CCC30 File Offset: 0x004CAE30
		public IFurnitureSlotT()
		{
			this.SlotCamera = null;
			this.SlotShape = null;
			this.FurnitureTag = 0;
			this.ExcludedFurnitureIds = null;
			this.NullMask = 0;
		}
	}
}
