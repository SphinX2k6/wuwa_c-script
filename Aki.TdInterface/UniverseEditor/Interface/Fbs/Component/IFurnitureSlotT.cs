using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005860 RID: 22624
	public class IFurnitureSlotT
	{
		// Token: 0x1700A3E1 RID: 41953
		// (get) Token: 0x06024A9D RID: 150173 RVA: 0x00509707 File Offset: 0x00507907
		// (set) Token: 0x06024A9E RID: 150174 RVA: 0x0050970F File Offset: 0x0050790F
		public IFurnitureCameraT SlotCamera { get; set; }

		// Token: 0x1700A3E2 RID: 41954
		// (get) Token: 0x06024A9F RID: 150175 RVA: 0x00509718 File Offset: 0x00507918
		// (set) Token: 0x06024AA0 RID: 150176 RVA: 0x00509720 File Offset: 0x00507920
		public ISlotShapeT SlotShape { get; set; }

		// Token: 0x1700A3E3 RID: 41955
		// (get) Token: 0x06024AA1 RID: 150177 RVA: 0x00509729 File Offset: 0x00507929
		// (set) Token: 0x06024AA2 RID: 150178 RVA: 0x00509731 File Offset: 0x00507931
		public int FurnitureTag { get; set; }

		// Token: 0x1700A3E4 RID: 41956
		// (get) Token: 0x06024AA3 RID: 150179 RVA: 0x0050973A File Offset: 0x0050793A
		// (set) Token: 0x06024AA4 RID: 150180 RVA: 0x00509742 File Offset: 0x00507942
		public List<int> ExcludedFurnitureIds { get; set; }

		// Token: 0x1700A3E5 RID: 41957
		// (get) Token: 0x06024AA5 RID: 150181 RVA: 0x0050974B File Offset: 0x0050794B
		// (set) Token: 0x06024AA6 RID: 150182 RVA: 0x00509753 File Offset: 0x00507953
		public byte NullMask { get; set; }

		// Token: 0x06024AA7 RID: 150183 RVA: 0x0050975C File Offset: 0x0050795C
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
