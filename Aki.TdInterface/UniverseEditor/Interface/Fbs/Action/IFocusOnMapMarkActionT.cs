using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECD RID: 28365
	public class IFocusOnMapMarkActionT
	{
		// Token: 0x1700D011 RID: 53265
		// (get) Token: 0x06031147 RID: 201031 RVA: 0x006A7BED File Offset: 0x006A5DED
		// (set) Token: 0x06031148 RID: 201032 RVA: 0x006A7BF5 File Offset: 0x006A5DF5
		public TFocusOnMapMarkTypeConfigUnion MapMarkType { get; set; }

		// Token: 0x06031149 RID: 201033 RVA: 0x006A7BFE File Offset: 0x006A5DFE
		public IFocusOnMapMarkActionT()
		{
			this.MapMarkType = null;
		}
	}
}
