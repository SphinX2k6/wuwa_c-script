using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579A RID: 22426
	public class IFanInteractByFKeyT
	{
		// Token: 0x1700A22D RID: 41517
		// (get) Token: 0x06024335 RID: 148277 RVA: 0x004FA30F File Offset: 0x004F850F
		// (set) Token: 0x06024336 RID: 148278 RVA: 0x004FA317 File Offset: 0x004F8517
		public EFanInteractType Type { get; set; }

		// Token: 0x1700A22E RID: 41518
		// (get) Token: 0x06024337 RID: 148279 RVA: 0x004FA320 File Offset: 0x004F8520
		// (set) Token: 0x06024338 RID: 148280 RVA: 0x004FA328 File Offset: 0x004F8528
		public string TidInteractOptionText { get; set; }

		// Token: 0x06024339 RID: 148281 RVA: 0x004FA331 File Offset: 0x004F8531
		public IFanInteractByFKeyT()
		{
			this.Type = EFanInteractType.Hit;
			this.TidInteractOptionText = null;
		}
	}
}
