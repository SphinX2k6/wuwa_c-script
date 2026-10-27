using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737D RID: 29565
	public class ITeleportDungeonT
	{
		// Token: 0x1700E072 RID: 57458
		// (get) Token: 0x06035A99 RID: 219801 RVA: 0x0074E9BD File Offset: 0x0074CBBD
		// (set) Token: 0x06035A9A RID: 219802 RVA: 0x0074E9C5 File Offset: 0x0074CBC5
		public int DungeonId { get; set; }

		// Token: 0x1700E073 RID: 57459
		// (get) Token: 0x06035A9B RID: 219803 RVA: 0x0074E9CE File Offset: 0x0074CBCE
		// (set) Token: 0x06035A9C RID: 219804 RVA: 0x0074E9D6 File Offset: 0x0074CBD6
		public bool IsRegroup { get; set; }

		// Token: 0x1700E074 RID: 57460
		// (get) Token: 0x06035A9D RID: 219805 RVA: 0x0074E9DF File Offset: 0x0074CBDF
		// (set) Token: 0x06035A9E RID: 219806 RVA: 0x0074E9E7 File Offset: 0x0074CBE7
		public int LocationEntityId { get; set; }

		// Token: 0x1700E075 RID: 57461
		// (get) Token: 0x06035A9F RID: 219807 RVA: 0x0074E9F0 File Offset: 0x0074CBF0
		// (set) Token: 0x06035AA0 RID: 219808 RVA: 0x0074E9F8 File Offset: 0x0074CBF8
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x1700E076 RID: 57462
		// (get) Token: 0x06035AA1 RID: 219809 RVA: 0x0074EA01 File Offset: 0x0074CC01
		// (set) Token: 0x06035AA2 RID: 219810 RVA: 0x0074EA09 File Offset: 0x0074CC09
		public bool IsNeedSecondaryConfirmation { get; set; }

		// Token: 0x1700E077 RID: 57463
		// (get) Token: 0x06035AA3 RID: 219811 RVA: 0x0074EA12 File Offset: 0x0074CC12
		// (set) Token: 0x06035AA4 RID: 219812 RVA: 0x0074EA1A File Offset: 0x0074CC1A
		public bool UseLocationEntityGravity { get; set; }

		// Token: 0x1700E078 RID: 57464
		// (get) Token: 0x06035AA5 RID: 219813 RVA: 0x0074EA23 File Offset: 0x0074CC23
		// (set) Token: 0x06035AA6 RID: 219814 RVA: 0x0074EA2B File Offset: 0x0074CC2B
		public bool ContinueSave { get; set; }

		// Token: 0x1700E079 RID: 57465
		// (get) Token: 0x06035AA7 RID: 219815 RVA: 0x0074EA34 File Offset: 0x0074CC34
		// (set) Token: 0x06035AA8 RID: 219816 RVA: 0x0074EA3C File Offset: 0x0074CC3C
		public bool IsBanMapSound { get; set; }

		// Token: 0x1700E07A RID: 57466
		// (get) Token: 0x06035AA9 RID: 219817 RVA: 0x0074EA45 File Offset: 0x0074CC45
		// (set) Token: 0x06035AAA RID: 219818 RVA: 0x0074EA4D File Offset: 0x0074CC4D
		public byte NullMask { get; set; }

		// Token: 0x06035AAB RID: 219819 RVA: 0x0074EA58 File Offset: 0x0074CC58
		public ITeleportDungeonT()
		{
			this.DungeonId = 0;
			this.IsRegroup = false;
			this.LocationEntityId = 0;
			this.TransitionOption = null;
			this.IsNeedSecondaryConfirmation = false;
			this.UseLocationEntityGravity = false;
			this.ContinueSave = false;
			this.IsBanMapSound = false;
			this.NullMask = 0;
		}
	}
}
