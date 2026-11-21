using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005368 RID: 21352
	public class IActorStateComponentT
	{
		// Token: 0x170096C3 RID: 38595
		// (get) Token: 0x06021411 RID: 136209 RVA: 0x00496DC9 File Offset: 0x00494FC9
		// (set) Token: 0x06021412 RID: 136210 RVA: 0x00496DD1 File Offset: 0x00494FD1
		public bool Disabled { get; set; }

		// Token: 0x170096C4 RID: 38596
		// (get) Token: 0x06021413 RID: 136211 RVA: 0x00496DDA File Offset: 0x00494FDA
		// (set) Token: 0x06021414 RID: 136212 RVA: 0x00496DE2 File Offset: 0x00494FE2
		public string InitState { get; set; }

		// Token: 0x170096C5 RID: 38597
		// (get) Token: 0x06021415 RID: 136213 RVA: 0x00496DEB File Offset: 0x00494FEB
		// (set) Token: 0x06021416 RID: 136214 RVA: 0x00496DF3 File Offset: 0x00494FF3
		public byte NullMask { get; set; }

		// Token: 0x06021417 RID: 136215 RVA: 0x00496DFC File Offset: 0x00494FFC
		public IActorStateComponentT()
		{
			this.Disabled = false;
			this.InitState = null;
			this.NullMask = 0;
		}
	}
}
