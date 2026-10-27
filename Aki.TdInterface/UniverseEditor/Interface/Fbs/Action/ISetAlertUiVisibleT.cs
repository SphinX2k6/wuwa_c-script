using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F94 RID: 28564
	public class ISetAlertUiVisibleT
	{
		// Token: 0x1700D428 RID: 54312
		// (get) Token: 0x060327B7 RID: 206775 RVA: 0x006D07DA File Offset: 0x006CE9DA
		// (set) Token: 0x060327B8 RID: 206776 RVA: 0x006D07E2 File Offset: 0x006CE9E2
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700D429 RID: 54313
		// (get) Token: 0x060327B9 RID: 206777 RVA: 0x006D07EB File Offset: 0x006CE9EB
		// (set) Token: 0x060327BA RID: 206778 RVA: 0x006D07F3 File Offset: 0x006CE9F3
		public int AreaId { get; set; }

		// Token: 0x1700D42A RID: 54314
		// (get) Token: 0x060327BB RID: 206779 RVA: 0x006D07FC File Offset: 0x006CE9FC
		// (set) Token: 0x060327BC RID: 206780 RVA: 0x006D0804 File Offset: 0x006CEA04
		public bool IsVisible { get; set; }

		// Token: 0x060327BD RID: 206781 RVA: 0x006D080D File Offset: 0x006CEA0D
		public ISetAlertUiVisibleT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.IsVisible = false;
		}
	}
}
