using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA2 RID: 27298
	public class ICloseRacingTrackMoveT
	{
		// Token: 0x1700C882 RID: 51330
		// (get) Token: 0x0602EDA1 RID: 191905 RVA: 0x006624CA File Offset: 0x006606CA
		// (set) Token: 0x0602EDA2 RID: 191906 RVA: 0x006624D2 File Offset: 0x006606D2
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700C883 RID: 51331
		// (get) Token: 0x0602EDA3 RID: 191907 RVA: 0x006624DB File Offset: 0x006606DB
		// (set) Token: 0x0602EDA4 RID: 191908 RVA: 0x006624E3 File Offset: 0x006606E3
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700C884 RID: 51332
		// (get) Token: 0x0602EDA5 RID: 191909 RVA: 0x006624EC File Offset: 0x006606EC
		// (set) Token: 0x0602EDA6 RID: 191910 RVA: 0x006624F4 File Offset: 0x006606F4
		public byte NullMask { get; set; }

		// Token: 0x0602EDA7 RID: 191911 RVA: 0x006624FD File Offset: 0x006606FD
		public ICloseRacingTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
