using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D7 RID: 29655
	public class IPathLineMoveT
	{
		// Token: 0x1700D9DB RID: 55771
		// (get) Token: 0x06033E04 RID: 212484 RVA: 0x006FEF91 File Offset: 0x006FD191
		// (set) Token: 0x06033E05 RID: 212485 RVA: 0x006FEF99 File Offset: 0x006FD199
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700D9DC RID: 55772
		// (get) Token: 0x06033E06 RID: 212486 RVA: 0x006FEFA2 File Offset: 0x006FD1A2
		// (set) Token: 0x06033E07 RID: 212487 RVA: 0x006FEFAA File Offset: 0x006FD1AA
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700D9DD RID: 55773
		// (get) Token: 0x06033E08 RID: 212488 RVA: 0x006FEFB3 File Offset: 0x006FD1B3
		// (set) Token: 0x06033E09 RID: 212489 RVA: 0x006FEFBB File Offset: 0x006FD1BB
		public bool IsOneWay { get; set; }

		// Token: 0x1700D9DE RID: 55774
		// (get) Token: 0x06033E0A RID: 212490 RVA: 0x006FEFC4 File Offset: 0x006FD1C4
		// (set) Token: 0x06033E0B RID: 212491 RVA: 0x006FEFCC File Offset: 0x006FD1CC
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700D9DF RID: 55775
		// (get) Token: 0x06033E0C RID: 212492 RVA: 0x006FEFD5 File Offset: 0x006FD1D5
		// (set) Token: 0x06033E0D RID: 212493 RVA: 0x006FEFDD File Offset: 0x006FD1DD
		public bool DynamicGravity { get; set; }

		// Token: 0x1700D9E0 RID: 55776
		// (get) Token: 0x06033E0E RID: 212494 RVA: 0x006FEFE6 File Offset: 0x006FD1E6
		// (set) Token: 0x06033E0F RID: 212495 RVA: 0x006FEFEE File Offset: 0x006FD1EE
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700D9E1 RID: 55777
		// (get) Token: 0x06033E10 RID: 212496 RVA: 0x006FEFF7 File Offset: 0x006FD1F7
		// (set) Token: 0x06033E11 RID: 212497 RVA: 0x006FEFFF File Offset: 0x006FD1FF
		public int AutoExitDistance { get; set; }

		// Token: 0x1700D9E2 RID: 55778
		// (get) Token: 0x06033E12 RID: 212498 RVA: 0x006FF008 File Offset: 0x006FD208
		// (set) Token: 0x06033E13 RID: 212499 RVA: 0x006FF010 File Offset: 0x006FD210
		public TPathLineFacingConfigUnion FacingConfig { get; set; }

		// Token: 0x1700D9E3 RID: 55779
		// (get) Token: 0x06033E14 RID: 212500 RVA: 0x006FF019 File Offset: 0x006FD219
		// (set) Token: 0x06033E15 RID: 212501 RVA: 0x006FF021 File Offset: 0x006FD221
		public string SplineMoveConfigDaPath { get; set; }

		// Token: 0x1700D9E4 RID: 55780
		// (get) Token: 0x06033E16 RID: 212502 RVA: 0x006FF02A File Offset: 0x006FD22A
		// (set) Token: 0x06033E17 RID: 212503 RVA: 0x006FF032 File Offset: 0x006FD232
		public bool IsAdaptiveClimbInput { get; set; }

		// Token: 0x1700D9E5 RID: 55781
		// (get) Token: 0x06033E18 RID: 212504 RVA: 0x006FF03B File Offset: 0x006FD23B
		// (set) Token: 0x06033E19 RID: 212505 RVA: 0x006FF043 File Offset: 0x006FD243
		public bool IsDisableStopAnim { get; set; }

		// Token: 0x1700D9E6 RID: 55782
		// (get) Token: 0x06033E1A RID: 212506 RVA: 0x006FF04C File Offset: 0x006FD24C
		// (set) Token: 0x06033E1B RID: 212507 RVA: 0x006FF054 File Offset: 0x006FD254
		public bool IsAllowEarlyExitClimb { get; set; }

		// Token: 0x1700D9E7 RID: 55783
		// (get) Token: 0x06033E1C RID: 212508 RVA: 0x006FF05D File Offset: 0x006FD25D
		// (set) Token: 0x06033E1D RID: 212509 RVA: 0x006FF065 File Offset: 0x006FD265
		public ushort NullMask { get; set; }

		// Token: 0x06033E1E RID: 212510 RVA: 0x006FF070 File Offset: 0x006FD270
		public IPathLineMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.FacingConfig = null;
			this.SplineMoveConfigDaPath = null;
			this.IsAdaptiveClimbInput = false;
			this.IsDisableStopAnim = false;
			this.IsAllowEarlyExitClimb = false;
			this.NullMask = 0;
		}
	}
}
