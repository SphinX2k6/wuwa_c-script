using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A06 RID: 27142
	public class ILiftMoveTypeCustomSpeedT
	{
		// Token: 0x1700C961 RID: 51553
		// (get) Token: 0x0602F7EF RID: 194543 RVA: 0x00677C89 File Offset: 0x00675E89
		// (set) Token: 0x0602F7F0 RID: 194544 RVA: 0x00677C91 File Offset: 0x00675E91
		public ELiftMoveType Type { get; set; }

		// Token: 0x1700C962 RID: 51554
		// (get) Token: 0x0602F7F1 RID: 194545 RVA: 0x00677C9A File Offset: 0x00675E9A
		// (set) Token: 0x0602F7F2 RID: 194546 RVA: 0x00677CA2 File Offset: 0x00675EA2
		public float TotalTime { get; set; }

		// Token: 0x1700C963 RID: 51555
		// (get) Token: 0x0602F7F3 RID: 194547 RVA: 0x00677CAB File Offset: 0x00675EAB
		// (set) Token: 0x0602F7F4 RID: 194548 RVA: 0x00677CB3 File Offset: 0x00675EB3
		public string TimePathCurve { get; set; }

		// Token: 0x0602F7F5 RID: 194549 RVA: 0x00677CBC File Offset: 0x00675EBC
		public ILiftMoveTypeCustomSpeedT()
		{
			this.Type = ELiftMoveType.Default;
			this.TotalTime = 0f;
			this.TimePathCurve = null;
		}
	}
}
