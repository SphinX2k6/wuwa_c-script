using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B19 RID: 27417
	public class IMotorcycleTrackT
	{
		// Token: 0x1700CBB9 RID: 52153
		// (get) Token: 0x060301DA RID: 197082 RVA: 0x0068A897 File Offset: 0x00688A97
		// (set) Token: 0x060301DB RID: 197083 RVA: 0x0068A89F File Offset: 0x00688A9F
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700CBBA RID: 52154
		// (get) Token: 0x060301DC RID: 197084 RVA: 0x0068A8A8 File Offset: 0x00688AA8
		// (set) Token: 0x060301DD RID: 197085 RVA: 0x0068A8B0 File Offset: 0x00688AB0
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700CBBB RID: 52155
		// (get) Token: 0x060301DE RID: 197086 RVA: 0x0068A8B9 File Offset: 0x00688AB9
		// (set) Token: 0x060301DF RID: 197087 RVA: 0x0068A8C1 File Offset: 0x00688AC1
		public bool IsOneWay { get; set; }

		// Token: 0x1700CBBC RID: 52156
		// (get) Token: 0x060301E0 RID: 197088 RVA: 0x0068A8CA File Offset: 0x00688ACA
		// (set) Token: 0x060301E1 RID: 197089 RVA: 0x0068A8D2 File Offset: 0x00688AD2
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700CBBD RID: 52157
		// (get) Token: 0x060301E2 RID: 197090 RVA: 0x0068A8DB File Offset: 0x00688ADB
		// (set) Token: 0x060301E3 RID: 197091 RVA: 0x0068A8E3 File Offset: 0x00688AE3
		public bool DynamicGravity { get; set; }

		// Token: 0x1700CBBE RID: 52158
		// (get) Token: 0x060301E4 RID: 197092 RVA: 0x0068A8EC File Offset: 0x00688AEC
		// (set) Token: 0x060301E5 RID: 197093 RVA: 0x0068A8F4 File Offset: 0x00688AF4
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700CBBF RID: 52159
		// (get) Token: 0x060301E6 RID: 197094 RVA: 0x0068A8FD File Offset: 0x00688AFD
		// (set) Token: 0x060301E7 RID: 197095 RVA: 0x0068A905 File Offset: 0x00688B05
		public int AutoExitDistance { get; set; }

		// Token: 0x1700CBC0 RID: 52160
		// (get) Token: 0x060301E8 RID: 197096 RVA: 0x0068A90E File Offset: 0x00688B0E
		// (set) Token: 0x060301E9 RID: 197097 RVA: 0x0068A916 File Offset: 0x00688B16
		public bool DisableAutoForward { get; set; }

		// Token: 0x1700CBC1 RID: 52161
		// (get) Token: 0x060301EA RID: 197098 RVA: 0x0068A91F File Offset: 0x00688B1F
		// (set) Token: 0x060301EB RID: 197099 RVA: 0x0068A927 File Offset: 0x00688B27
		public float LongitudinalAngleLimit { get; set; }

		// Token: 0x1700CBC2 RID: 52162
		// (get) Token: 0x060301EC RID: 197100 RVA: 0x0068A930 File Offset: 0x00688B30
		// (set) Token: 0x060301ED RID: 197101 RVA: 0x0068A938 File Offset: 0x00688B38
		public float ForwardAngleLimit { get; set; }

		// Token: 0x1700CBC3 RID: 52163
		// (get) Token: 0x060301EE RID: 197102 RVA: 0x0068A941 File Offset: 0x00688B41
		// (set) Token: 0x060301EF RID: 197103 RVA: 0x0068A949 File Offset: 0x00688B49
		public string ForwardAngleLimitCurve { get; set; }

		// Token: 0x1700CBC4 RID: 52164
		// (get) Token: 0x060301F0 RID: 197104 RVA: 0x0068A952 File Offset: 0x00688B52
		// (set) Token: 0x060301F1 RID: 197105 RVA: 0x0068A95A File Offset: 0x00688B5A
		public string InputCorrectionCurve { get; set; }

		// Token: 0x1700CBC5 RID: 52165
		// (get) Token: 0x060301F2 RID: 197106 RVA: 0x0068A963 File Offset: 0x00688B63
		// (set) Token: 0x060301F3 RID: 197107 RVA: 0x0068A96B File Offset: 0x00688B6B
		public float InputCorrectionBaseAngle { get; set; }

		// Token: 0x1700CBC6 RID: 52166
		// (get) Token: 0x060301F4 RID: 197108 RVA: 0x0068A974 File Offset: 0x00688B74
		// (set) Token: 0x060301F5 RID: 197109 RVA: 0x0068A97C File Offset: 0x00688B7C
		public float CorrectionPredictionDistance { get; set; }

		// Token: 0x1700CBC7 RID: 52167
		// (get) Token: 0x060301F6 RID: 197110 RVA: 0x0068A985 File Offset: 0x00688B85
		// (set) Token: 0x060301F7 RID: 197111 RVA: 0x0068A98D File Offset: 0x00688B8D
		public string AccelerationCorrectionCurve { get; set; }

		// Token: 0x1700CBC8 RID: 52168
		// (get) Token: 0x060301F8 RID: 197112 RVA: 0x0068A996 File Offset: 0x00688B96
		// (set) Token: 0x060301F9 RID: 197113 RVA: 0x0068A99E File Offset: 0x00688B9E
		public IAutomaticDriveT AutomaticDrive { get; set; }

		// Token: 0x1700CBC9 RID: 52169
		// (get) Token: 0x060301FA RID: 197114 RVA: 0x0068A9A7 File Offset: 0x00688BA7
		// (set) Token: 0x060301FB RID: 197115 RVA: 0x0068A9AF File Offset: 0x00688BAF
		public ushort NullMask { get; set; }

		// Token: 0x060301FC RID: 197116 RVA: 0x0068A9B8 File Offset: 0x00688BB8
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
