using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A28 RID: 14888
	public class IBvbCardFilterBaseT
	{
		// Token: 0x1700660B RID: 26123
		// (get) Token: 0x06014231 RID: 82481 RVA: 0x002F1FFA File Offset: 0x002F01FA
		// (set) Token: 0x06014232 RID: 82482 RVA: 0x002F2002 File Offset: 0x002F0202
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x06014233 RID: 82483 RVA: 0x002F200B File Offset: 0x002F020B
		public IBvbCardFilterBaseT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
		}
	}
}
