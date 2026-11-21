using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775A RID: 30554
	public class ISetAlertUiVisibleT
	{
		// Token: 0x1700DFF7 RID: 57335
		// (get) Token: 0x06035A07 RID: 219655 RVA: 0x00730192 File Offset: 0x0072E392
		// (set) Token: 0x06035A08 RID: 219656 RVA: 0x0073019A File Offset: 0x0072E39A
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700DFF8 RID: 57336
		// (get) Token: 0x06035A09 RID: 219657 RVA: 0x007301A3 File Offset: 0x0072E3A3
		// (set) Token: 0x06035A0A RID: 219658 RVA: 0x007301AB File Offset: 0x0072E3AB
		public int AreaId { get; set; }

		// Token: 0x1700DFF9 RID: 57337
		// (get) Token: 0x06035A0B RID: 219659 RVA: 0x007301B4 File Offset: 0x0072E3B4
		// (set) Token: 0x06035A0C RID: 219660 RVA: 0x007301BC File Offset: 0x0072E3BC
		public bool IsVisible { get; set; }

		// Token: 0x06035A0D RID: 219661 RVA: 0x007301C5 File Offset: 0x0072E3C5
		public ISetAlertUiVisibleT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.IsVisible = false;
		}
	}
}
