using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA9 RID: 31657
	public class ITeleportTransitionWithSpecialCustomLoadingT
	{
		// Token: 0x1700ED1B RID: 60699
		// (get) Token: 0x060390A3 RID: 233635 RVA: 0x007B5693 File Offset: 0x007B3893
		// (set) Token: 0x060390A4 RID: 233636 RVA: 0x007B569B File Offset: 0x007B389B
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ED1C RID: 60700
		// (get) Token: 0x060390A5 RID: 233637 RVA: 0x007B56A4 File Offset: 0x007B38A4
		// (set) Token: 0x060390A6 RID: 233638 RVA: 0x007B56AC File Offset: 0x007B38AC
		public IHonamiStoryCustomLoadingT LoadingType { get; set; }

		// Token: 0x060390A7 RID: 233639 RVA: 0x007B56B5 File Offset: 0x007B38B5
		public ITeleportTransitionWithSpecialCustomLoadingT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.LoadingType = null;
		}
	}
}
