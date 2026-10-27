using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB4 RID: 19380
	public class ICompareMaxAlertValueT
	{
		// Token: 0x17008CB8 RID: 36024
		// (get) Token: 0x0601E922 RID: 125218 RVA: 0x00446AEE File Offset: 0x00444CEE
		// (set) Token: 0x0601E923 RID: 125219 RVA: 0x00446AF6 File Offset: 0x00444CF6
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x0601E924 RID: 125220 RVA: 0x00446AFF File Offset: 0x00444CFF
		public ICompareMaxAlertValueT()
		{
			this.Type = EComparedAlertValueType.Min;
		}
	}
}
