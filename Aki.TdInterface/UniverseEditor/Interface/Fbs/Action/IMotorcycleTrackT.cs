using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007250 RID: 29264
	public class IMotorcycleTrackT
	{
		// Token: 0x1700D688 RID: 54920
		// (get) Token: 0x06032FAE RID: 208814 RVA: 0x006E1F4F File Offset: 0x006E014F
		// (set) Token: 0x06032FAF RID: 208815 RVA: 0x006E1F57 File Offset: 0x006E0157
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700D689 RID: 54921
		// (get) Token: 0x06032FB0 RID: 208816 RVA: 0x006E1F60 File Offset: 0x006E0160
		// (set) Token: 0x06032FB1 RID: 208817 RVA: 0x006E1F68 File Offset: 0x006E0168
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700D68A RID: 54922
		// (get) Token: 0x06032FB2 RID: 208818 RVA: 0x006E1F71 File Offset: 0x006E0171
		// (set) Token: 0x06032FB3 RID: 208819 RVA: 0x006E1F79 File Offset: 0x006E0179
		public bool IsOneWay { get; set; }

		// Token: 0x1700D68B RID: 54923
		// (get) Token: 0x06032FB4 RID: 208820 RVA: 0x006E1F82 File Offset: 0x006E0182
		// (set) Token: 0x06032FB5 RID: 208821 RVA: 0x006E1F8A File Offset: 0x006E018A
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700D68C RID: 54924
		// (get) Token: 0x06032FB6 RID: 208822 RVA: 0x006E1F93 File Offset: 0x006E0193
		// (set) Token: 0x06032FB7 RID: 208823 RVA: 0x006E1F9B File Offset: 0x006E019B
		public bool DynamicGravity { get; set; }

		// Token: 0x1700D68D RID: 54925
		// (get) Token: 0x06032FB8 RID: 208824 RVA: 0x006E1FA4 File Offset: 0x006E01A4
		// (set) Token: 0x06032FB9 RID: 208825 RVA: 0x006E1FAC File Offset: 0x006E01AC
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700D68E RID: 54926
		// (get) Token: 0x06032FBA RID: 208826 RVA: 0x006E1FB5 File Offset: 0x006E01B5
		// (set) Token: 0x06032FBB RID: 208827 RVA: 0x006E1FBD File Offset: 0x006E01BD
		public int AutoExitDistance { get; set; }

		// Token: 0x1700D68F RID: 54927
		// (get) Token: 0x06032FBC RID: 208828 RVA: 0x006E1FC6 File Offset: 0x006E01C6
		// (set) Token: 0x06032FBD RID: 208829 RVA: 0x006E1FCE File Offset: 0x006E01CE
		public bool DisableAutoForward { get; set; }

		// Token: 0x1700D690 RID: 54928
		// (get) Token: 0x06032FBE RID: 208830 RVA: 0x006E1FD7 File Offset: 0x006E01D7
		// (set) Token: 0x06032FBF RID: 208831 RVA: 0x006E1FDF File Offset: 0x006E01DF
		public float LongitudinalAngleLimit { get; set; }

		// Token: 0x1700D691 RID: 54929
		// (get) Token: 0x06032FC0 RID: 208832 RVA: 0x006E1FE8 File Offset: 0x006E01E8
		// (set) Token: 0x06032FC1 RID: 208833 RVA: 0x006E1FF0 File Offset: 0x006E01F0
		public float ForwardAngleLimit { get; set; }

		// Token: 0x1700D692 RID: 54930
		// (get) Token: 0x06032FC2 RID: 208834 RVA: 0x006E1FF9 File Offset: 0x006E01F9
		// (set) Token: 0x06032FC3 RID: 208835 RVA: 0x006E2001 File Offset: 0x006E0201
		public string ForwardAngleLimitCurve { get; set; }

		// Token: 0x1700D693 RID: 54931
		// (get) Token: 0x06032FC4 RID: 208836 RVA: 0x006E200A File Offset: 0x006E020A
		// (set) Token: 0x06032FC5 RID: 208837 RVA: 0x006E2012 File Offset: 0x006E0212
		public string InputCorrectionCurve { get; set; }

		// Token: 0x1700D694 RID: 54932
		// (get) Token: 0x06032FC6 RID: 208838 RVA: 0x006E201B File Offset: 0x006E021B
		// (set) Token: 0x06032FC7 RID: 208839 RVA: 0x006E2023 File Offset: 0x006E0223
		public float InputCorrectionBaseAngle { get; set; }

		// Token: 0x1700D695 RID: 54933
		// (get) Token: 0x06032FC8 RID: 208840 RVA: 0x006E202C File Offset: 0x006E022C
		// (set) Token: 0x06032FC9 RID: 208841 RVA: 0x006E2034 File Offset: 0x006E0234
		public float CorrectionPredictionDistance { get; set; }

		// Token: 0x1700D696 RID: 54934
		// (get) Token: 0x06032FCA RID: 208842 RVA: 0x006E203D File Offset: 0x006E023D
		// (set) Token: 0x06032FCB RID: 208843 RVA: 0x006E2045 File Offset: 0x006E0245
		public string AccelerationCorrectionCurve { get; set; }

		// Token: 0x1700D697 RID: 54935
		// (get) Token: 0x06032FCC RID: 208844 RVA: 0x006E204E File Offset: 0x006E024E
		// (set) Token: 0x06032FCD RID: 208845 RVA: 0x006E2056 File Offset: 0x006E0256
		public IAutomaticDriveT AutomaticDrive { get; set; }

		// Token: 0x1700D698 RID: 54936
		// (get) Token: 0x06032FCE RID: 208846 RVA: 0x006E205F File Offset: 0x006E025F
		// (set) Token: 0x06032FCF RID: 208847 RVA: 0x006E2067 File Offset: 0x006E0267
		public ushort NullMask { get; set; }

		// Token: 0x06032FD0 RID: 208848 RVA: 0x006E2070 File Offset: 0x006E0270
		public IMotorcycleTrackT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.DisableAutoForward = false;
			this.LongitudinalAngleLimit = 0f;
			this.ForwardAngleLimit = 0f;
			this.ForwardAngleLimitCurve = null;
			this.InputCorrectionCurve = null;
			this.InputCorrectionBaseAngle = 0f;
			this.CorrectionPredictionDistance = 0f;
			this.AccelerationCorrectionCurve = null;
			this.AutomaticDrive = null;
			this.NullMask = 0;
		}
	}
}
