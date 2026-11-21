using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200719C RID: 29084
	public class IMechaAirPassageMoveT
	{
		// Token: 0x1700D4F4 RID: 54516
		// (get) Token: 0x06032929 RID: 207145 RVA: 0x006D57AC File Offset: 0x006D39AC
		// (set) Token: 0x0603292A RID: 207146 RVA: 0x006D57B4 File Offset: 0x006D39B4
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700D4F5 RID: 54517
		// (get) Token: 0x0603292B RID: 207147 RVA: 0x006D57BD File Offset: 0x006D39BD
		// (set) Token: 0x0603292C RID: 207148 RVA: 0x006D57C5 File Offset: 0x006D39C5
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700D4F6 RID: 54518
		// (get) Token: 0x0603292D RID: 207149 RVA: 0x006D57CE File Offset: 0x006D39CE
		// (set) Token: 0x0603292E RID: 207150 RVA: 0x006D57D6 File Offset: 0x006D39D6
		public bool IsOneWay { get; set; }

		// Token: 0x1700D4F7 RID: 54519
		// (get) Token: 0x0603292F RID: 207151 RVA: 0x006D57DF File Offset: 0x006D39DF
		// (set) Token: 0x06032930 RID: 207152 RVA: 0x006D57E7 File Offset: 0x006D39E7
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700D4F8 RID: 54520
		// (get) Token: 0x06032931 RID: 207153 RVA: 0x006D57F0 File Offset: 0x006D39F0
		// (set) Token: 0x06032932 RID: 207154 RVA: 0x006D57F8 File Offset: 0x006D39F8
		public bool DynamicGravity { get; set; }

		// Token: 0x1700D4F9 RID: 54521
		// (get) Token: 0x06032933 RID: 207155 RVA: 0x006D5801 File Offset: 0x006D3A01
		// (set) Token: 0x06032934 RID: 207156 RVA: 0x006D5809 File Offset: 0x006D3A09
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700D4FA RID: 54522
		// (get) Token: 0x06032935 RID: 207157 RVA: 0x006D5812 File Offset: 0x006D3A12
		// (set) Token: 0x06032936 RID: 207158 RVA: 0x006D581A File Offset: 0x006D3A1A
		public int AutoExitDistance { get; set; }

		// Token: 0x1700D4FB RID: 54523
		// (get) Token: 0x06032937 RID: 207159 RVA: 0x006D5823 File Offset: 0x006D3A23
		// (set) Token: 0x06032938 RID: 207160 RVA: 0x006D582B File Offset: 0x006D3A2B
		public float ForwardAngleLimit { get; set; }

		// Token: 0x1700D4FC RID: 54524
		// (get) Token: 0x06032939 RID: 207161 RVA: 0x006D5834 File Offset: 0x006D3A34
		// (set) Token: 0x0603293A RID: 207162 RVA: 0x006D583C File Offset: 0x006D3A3C
		public string ForwardAngleLimitCurve { get; set; }

		// Token: 0x1700D4FD RID: 54525
		// (get) Token: 0x0603293B RID: 207163 RVA: 0x006D5845 File Offset: 0x006D3A45
		// (set) Token: 0x0603293C RID: 207164 RVA: 0x006D584D File Offset: 0x006D3A4D
		public string InputCorrectionCurve { get; set; }

		// Token: 0x1700D4FE RID: 54526
		// (get) Token: 0x0603293D RID: 207165 RVA: 0x006D5856 File Offset: 0x006D3A56
		// (set) Token: 0x0603293E RID: 207166 RVA: 0x006D585E File Offset: 0x006D3A5E
		public float InputCorrectionBaseAngle { get; set; }

		// Token: 0x1700D4FF RID: 54527
		// (get) Token: 0x0603293F RID: 207167 RVA: 0x006D5867 File Offset: 0x006D3A67
		// (set) Token: 0x06032940 RID: 207168 RVA: 0x006D586F File Offset: 0x006D3A6F
		public float CorrectionPredictionDistance { get; set; }

		// Token: 0x1700D500 RID: 54528
		// (get) Token: 0x06032941 RID: 207169 RVA: 0x006D5878 File Offset: 0x006D3A78
		// (set) Token: 0x06032942 RID: 207170 RVA: 0x006D5880 File Offset: 0x006D3A80
		public byte NullMask { get; set; }

		// Token: 0x06032943 RID: 207171 RVA: 0x006D588C File Offset: 0x006D3A8C
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
