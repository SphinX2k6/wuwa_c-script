using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006902 RID: 26882
	public class ICameraOffsetInMovementDirectionT
	{
		// Token: 0x1700C5D6 RID: 50646
		// (get) Token: 0x0602E0D2 RID: 188626 RVA: 0x0064B38F File Offset: 0x0064958F
		// (set) Token: 0x0602E0D3 RID: 188627 RVA: 0x0064B397 File Offset: 0x00649597
		public float MinInterpolationSpeed { get; set; }

		// Token: 0x1700C5D7 RID: 50647
		// (get) Token: 0x0602E0D4 RID: 188628 RVA: 0x0064B3A0 File Offset: 0x006495A0
		// (set) Token: 0x0602E0D5 RID: 188629 RVA: 0x0064B3A8 File Offset: 0x006495A8
		public float MaxInterpolationSpeed { get; set; }

		// Token: 0x1700C5D8 RID: 50648
		// (get) Token: 0x0602E0D6 RID: 188630 RVA: 0x0064B3B1 File Offset: 0x006495B1
		// (set) Token: 0x0602E0D7 RID: 188631 RVA: 0x0064B3B9 File Offset: 0x006495B9
		public float OffsetDistance1 { get; set; }

		// Token: 0x1700C5D9 RID: 50649
		// (get) Token: 0x0602E0D8 RID: 188632 RVA: 0x0064B3C2 File Offset: 0x006495C2
		// (set) Token: 0x0602E0D9 RID: 188633 RVA: 0x0064B3CA File Offset: 0x006495CA
		public float OffsetDistance2 { get; set; }

		// Token: 0x1700C5DA RID: 50650
		// (get) Token: 0x0602E0DA RID: 188634 RVA: 0x0064B3D3 File Offset: 0x006495D3
		// (set) Token: 0x0602E0DB RID: 188635 RVA: 0x0064B3DB File Offset: 0x006495DB
		public IBaseCurveT OffsetCurve { get; set; }

		// Token: 0x1700C5DB RID: 50651
		// (get) Token: 0x0602E0DC RID: 188636 RVA: 0x0064B3E4 File Offset: 0x006495E4
		// (set) Token: 0x0602E0DD RID: 188637 RVA: 0x0064B3EC File Offset: 0x006495EC
		public int CenteringWaitTime { get; set; }

		// Token: 0x1700C5DC RID: 50652
		// (get) Token: 0x0602E0DE RID: 188638 RVA: 0x0064B3F5 File Offset: 0x006495F5
		// (set) Token: 0x0602E0DF RID: 188639 RVA: 0x0064B3FD File Offset: 0x006495FD
		public int StartupWaitTime { get; set; }

		// Token: 0x1700C5DD RID: 50653
		// (get) Token: 0x0602E0E0 RID: 188640 RVA: 0x0064B406 File Offset: 0x00649606
		// (set) Token: 0x0602E0E1 RID: 188641 RVA: 0x0064B40E File Offset: 0x0064960E
		public byte NullMask { get; set; }

		// Token: 0x0602E0E2 RID: 188642 RVA: 0x0064B418 File Offset: 0x00649618
		public ICameraOffsetInMovementDirectionT()
		{
			this.MinInterpolationSpeed = 0f;
			this.MaxInterpolationSpeed = 0f;
			this.OffsetDistance1 = 0f;
			this.OffsetDistance2 = 0f;
			this.OffsetCurve = null;
			this.CenteringWaitTime = 0;
			this.StartupWaitTime = 0;
			this.NullMask = 0;
		}
	}
}
