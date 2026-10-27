using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C8 RID: 25544
	public class IClientFollowShooterPlayAnimationT
	{
		// Token: 0x1700BE53 RID: 48723
		// (get) Token: 0x0602C2FB RID: 180987 RVA: 0x006110CB File Offset: 0x0060F2CB
		// (set) Token: 0x0602C2FC RID: 180988 RVA: 0x006110D3 File Offset: 0x0060F2D3
		public EClientFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x1700BE54 RID: 48724
		// (get) Token: 0x0602C2FD RID: 180989 RVA: 0x006110DC File Offset: 0x0060F2DC
		// (set) Token: 0x0602C2FE RID: 180990 RVA: 0x006110E4 File Offset: 0x0060F2E4
		public string Montage { get; set; }

		// Token: 0x0602C2FF RID: 180991 RVA: 0x006110ED File Offset: 0x0060F2ED
		public IClientFollowShooterPlayAnimationT()
		{
			this.Type = EClientFollowShooterLeisureInteractType.ResetToPlayer;
			this.Montage = null;
		}
	}
}
