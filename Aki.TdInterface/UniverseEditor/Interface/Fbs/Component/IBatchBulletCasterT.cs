using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF6 RID: 20214
	public class IBatchBulletCasterT
	{
		// Token: 0x17009168 RID: 37224
		// (get) Token: 0x0601FEBE RID: 130750 RVA: 0x0047168C File Offset: 0x0046F88C
		// (set) Token: 0x0601FEBF RID: 130751 RVA: 0x00471694 File Offset: 0x0046F894
		public int BulletIndex { get; set; }

		// Token: 0x17009169 RID: 37225
		// (get) Token: 0x0601FEC0 RID: 130752 RVA: 0x0047169D File Offset: 0x0046F89D
		// (set) Token: 0x0601FEC1 RID: 130753 RVA: 0x004716A5 File Offset: 0x0046F8A5
		public long BulletType { get; set; }

		// Token: 0x1700916A RID: 37226
		// (get) Token: 0x0601FEC2 RID: 130754 RVA: 0x004716AE File Offset: 0x0046F8AE
		// (set) Token: 0x0601FEC3 RID: 130755 RVA: 0x004716B6 File Offset: 0x0046F8B6
		public int DelayTime { get; set; }

		// Token: 0x1700916B RID: 37227
		// (get) Token: 0x0601FEC4 RID: 130756 RVA: 0x004716BF File Offset: 0x0046F8BF
		// (set) Token: 0x0601FEC5 RID: 130757 RVA: 0x004716C7 File Offset: 0x0046F8C7
		public int FlyTime { get; set; }

		// Token: 0x1700916C RID: 37228
		// (get) Token: 0x0601FEC6 RID: 130758 RVA: 0x004716D0 File Offset: 0x0046F8D0
		// (set) Token: 0x0601FEC7 RID: 130759 RVA: 0x004716D8 File Offset: 0x0046F8D8
		public int FlyDistance { get; set; }

		// Token: 0x1700916D RID: 37229
		// (get) Token: 0x0601FEC8 RID: 130760 RVA: 0x004716E1 File Offset: 0x0046F8E1
		// (set) Token: 0x0601FEC9 RID: 130761 RVA: 0x004716E9 File Offset: 0x0046F8E9
		public int WarningTime { get; set; }

		// Token: 0x1700916E RID: 37230
		// (get) Token: 0x0601FECA RID: 130762 RVA: 0x004716F2 File Offset: 0x0046F8F2
		// (set) Token: 0x0601FECB RID: 130763 RVA: 0x004716FA File Offset: 0x0046F8FA
		public int WarningWidth { get; set; }

		// Token: 0x1700916F RID: 37231
		// (get) Token: 0x0601FECC RID: 130764 RVA: 0x00471703 File Offset: 0x0046F903
		// (set) Token: 0x0601FECD RID: 130765 RVA: 0x0047170B File Offset: 0x0046F90B
		public byte NullMask { get; set; }

		// Token: 0x0601FECE RID: 130766 RVA: 0x00471714 File Offset: 0x0046F914
		public IBatchBulletCasterT()
		{
			this.BulletIndex = 0;
			this.BulletType = 0L;
			this.DelayTime = 0;
			this.FlyTime = 0;
			this.FlyDistance = 0;
			this.WarningTime = 0;
			this.WarningWidth = 0;
			this.NullMask = 0;
		}
	}
}
