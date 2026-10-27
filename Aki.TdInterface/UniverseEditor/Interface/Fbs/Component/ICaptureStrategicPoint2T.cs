using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F56 RID: 20310
	public class ICaptureStrategicPoint2T
	{
		// Token: 0x17009292 RID: 37522
		// (get) Token: 0x06020325 RID: 131877 RVA: 0x0047AFE3 File Offset: 0x004791E3
		// (set) Token: 0x06020326 RID: 131878 RVA: 0x0047AFEB File Offset: 0x004791EB
		public EProgressBarControlType Type { get; set; }

		// Token: 0x17009293 RID: 37523
		// (get) Token: 0x06020327 RID: 131879 RVA: 0x0047AFF4 File Offset: 0x004791F4
		// (set) Token: 0x06020328 RID: 131880 RVA: 0x0047AFFC File Offset: 0x004791FC
		public int MaxValue { get; set; }

		// Token: 0x17009294 RID: 37524
		// (get) Token: 0x06020329 RID: 131881 RVA: 0x0047B005 File Offset: 0x00479205
		// (set) Token: 0x0602032A RID: 131882 RVA: 0x0047B00D File Offset: 0x0047920D
		public int InitValue { get; set; }

		// Token: 0x17009295 RID: 37525
		// (get) Token: 0x0602032B RID: 131883 RVA: 0x0047B016 File Offset: 0x00479216
		// (set) Token: 0x0602032C RID: 131884 RVA: 0x0047B01E File Offset: 0x0047921E
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x17009296 RID: 37526
		// (get) Token: 0x0602032D RID: 131885 RVA: 0x0047B027 File Offset: 0x00479227
		// (set) Token: 0x0602032E RID: 131886 RVA: 0x0047B02F File Offset: 0x0047922F
		public IStaticEntitiyMatchT EnemyEntitiyMatch { get; set; }

		// Token: 0x17009297 RID: 37527
		// (get) Token: 0x0602032F RID: 131887 RVA: 0x0047B038 File Offset: 0x00479238
		// (set) Token: 0x06020330 RID: 131888 RVA: 0x0047B040 File Offset: 0x00479240
		public float PlayerInMonsterOutCaptureSpeed { get; set; }

		// Token: 0x17009298 RID: 37528
		// (get) Token: 0x06020331 RID: 131889 RVA: 0x0047B049 File Offset: 0x00479249
		// (set) Token: 0x06020332 RID: 131890 RVA: 0x0047B051 File Offset: 0x00479251
		public float PlayerInMonsterInCaptureSpeed { get; set; }

		// Token: 0x17009299 RID: 37529
		// (get) Token: 0x06020333 RID: 131891 RVA: 0x0047B05A File Offset: 0x0047925A
		// (set) Token: 0x06020334 RID: 131892 RVA: 0x0047B062 File Offset: 0x00479262
		public float PlayerOutMonsterOutCaptureSpeed { get; set; }

		// Token: 0x1700929A RID: 37530
		// (get) Token: 0x06020335 RID: 131893 RVA: 0x0047B06B File Offset: 0x0047926B
		// (set) Token: 0x06020336 RID: 131894 RVA: 0x0047B073 File Offset: 0x00479273
		public float PlayerOutMonsterInCaptureSpeed { get; set; }

		// Token: 0x1700929B RID: 37531
		// (get) Token: 0x06020337 RID: 131895 RVA: 0x0047B07C File Offset: 0x0047927C
		// (set) Token: 0x06020338 RID: 131896 RVA: 0x0047B084 File Offset: 0x00479284
		public byte NullMask { get; set; }

		// Token: 0x06020339 RID: 131897 RVA: 0x0047B090 File Offset: 0x00479290
		public ICaptureStrategicPoint2T()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.EnemyEntitiyMatch = null;
			this.PlayerInMonsterOutCaptureSpeed = 0f;
			this.PlayerInMonsterInCaptureSpeed = 0f;
			this.PlayerOutMonsterOutCaptureSpeed = 0f;
			this.PlayerOutMonsterInCaptureSpeed = 0f;
			this.NullMask = 0;
		}
	}
}
