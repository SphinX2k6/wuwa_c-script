using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9C RID: 27292
	public class ICloseMotorcycleTrackMoveT
	{
		// Token: 0x1700C874 RID: 51316
		// (get) Token: 0x0602ED6D RID: 191853 RVA: 0x00661F8A File Offset: 0x0066018A
		// (set) Token: 0x0602ED6E RID: 191854 RVA: 0x00661F92 File Offset: 0x00660192
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700C875 RID: 51317
		// (get) Token: 0x0602ED6F RID: 191855 RVA: 0x00661F9B File Offset: 0x0066019B
		// (set) Token: 0x0602ED70 RID: 191856 RVA: 0x00661FA3 File Offset: 0x006601A3
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700C876 RID: 51318
		// (get) Token: 0x0602ED71 RID: 191857 RVA: 0x00661FAC File Offset: 0x006601AC
		// (set) Token: 0x0602ED72 RID: 191858 RVA: 0x00661FB4 File Offset: 0x006601B4
		public byte NullMask { get; set; }

		// Token: 0x0602ED73 RID: 191859 RVA: 0x00661FBD File Offset: 0x006601BD
		public ICloseMotorcycleTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
