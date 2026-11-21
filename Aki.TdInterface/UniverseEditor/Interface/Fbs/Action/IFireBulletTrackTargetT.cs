using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3D RID: 28221
	public class IFireBulletTrackTargetT
	{
		// Token: 0x1700CEDD RID: 52957
		// (get) Token: 0x06030BF5 RID: 199669 RVA: 0x0069DE27 File Offset: 0x0069C027
		// (set) Token: 0x06030BF6 RID: 199670 RVA: 0x0069DE2F File Offset: 0x0069C02F
		public EFireBulletType Type { get; set; }

		// Token: 0x1700CEDE RID: 52958
		// (get) Token: 0x06030BF7 RID: 199671 RVA: 0x0069DE38 File Offset: 0x0069C038
		// (set) Token: 0x06030BF8 RID: 199672 RVA: 0x0069DE40 File Offset: 0x0069C040
		public long BulletId { get; set; }

		// Token: 0x1700CEDF RID: 52959
		// (get) Token: 0x06030BF9 RID: 199673 RVA: 0x0069DE49 File Offset: 0x0069C049
		// (set) Token: 0x06030BFA RID: 199674 RVA: 0x0069DE51 File Offset: 0x0069C051
		public TTargetEntityUnion Launcher { get; set; }

		// Token: 0x1700CEE0 RID: 52960
		// (get) Token: 0x06030BFB RID: 199675 RVA: 0x0069DE5A File Offset: 0x0069C05A
		// (set) Token: 0x06030BFC RID: 199676 RVA: 0x0069DE62 File Offset: 0x0069C062
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700CEE1 RID: 52961
		// (get) Token: 0x06030BFD RID: 199677 RVA: 0x0069DE6B File Offset: 0x0069C06B
		// (set) Token: 0x06030BFE RID: 199678 RVA: 0x0069DE73 File Offset: 0x0069C073
		public bool WaitDestroy { get; set; }

		// Token: 0x1700CEE2 RID: 52962
		// (get) Token: 0x06030BFF RID: 199679 RVA: 0x0069DE7C File Offset: 0x0069C07C
		// (set) Token: 0x06030C00 RID: 199680 RVA: 0x0069DE84 File Offset: 0x0069C084
		public byte NullMask { get; set; }

		// Token: 0x06030C01 RID: 199681 RVA: 0x0069DE8D File Offset: 0x0069C08D
		public IFireBulletTrackTargetT()
		{
			this.Type = EFireBulletType.TrackTarget;
			this.BulletId = 0L;
			this.Launcher = null;
			this.Target = null;
			this.WaitDestroy = false;
			this.NullMask = 0;
		}
	}
}
