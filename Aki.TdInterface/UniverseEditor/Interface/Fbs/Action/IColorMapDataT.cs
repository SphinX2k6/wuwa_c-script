using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006458 RID: 25688
	public class IColorMapDataT
	{
		// Token: 0x1700BF30 RID: 48944
		// (get) Token: 0x0602C747 RID: 182087 RVA: 0x00618E3B File Offset: 0x0061703B
		// (set) Token: 0x0602C748 RID: 182088 RVA: 0x00618E43 File Offset: 0x00617043
		public string Key { get; set; }

		// Token: 0x1700BF31 RID: 48945
		// (get) Token: 0x0602C749 RID: 182089 RVA: 0x00618E4C File Offset: 0x0061704C
		// (set) Token: 0x0602C74A RID: 182090 RVA: 0x00618E54 File Offset: 0x00617054
		public IColorT Color { get; set; }

		// Token: 0x0602C74B RID: 182091 RVA: 0x00618E5D File Offset: 0x0061705D
		public IColorMapDataT()
		{
			this.Key = null;
			this.Color = null;
		}
	}
}
