using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E63 RID: 20067
	public class IAdsorbComponentT
	{
		// Token: 0x17008F9F RID: 36767
		// (get) Token: 0x0601F820 RID: 129056 RVA: 0x00463769 File Offset: 0x00461969
		// (set) Token: 0x0601F821 RID: 129057 RVA: 0x00463771 File Offset: 0x00461971
		public bool Disabled { get; set; }

		// Token: 0x17008FA0 RID: 36768
		// (get) Token: 0x0601F822 RID: 129058 RVA: 0x0046377A File Offset: 0x0046197A
		// (set) Token: 0x0601F823 RID: 129059 RVA: 0x00463782 File Offset: 0x00461982
		public float Range { get; set; }

		// Token: 0x17008FA1 RID: 36769
		// (get) Token: 0x0601F824 RID: 129060 RVA: 0x0046378B File Offset: 0x0046198B
		// (set) Token: 0x0601F825 RID: 129061 RVA: 0x00463793 File Offset: 0x00461993
		public float StartVelocity { get; set; }

		// Token: 0x17008FA2 RID: 36770
		// (get) Token: 0x0601F826 RID: 129062 RVA: 0x0046379C File Offset: 0x0046199C
		// (set) Token: 0x0601F827 RID: 129063 RVA: 0x004637A4 File Offset: 0x004619A4
		public float Acceleration { get; set; }

		// Token: 0x17008FA3 RID: 36771
		// (get) Token: 0x0601F828 RID: 129064 RVA: 0x004637AD File Offset: 0x004619AD
		// (set) Token: 0x0601F829 RID: 129065 RVA: 0x004637B5 File Offset: 0x004619B5
		public IEntityStateT ActiveStateCondition { get; set; }

		// Token: 0x17008FA4 RID: 36772
		// (get) Token: 0x0601F82A RID: 129066 RVA: 0x004637BE File Offset: 0x004619BE
		// (set) Token: 0x0601F82B RID: 129067 RVA: 0x004637C6 File Offset: 0x004619C6
		public int AdsorbLimitedTime { get; set; }

		// Token: 0x17008FA5 RID: 36773
		// (get) Token: 0x0601F82C RID: 129068 RVA: 0x004637CF File Offset: 0x004619CF
		// (set) Token: 0x0601F82D RID: 129069 RVA: 0x004637D7 File Offset: 0x004619D7
		public byte NullMask { get; set; }

		// Token: 0x0601F82E RID: 129070 RVA: 0x004637E0 File Offset: 0x004619E0
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
