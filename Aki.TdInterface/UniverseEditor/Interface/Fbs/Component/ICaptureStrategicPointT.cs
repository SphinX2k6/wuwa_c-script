using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005482 RID: 21634
	public class ICaptureStrategicPointT
	{
		// Token: 0x170099F6 RID: 39414
		// (get) Token: 0x06022041 RID: 139329 RVA: 0x004B088B File Offset: 0x004AEA8B
		// (set) Token: 0x06022042 RID: 139330 RVA: 0x004B0893 File Offset: 0x004AEA93
		public EProgressBarControlType Type { get; set; }

		// Token: 0x170099F7 RID: 39415
		// (get) Token: 0x06022043 RID: 139331 RVA: 0x004B089C File Offset: 0x004AEA9C
		// (set) Token: 0x06022044 RID: 139332 RVA: 0x004B08A4 File Offset: 0x004AEAA4
		public int MaxValue { get; set; }

		// Token: 0x170099F8 RID: 39416
		// (get) Token: 0x06022045 RID: 139333 RVA: 0x004B08AD File Offset: 0x004AEAAD
		// (set) Token: 0x06022046 RID: 139334 RVA: 0x004B08B5 File Offset: 0x004AEAB5
		public int InitValue { get; set; }

		// Token: 0x170099F9 RID: 39417
		// (get) Token: 0x06022047 RID: 139335 RVA: 0x004B08BE File Offset: 0x004AEABE
		// (set) Token: 0x06022048 RID: 139336 RVA: 0x004B08C6 File Offset: 0x004AEAC6
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x170099FA RID: 39418
		// (get) Token: 0x06022049 RID: 139337 RVA: 0x004B08CF File Offset: 0x004AEACF
		// (set) Token: 0x0602204A RID: 139338 RVA: 0x004B08D7 File Offset: 0x004AEAD7
		public int IncreaseSpeed { get; set; }

		// Token: 0x170099FB RID: 39419
		// (get) Token: 0x0602204B RID: 139339 RVA: 0x004B08E0 File Offset: 0x004AEAE0
		// (set) Token: 0x0602204C RID: 139340 RVA: 0x004B08E8 File Offset: 0x004AEAE8
		public int DecreaseSpeed { get; set; }

		// Token: 0x170099FC RID: 39420
		// (get) Token: 0x0602204D RID: 139341 RVA: 0x004B08F1 File Offset: 0x004AEAF1
		// (set) Token: 0x0602204E RID: 139342 RVA: 0x004B08F9 File Offset: 0x004AEAF9
		public int UnoccupiedDecreaseSpeed { get; set; }

		// Token: 0x170099FD RID: 39421
		// (get) Token: 0x0602204F RID: 139343 RVA: 0x004B0902 File Offset: 0x004AEB02
		// (set) Token: 0x06022050 RID: 139344 RVA: 0x004B090A File Offset: 0x004AEB0A
		public IStaticEntitiyMatchT EnemyEntitiyMatch { get; set; }

		// Token: 0x170099FE RID: 39422
		// (get) Token: 0x06022051 RID: 139345 RVA: 0x004B0913 File Offset: 0x004AEB13
		// (set) Token: 0x06022052 RID: 139346 RVA: 0x004B091B File Offset: 0x004AEB1B
		public ECaptureStateType CaptureType { get; set; }

		// Token: 0x170099FF RID: 39423
		// (get) Token: 0x06022053 RID: 139347 RVA: 0x004B0924 File Offset: 0x004AEB24
		// (set) Token: 0x06022054 RID: 139348 RVA: 0x004B092C File Offset: 0x004AEB2C
		public byte NullMask { get; set; }

		// Token: 0x06022055 RID: 139349 RVA: 0x004B0938 File Offset: 0x004AEB38
		public ICaptureStrategicPointT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.IncreaseSpeed = 0;
			this.DecreaseSpeed = 0;
			this.UnoccupiedDecreaseSpeed = 0;
			this.EnemyEntitiyMatch = null;
			this.CaptureType = ECaptureStateType.Default;
			this.NullMask = 0;
		}
	}
}
