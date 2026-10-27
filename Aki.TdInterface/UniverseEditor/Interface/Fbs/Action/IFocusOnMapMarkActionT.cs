using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006847 RID: 26695
	public class IFocusOnMapMarkActionT
	{
		// Token: 0x1700C64D RID: 50765
		// (get) Token: 0x0602E8BF RID: 190655 RVA: 0x00659CAD File Offset: 0x00657EAD
		// (set) Token: 0x0602E8C0 RID: 190656 RVA: 0x00659CB5 File Offset: 0x00657EB5
		public TFocusOnMapMarkTypeConfigUnion MapMarkType { get; set; }

		// Token: 0x0602E8C1 RID: 190657 RVA: 0x00659CBE File Offset: 0x00657EBE
		public IFocusOnMapMarkActionT()
		{
			this.MapMarkType = null;
		}
	}
}
