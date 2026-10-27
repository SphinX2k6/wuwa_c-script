using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418B RID: 16779
	public class ITakePhoto2TaggedActorTargetT
	{
		// Token: 0x170076F6 RID: 30454
		// (get) Token: 0x06018AE1 RID: 101089 RVA: 0x0038E0B2 File Offset: 0x0038C2B2
		// (set) Token: 0x06018AE2 RID: 101090 RVA: 0x0038E0BA File Offset: 0x0038C2BA
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x170076F7 RID: 30455
		// (get) Token: 0x06018AE3 RID: 101091 RVA: 0x0038E0C3 File Offset: 0x0038C2C3
		// (set) Token: 0x06018AE4 RID: 101092 RVA: 0x0038E0CB File Offset: 0x0038C2CB
		public bool IsOptionalTarget { get; set; }

		// Token: 0x170076F8 RID: 30456
		// (get) Token: 0x06018AE5 RID: 101093 RVA: 0x0038E0D4 File Offset: 0x0038C2D4
		// (set) Token: 0x06018AE6 RID: 101094 RVA: 0x0038E0DC File Offset: 0x0038C2DC
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x170076F9 RID: 30457
		// (get) Token: 0x06018AE7 RID: 101095 RVA: 0x0038E0E5 File Offset: 0x0038C2E5
		// (set) Token: 0x06018AE8 RID: 101096 RVA: 0x0038E0ED File Offset: 0x0038C2ED
		public string Tag { get; set; }

		// Token: 0x170076FA RID: 30458
		// (get) Token: 0x06018AE9 RID: 101097 RVA: 0x0038E0F6 File Offset: 0x0038C2F6
		// (set) Token: 0x06018AEA RID: 101098 RVA: 0x0038E0FE File Offset: 0x0038C2FE
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x170076FB RID: 30459
		// (get) Token: 0x06018AEB RID: 101099 RVA: 0x0038E107 File Offset: 0x0038C307
		// (set) Token: 0x06018AEC RID: 101100 RVA: 0x0038E10F File Offset: 0x0038C30F
		public int TargetSatisfiedCount { get; set; }

		// Token: 0x170076FC RID: 30460
		// (get) Token: 0x06018AED RID: 101101 RVA: 0x0038E118 File Offset: 0x0038C318
		// (set) Token: 0x06018AEE RID: 101102 RVA: 0x0038E120 File Offset: 0x0038C320
		public byte NullMask { get; set; }

		// Token: 0x06018AEF RID: 101103 RVA: 0x0038E129 File Offset: 0x0038C329
		public ITakePhoto2TaggedActorTargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.Tag = null;
			this.TargetPosCondition = null;
			this.TargetSatisfiedCount = 0;
			this.NullMask = 0;
		}
	}
}
