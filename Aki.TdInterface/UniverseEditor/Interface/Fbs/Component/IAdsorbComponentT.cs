using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005374 RID: 21364
	public class IAdsorbComponentT
	{
		// Token: 0x170096D8 RID: 38616
		// (get) Token: 0x0602146B RID: 136299 RVA: 0x00497781 File Offset: 0x00495981
		// (set) Token: 0x0602146C RID: 136300 RVA: 0x00497789 File Offset: 0x00495989
		public bool Disabled { get; set; }

		// Token: 0x170096D9 RID: 38617
		// (get) Token: 0x0602146D RID: 136301 RVA: 0x00497792 File Offset: 0x00495992
		// (set) Token: 0x0602146E RID: 136302 RVA: 0x0049779A File Offset: 0x0049599A
		public float Range { get; set; }

		// Token: 0x170096DA RID: 38618
		// (get) Token: 0x0602146F RID: 136303 RVA: 0x004977A3 File Offset: 0x004959A3
		// (set) Token: 0x06021470 RID: 136304 RVA: 0x004977AB File Offset: 0x004959AB
		public float StartVelocity { get; set; }

		// Token: 0x170096DB RID: 38619
		// (get) Token: 0x06021471 RID: 136305 RVA: 0x004977B4 File Offset: 0x004959B4
		// (set) Token: 0x06021472 RID: 136306 RVA: 0x004977BC File Offset: 0x004959BC
		public float Acceleration { get; set; }

		// Token: 0x170096DC RID: 38620
		// (get) Token: 0x06021473 RID: 136307 RVA: 0x004977C5 File Offset: 0x004959C5
		// (set) Token: 0x06021474 RID: 136308 RVA: 0x004977CD File Offset: 0x004959CD
		public IEntityStateT ActiveStateCondition { get; set; }

		// Token: 0x170096DD RID: 38621
		// (get) Token: 0x06021475 RID: 136309 RVA: 0x004977D6 File Offset: 0x004959D6
		// (set) Token: 0x06021476 RID: 136310 RVA: 0x004977DE File Offset: 0x004959DE
		public int AdsorbLimitedTime { get; set; }

		// Token: 0x170096DE RID: 38622
		// (get) Token: 0x06021477 RID: 136311 RVA: 0x004977E7 File Offset: 0x004959E7
		// (set) Token: 0x06021478 RID: 136312 RVA: 0x004977EF File Offset: 0x004959EF
		public byte NullMask { get; set; }

		// Token: 0x06021479 RID: 136313 RVA: 0x004977F8 File Offset: 0x004959F8
		public IAdsorbComponentT()
		{
			this.Disabled = false;
			this.Range = 0f;
			this.StartVelocity = 0f;
			this.Acceleration = 0f;
			this.ActiveStateCondition = null;
			this.AdsorbLimitedTime = 0;
			this.NullMask = 0;
		}
	}
}
