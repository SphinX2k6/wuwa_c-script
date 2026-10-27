using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006422 RID: 25634
	public class ICloseMotorcycleTrackMoveT
	{
		// Token: 0x1700BEE2 RID: 48866
		// (get) Token: 0x0602C5BF RID: 181695 RVA: 0x00616476 File Offset: 0x00614676
		// (set) Token: 0x0602C5C0 RID: 181696 RVA: 0x0061647E File Offset: 0x0061467E
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700BEE3 RID: 48867
		// (get) Token: 0x0602C5C1 RID: 181697 RVA: 0x00616487 File Offset: 0x00614687
		// (set) Token: 0x0602C5C2 RID: 181698 RVA: 0x0061648F File Offset: 0x0061468F
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700BEE4 RID: 48868
		// (get) Token: 0x0602C5C3 RID: 181699 RVA: 0x00616498 File Offset: 0x00614698
		// (set) Token: 0x0602C5C4 RID: 181700 RVA: 0x006164A0 File Offset: 0x006146A0
		public byte NullMask { get; set; }

		// Token: 0x0602C5C5 RID: 181701 RVA: 0x006164A9 File Offset: 0x006146A9
		public ICloseMotorcycleTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
