using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7A RID: 27258
	public class IMechaAirPassageMoveT
	{
		// Token: 0x1700CA49 RID: 51785
		// (get) Token: 0x0602FC03 RID: 195587 RVA: 0x0067F6EC File Offset: 0x0067D8EC
		// (set) Token: 0x0602FC04 RID: 195588 RVA: 0x0067F6F4 File Offset: 0x0067D8F4
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700CA4A RID: 51786
		// (get) Token: 0x0602FC05 RID: 195589 RVA: 0x0067F6FD File Offset: 0x0067D8FD
		// (set) Token: 0x0602FC06 RID: 195590 RVA: 0x0067F705 File Offset: 0x0067D905
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700CA4B RID: 51787
		// (get) Token: 0x0602FC07 RID: 195591 RVA: 0x0067F70E File Offset: 0x0067D90E
		// (set) Token: 0x0602FC08 RID: 195592 RVA: 0x0067F716 File Offset: 0x0067D916
		public bool IsOneWay { get; set; }

		// Token: 0x1700CA4C RID: 51788
		// (get) Token: 0x0602FC09 RID: 195593 RVA: 0x0067F71F File Offset: 0x0067D91F
		// (set) Token: 0x0602FC0A RID: 195594 RVA: 0x0067F727 File Offset: 0x0067D927
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700CA4D RID: 51789
		// (get) Token: 0x0602FC0B RID: 195595 RVA: 0x0067F730 File Offset: 0x0067D930
		// (set) Token: 0x0602FC0C RID: 195596 RVA: 0x0067F738 File Offset: 0x0067D938
		public bool DynamicGravity { get; set; }

		// Token: 0x1700CA4E RID: 51790
		// (get) Token: 0x0602FC0D RID: 195597 RVA: 0x0067F741 File Offset: 0x0067D941
		// (set) Token: 0x0602FC0E RID: 195598 RVA: 0x0067F749 File Offset: 0x0067D949
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700CA4F RID: 51791
		// (get) Token: 0x0602FC0F RID: 195599 RVA: 0x0067F752 File Offset: 0x0067D952
		// (set) Token: 0x0602FC10 RID: 195600 RVA: 0x0067F75A File Offset: 0x0067D95A
		public int AutoExitDistance { get; set; }

		// Token: 0x1700CA50 RID: 51792
		// (get) Token: 0x0602FC11 RID: 195601 RVA: 0x0067F763 File Offset: 0x0067D963
		// (set) Token: 0x0602FC12 RID: 195602 RVA: 0x0067F76B File Offset: 0x0067D96B
		public float ForwardAngleLimit { get; set; }

		// Token: 0x1700CA51 RID: 51793
		// (get) Token: 0x0602FC13 RID: 195603 RVA: 0x0067F774 File Offset: 0x0067D974
		// (set) Token: 0x0602FC14 RID: 195604 RVA: 0x0067F77C File Offset: 0x0067D97C
		public string ForwardAngleLimitCurve { get; set; }

		// Token: 0x1700CA52 RID: 51794
		// (get) Token: 0x0602FC15 RID: 195605 RVA: 0x0067F785 File Offset: 0x0067D985
		// (set) Token: 0x0602FC16 RID: 195606 RVA: 0x0067F78D File Offset: 0x0067D98D
		public string InputCorrectionCurve { get; set; }

		// Token: 0x1700CA53 RID: 51795
		// (get) Token: 0x0602FC17 RID: 195607 RVA: 0x0067F796 File Offset: 0x0067D996
		// (set) Token: 0x0602FC18 RID: 195608 RVA: 0x0067F79E File Offset: 0x0067D99E
		public float InputCorrectionBaseAngle { get; set; }

		// Token: 0x1700CA54 RID: 51796
		// (get) Token: 0x0602FC19 RID: 195609 RVA: 0x0067F7A7 File Offset: 0x0067D9A7
		// (set) Token: 0x0602FC1A RID: 195610 RVA: 0x0067F7AF File Offset: 0x0067D9AF
		public float CorrectionPredictionDistance { get; set; }

		// Token: 0x1700CA55 RID: 51797
		// (get) Token: 0x0602FC1B RID: 195611 RVA: 0x0067F7B8 File Offset: 0x0067D9B8
		// (set) Token: 0x0602FC1C RID: 195612 RVA: 0x0067F7C0 File Offset: 0x0067D9C0
		public byte NullMask { get; set; }

		// Token: 0x0602FC1D RID: 195613 RVA: 0x0067F7CC File Offset: 0x0067D9CC
		public IMechaAirPassageMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.ForwardAngleLimit = 0f;
			this.ForwardAngleLimitCurve = null;
			this.InputCorrectionCurve = null;
			this.InputCorrectionBaseAngle = 0f;
			this.CorrectionPredictionDistance = 0f;
			this.NullMask = 0;
		}
	}
}
