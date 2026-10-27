using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D13 RID: 19731
	public class IVisibleConditionT
	{
		// Token: 0x17008F19 RID: 36633
		// (get) Token: 0x0601F518 RID: 128280 RVA: 0x0045E1C4 File Offset: 0x0045C3C4
		// (set) Token: 0x0601F519 RID: 128281 RVA: 0x0045E1CC File Offset: 0x0045C3CC
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008F1A RID: 36634
		// (get) Token: 0x0601F51A RID: 128282 RVA: 0x0045E1D5 File Offset: 0x0045C3D5
		// (set) Token: 0x0601F51B RID: 128283 RVA: 0x0045E1DD File Offset: 0x0045C3DD
		public ECompare Compare { get; set; }

		// Token: 0x0601F51C RID: 128284 RVA: 0x0045E1E6 File Offset: 0x0045C3E6
		public IVisibleConditionT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
		}
	}
}
