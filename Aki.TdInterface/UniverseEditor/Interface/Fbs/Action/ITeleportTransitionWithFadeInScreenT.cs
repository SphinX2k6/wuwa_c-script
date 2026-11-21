using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA0 RID: 31648
	public class ITeleportTransitionWithFadeInScreenT
	{
		// Token: 0x1700ECFD RID: 60669
		// (get) Token: 0x06039041 RID: 233537 RVA: 0x007B49FA File Offset: 0x007B2BFA
		// (set) Token: 0x06039042 RID: 233538 RVA: 0x007B4A02 File Offset: 0x007B2C02
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECFE RID: 60670
		// (get) Token: 0x06039043 RID: 233539 RVA: 0x007B4A0B File Offset: 0x007B2C0B
		// (set) Token: 0x06039044 RID: 233540 RVA: 0x007B4A13 File Offset: 0x007B2C13
		public EFadeInScreenShowType ScreenType { get; set; }

		// Token: 0x1700ECFF RID: 60671
		// (get) Token: 0x06039045 RID: 233541 RVA: 0x007B4A1C File Offset: 0x007B2C1C
		// (set) Token: 0x06039046 RID: 233542 RVA: 0x007B4A24 File Offset: 0x007B2C24
		public byte NullMask { get; set; }

		// Token: 0x06039047 RID: 233543 RVA: 0x007B4A2D File Offset: 0x007B2C2D
		public ITeleportTransitionWithFadeInScreenT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.ScreenType = EFadeInScreenShowType.White;
			this.NullMask = 0;
		}
	}
}
