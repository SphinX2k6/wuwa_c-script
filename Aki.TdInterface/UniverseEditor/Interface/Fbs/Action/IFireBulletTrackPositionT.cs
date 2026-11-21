using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3A RID: 28218
	public class IFireBulletTrackPositionT
	{
		// Token: 0x1700CED2 RID: 52946
		// (get) Token: 0x06030BC5 RID: 199621 RVA: 0x0069D52F File Offset: 0x0069B72F
		// (set) Token: 0x06030BC6 RID: 199622 RVA: 0x0069D537 File Offset: 0x0069B737
		public EFireBulletType Type { get; set; }

		// Token: 0x1700CED3 RID: 52947
		// (get) Token: 0x06030BC7 RID: 199623 RVA: 0x0069D540 File Offset: 0x0069B740
		// (set) Token: 0x06030BC8 RID: 199624 RVA: 0x0069D548 File Offset: 0x0069B748
		public long BulletId { get; set; }

		// Token: 0x1700CED4 RID: 52948
		// (get) Token: 0x06030BC9 RID: 199625 RVA: 0x0069D551 File Offset: 0x0069B751
		// (set) Token: 0x06030BCA RID: 199626 RVA: 0x0069D559 File Offset: 0x0069B759
		public TTargetEntityUnion Launcher { get; set; }

		// Token: 0x1700CED5 RID: 52949
		// (get) Token: 0x06030BCB RID: 199627 RVA: 0x0069D562 File Offset: 0x0069B762
		// (set) Token: 0x06030BCC RID: 199628 RVA: 0x0069D56A File Offset: 0x0069B76A
		public int PositionEntityId { get; set; }

		// Token: 0x06030BCD RID: 199629 RVA: 0x0069D573 File Offset: 0x0069B773
		public IFireBulletTrackPositionT()
		{
			this.Type = EFireBulletType.TrackTarget;
			this.BulletId = 0L;
			this.Launcher = null;
			this.PositionEntityId = 0;
		}
	}
}
