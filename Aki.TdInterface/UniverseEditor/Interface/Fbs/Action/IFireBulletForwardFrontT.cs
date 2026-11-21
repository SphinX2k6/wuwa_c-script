using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E37 RID: 28215
	public class IFireBulletForwardFrontT
	{
		// Token: 0x1700CECA RID: 52938
		// (get) Token: 0x06030BA2 RID: 199586 RVA: 0x0069CF9D File Offset: 0x0069B19D
		// (set) Token: 0x06030BA3 RID: 199587 RVA: 0x0069CFA5 File Offset: 0x0069B1A5
		public EFireBulletType Type { get; set; }

		// Token: 0x1700CECB RID: 52939
		// (get) Token: 0x06030BA4 RID: 199588 RVA: 0x0069CFAE File Offset: 0x0069B1AE
		// (set) Token: 0x06030BA5 RID: 199589 RVA: 0x0069CFB6 File Offset: 0x0069B1B6
		public long BulletId { get; set; }

		// Token: 0x1700CECC RID: 52940
		// (get) Token: 0x06030BA6 RID: 199590 RVA: 0x0069CFBF File Offset: 0x0069B1BF
		// (set) Token: 0x06030BA7 RID: 199591 RVA: 0x0069CFC7 File Offset: 0x0069B1C7
		public TTargetEntityUnion Launcher { get; set; }

		// Token: 0x06030BA8 RID: 199592 RVA: 0x0069CFD0 File Offset: 0x0069B1D0
		public IFireBulletForwardFrontT()
		{
			this.Type = EFireBulletType.TrackTarget;
			this.BulletId = 0L;
			this.Launcher = null;
		}
	}
}
