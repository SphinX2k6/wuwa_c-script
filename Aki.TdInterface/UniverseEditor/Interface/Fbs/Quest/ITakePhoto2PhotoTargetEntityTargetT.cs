using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004182 RID: 16770
	public class ITakePhoto2PhotoTargetEntityTargetT
	{
		// Token: 0x170076E2 RID: 30434
		// (get) Token: 0x06018A91 RID: 101009 RVA: 0x0038D7A3 File Offset: 0x0038B9A3
		// (set) Token: 0x06018A92 RID: 101010 RVA: 0x0038D7AB File Offset: 0x0038B9AB
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x170076E3 RID: 30435
		// (get) Token: 0x06018A93 RID: 101011 RVA: 0x0038D7B4 File Offset: 0x0038B9B4
		// (set) Token: 0x06018A94 RID: 101012 RVA: 0x0038D7BC File Offset: 0x0038B9BC
		public bool IsOptionalTarget { get; set; }

		// Token: 0x170076E4 RID: 30436
		// (get) Token: 0x06018A95 RID: 101013 RVA: 0x0038D7C5 File Offset: 0x0038B9C5
		// (set) Token: 0x06018A96 RID: 101014 RVA: 0x0038D7CD File Offset: 0x0038B9CD
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x170076E5 RID: 30437
		// (get) Token: 0x06018A97 RID: 101015 RVA: 0x0038D7D6 File Offset: 0x0038B9D6
		// (set) Token: 0x06018A98 RID: 101016 RVA: 0x0038D7DE File Offset: 0x0038B9DE
		public int EntityId { get; set; }

		// Token: 0x170076E6 RID: 30438
		// (get) Token: 0x06018A99 RID: 101017 RVA: 0x0038D7E7 File Offset: 0x0038B9E7
		// (set) Token: 0x06018A9A RID: 101018 RVA: 0x0038D7EF File Offset: 0x0038B9EF
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x170076E7 RID: 30439
		// (get) Token: 0x06018A9B RID: 101019 RVA: 0x0038D7F8 File Offset: 0x0038B9F8
		// (set) Token: 0x06018A9C RID: 101020 RVA: 0x0038D800 File Offset: 0x0038BA00
		public byte NullMask { get; set; }

		// Token: 0x06018A9D RID: 101021 RVA: 0x0038D809 File Offset: 0x0038BA09
		public ITakePhoto2PhotoTargetEntityTargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.EntityId = 0;
			this.TargetPosCondition = null;
			this.NullMask = 0;
		}
	}
}
