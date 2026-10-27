using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050FA RID: 20730
	public class IDynamicSpawnMonsterComponentT
	{
		// Token: 0x170096FC RID: 38652
		// (get) Token: 0x06021631 RID: 136753 RVA: 0x004A2DED File Offset: 0x004A0FED
		// (set) Token: 0x06021632 RID: 136754 RVA: 0x004A2DF5 File Offset: 0x004A0FF5
		public bool Disabled { get; set; }

		// Token: 0x170096FD RID: 38653
		// (get) Token: 0x06021633 RID: 136755 RVA: 0x004A2DFE File Offset: 0x004A0FFE
		// (set) Token: 0x06021634 RID: 136756 RVA: 0x004A2E06 File Offset: 0x004A1006
		public List<IConditionSpawnMonsterT> Group { get; set; }

		// Token: 0x170096FE RID: 38654
		// (get) Token: 0x06021635 RID: 136757 RVA: 0x004A2E0F File Offset: 0x004A100F
		// (set) Token: 0x06021636 RID: 136758 RVA: 0x004A2E17 File Offset: 0x004A1017
		public byte NullMask { get; set; }

		// Token: 0x06021637 RID: 136759 RVA: 0x004A2E20 File Offset: 0x004A1020
		public IDynamicSpawnMonsterComponentT()
		{
			this.Disabled = false;
			this.Group = null;
			this.NullMask = 0;
		}
	}
}
