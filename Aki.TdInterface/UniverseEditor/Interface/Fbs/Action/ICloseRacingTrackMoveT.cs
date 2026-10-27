using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006428 RID: 25640
	public class ICloseRacingTrackMoveT
	{
		// Token: 0x1700BEF0 RID: 48880
		// (get) Token: 0x0602C5F3 RID: 181747 RVA: 0x006169B6 File Offset: 0x00614BB6
		// (set) Token: 0x0602C5F4 RID: 181748 RVA: 0x006169BE File Offset: 0x00614BBE
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700BEF1 RID: 48881
		// (get) Token: 0x0602C5F5 RID: 181749 RVA: 0x006169C7 File Offset: 0x00614BC7
		// (set) Token: 0x0602C5F6 RID: 181750 RVA: 0x006169CF File Offset: 0x00614BCF
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700BEF2 RID: 48882
		// (get) Token: 0x0602C5F7 RID: 181751 RVA: 0x006169D8 File Offset: 0x00614BD8
		// (set) Token: 0x0602C5F8 RID: 181752 RVA: 0x006169E0 File Offset: 0x00614BE0
		public byte NullMask { get; set; }

		// Token: 0x0602C5F9 RID: 181753 RVA: 0x006169E9 File Offset: 0x00614BE9
		public ICloseRacingTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
