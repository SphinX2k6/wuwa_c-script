using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B9 RID: 29625
	public class ITeleportTransitionWithFadeInScreenT
	{
		// Token: 0x1700E0ED RID: 57581
		// (get) Token: 0x06035CA6 RID: 220326 RVA: 0x007524BA File Offset: 0x007506BA
		// (set) Token: 0x06035CA7 RID: 220327 RVA: 0x007524C2 File Offset: 0x007506C2
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0EE RID: 57582
		// (get) Token: 0x06035CA8 RID: 220328 RVA: 0x007524CB File Offset: 0x007506CB
		// (set) Token: 0x06035CA9 RID: 220329 RVA: 0x007524D3 File Offset: 0x007506D3
		public EFadeInScreenShowType ScreenType { get; set; }

		// Token: 0x1700E0EF RID: 57583
		// (get) Token: 0x06035CAA RID: 220330 RVA: 0x007524DC File Offset: 0x007506DC
		// (set) Token: 0x06035CAB RID: 220331 RVA: 0x007524E4 File Offset: 0x007506E4
		public byte NullMask { get; set; }

		// Token: 0x06035CAC RID: 220332 RVA: 0x007524ED File Offset: 0x007506ED
		public ITeleportTransitionWithFadeInScreenT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.ScreenType = EFadeInScreenShowType.White;
			this.NullMask = 0;
		}
	}
}
