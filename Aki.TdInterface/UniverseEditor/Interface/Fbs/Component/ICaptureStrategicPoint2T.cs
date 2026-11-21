using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005485 RID: 21637
	public class ICaptureStrategicPoint2T
	{
		// Token: 0x17009A0B RID: 39435
		// (get) Token: 0x06022077 RID: 139383 RVA: 0x004B0FD3 File Offset: 0x004AF1D3
		// (set) Token: 0x06022078 RID: 139384 RVA: 0x004B0FDB File Offset: 0x004AF1DB
		public EProgressBarControlType Type { get; set; }

		// Token: 0x17009A0C RID: 39436
		// (get) Token: 0x06022079 RID: 139385 RVA: 0x004B0FE4 File Offset: 0x004AF1E4
		// (set) Token: 0x0602207A RID: 139386 RVA: 0x004B0FEC File Offset: 0x004AF1EC
		public int MaxValue { get; set; }

		// Token: 0x17009A0D RID: 39437
		// (get) Token: 0x0602207B RID: 139387 RVA: 0x004B0FF5 File Offset: 0x004AF1F5
		// (set) Token: 0x0602207C RID: 139388 RVA: 0x004B0FFD File Offset: 0x004AF1FD
		public int InitValue { get; set; }

		// Token: 0x17009A0E RID: 39438
		// (get) Token: 0x0602207D RID: 139389 RVA: 0x004B1006 File Offset: 0x004AF206
		// (set) Token: 0x0602207E RID: 139390 RVA: 0x004B100E File Offset: 0x004AF20E
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x17009A0F RID: 39439
		// (get) Token: 0x0602207F RID: 139391 RVA: 0x004B1017 File Offset: 0x004AF217
		// (set) Token: 0x06022080 RID: 139392 RVA: 0x004B101F File Offset: 0x004AF21F
		public IStaticEntitiyMatchT EnemyEntitiyMatch { get; set; }

		// Token: 0x17009A10 RID: 39440
		// (get) Token: 0x06022081 RID: 139393 RVA: 0x004B1028 File Offset: 0x004AF228
		// (set) Token: 0x06022082 RID: 139394 RVA: 0x004B1030 File Offset: 0x004AF230
		public float PlayerInMonsterOutCaptureSpeed { get; set; }

		// Token: 0x17009A11 RID: 39441
		// (get) Token: 0x06022083 RID: 139395 RVA: 0x004B1039 File Offset: 0x004AF239
		// (set) Token: 0x06022084 RID: 139396 RVA: 0x004B1041 File Offset: 0x004AF241
		public float PlayerInMonsterInCaptureSpeed { get; set; }

		// Token: 0x17009A12 RID: 39442
		// (get) Token: 0x06022085 RID: 139397 RVA: 0x004B104A File Offset: 0x004AF24A
		// (set) Token: 0x06022086 RID: 139398 RVA: 0x004B1052 File Offset: 0x004AF252
		public float PlayerOutMonsterOutCaptureSpeed { get; set; }

		// Token: 0x17009A13 RID: 39443
		// (get) Token: 0x06022087 RID: 139399 RVA: 0x004B105B File Offset: 0x004AF25B
		// (set) Token: 0x06022088 RID: 139400 RVA: 0x004B1063 File Offset: 0x004AF263
		public float PlayerOutMonsterInCaptureSpeed { get; set; }

		// Token: 0x17009A14 RID: 39444
		// (get) Token: 0x06022089 RID: 139401 RVA: 0x004B106C File Offset: 0x004AF26C
		// (set) Token: 0x0602208A RID: 139402 RVA: 0x004B1074 File Offset: 0x004AF274
		public byte NullMask { get; set; }

		// Token: 0x0602208B RID: 139403 RVA: 0x004B1080 File Offset: 0x004AF280
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
