using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200614D RID: 24909
	public class IAdjustFixedCameraT
	{
		// Token: 0x1700B8A8 RID: 47272
		// (get) Token: 0x0602ABEE RID: 175086 RVA: 0x005E4B1B File Offset: 0x005E2D1B
		// (set) Token: 0x0602ABEF RID: 175087 RVA: 0x005E4B23 File Offset: 0x005E2D23
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B8A9 RID: 47273
		// (get) Token: 0x0602ABF0 RID: 175088 RVA: 0x005E4B2C File Offset: 0x005E2D2C
		// (set) Token: 0x0602ABF1 RID: 175089 RVA: 0x005E4B34 File Offset: 0x005E2D34
		public int Priority { get; set; }

		// Token: 0x1700B8AA RID: 47274
		// (get) Token: 0x0602ABF2 RID: 175090 RVA: 0x005E4B3D File Offset: 0x005E2D3D
		// (set) Token: 0x0602ABF3 RID: 175091 RVA: 0x005E4B45 File Offset: 0x005E2D45
		public float FadeInTime { get; set; }

		// Token: 0x1700B8AB RID: 47275
		// (get) Token: 0x0602ABF4 RID: 175092 RVA: 0x005E4B4E File Offset: 0x005E2D4E
		// (set) Token: 0x0602ABF5 RID: 175093 RVA: 0x005E4B56 File Offset: 0x005E2D56
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B8AC RID: 47276
		// (get) Token: 0x0602ABF6 RID: 175094 RVA: 0x005E4B5F File Offset: 0x005E2D5F
		// (set) Token: 0x0602ABF7 RID: 175095 RVA: 0x005E4B67 File Offset: 0x005E2D67
		public float FadeOutTime { get; set; }

		// Token: 0x1700B8AD RID: 47277
		// (get) Token: 0x0602ABF8 RID: 175096 RVA: 0x005E4B70 File Offset: 0x005E2D70
		// (set) Token: 0x0602ABF9 RID: 175097 RVA: 0x005E4B78 File Offset: 0x005E2D78
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B8AE RID: 47278
		// (get) Token: 0x0602ABFA RID: 175098 RVA: 0x005E4B81 File Offset: 0x005E2D81
		// (set) Token: 0x0602ABFB RID: 175099 RVA: 0x005E4B89 File Offset: 0x005E2D89
		public float ArmLength { get; set; }

		// Token: 0x1700B8AF RID: 47279
		// (get) Token: 0x0602ABFC RID: 175100 RVA: 0x005E4B92 File Offset: 0x005E2D92
		// (set) Token: 0x0602ABFD RID: 175101 RVA: 0x005E4B9A File Offset: 0x005E2D9A
		public float MinumArmLength { get; set; }

		// Token: 0x1700B8B0 RID: 47280
		// (get) Token: 0x0602ABFE RID: 175102 RVA: 0x005E4BA3 File Offset: 0x005E2DA3
		// (set) Token: 0x0602ABFF RID: 175103 RVA: 0x005E4BAB File Offset: 0x005E2DAB
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B8B1 RID: 47281
		// (get) Token: 0x0602AC00 RID: 175104 RVA: 0x005E4BB4 File Offset: 0x005E2DB4
		// (set) Token: 0x0602AC01 RID: 175105 RVA: 0x005E4BBC File Offset: 0x005E2DBC
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B8B2 RID: 47282
		// (get) Token: 0x0602AC02 RID: 175106 RVA: 0x005E4BC5 File Offset: 0x005E2DC5
		// (set) Token: 0x0602AC03 RID: 175107 RVA: 0x005E4BCD File Offset: 0x005E2DCD
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B8B3 RID: 47283
		// (get) Token: 0x0602AC04 RID: 175108 RVA: 0x005E4BD6 File Offset: 0x005E2DD6
		// (set) Token: 0x0602AC05 RID: 175109 RVA: 0x005E4BDE File Offset: 0x005E2DDE
		public float YawLimitMin { get; set; }

		// Token: 0x1700B8B4 RID: 47284
		// (get) Token: 0x0602AC06 RID: 175110 RVA: 0x005E4BE7 File Offset: 0x005E2DE7
		// (set) Token: 0x0602AC07 RID: 175111 RVA: 0x005E4BEF File Offset: 0x005E2DEF
		public float YawLimitMax { get; set; }

		// Token: 0x1700B8B5 RID: 47285
		// (get) Token: 0x0602AC08 RID: 175112 RVA: 0x005E4BF8 File Offset: 0x005E2DF8
		// (set) Token: 0x0602AC09 RID: 175113 RVA: 0x005E4C00 File Offset: 0x005E2E00
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B8B6 RID: 47286
		// (get) Token: 0x0602AC0A RID: 175114 RVA: 0x005E4C09 File Offset: 0x005E2E09
		// (set) Token: 0x0602AC0B RID: 175115 RVA: 0x005E4C11 File Offset: 0x005E2E11
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B8B7 RID: 47287
		// (get) Token: 0x0602AC0C RID: 175116 RVA: 0x005E4C1A File Offset: 0x005E2E1A
		// (set) Token: 0x0602AC0D RID: 175117 RVA: 0x005E4C22 File Offset: 0x005E2E22
		public float Fov { get; set; }

		// Token: 0x1700B8B8 RID: 47288
		// (get) Token: 0x0602AC0E RID: 175118 RVA: 0x005E4C2B File Offset: 0x005E2E2B
		// (set) Token: 0x0602AC0F RID: 175119 RVA: 0x005E4C33 File Offset: 0x005E2E33
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B8B9 RID: 47289
		// (get) Token: 0x0602AC10 RID: 175120 RVA: 0x005E4C3C File Offset: 0x005E2E3C
		// (set) Token: 0x0602AC11 RID: 175121 RVA: 0x005E4C44 File Offset: 0x005E2E44
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B8BA RID: 47290
		// (get) Token: 0x0602AC12 RID: 175122 RVA: 0x005E4C4D File Offset: 0x005E2E4D
		// (set) Token: 0x0602AC13 RID: 175123 RVA: 0x005E4C55 File Offset: 0x005E2E55
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B8BB RID: 47291
		// (get) Token: 0x0602AC14 RID: 175124 RVA: 0x005E4C5E File Offset: 0x005E2E5E
		// (set) Token: 0x0602AC15 RID: 175125 RVA: 0x005E4C66 File Offset: 0x005E2E66
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B8BC RID: 47292
		// (get) Token: 0x0602AC16 RID: 175126 RVA: 0x005E4C6F File Offset: 0x005E2E6F
		// (set) Token: 0x0602AC17 RID: 175127 RVA: 0x005E4C77 File Offset: 0x005E2E77
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B8BD RID: 47293
		// (get) Token: 0x0602AC18 RID: 175128 RVA: 0x005E4C80 File Offset: 0x005E2E80
		// (set) Token: 0x0602AC19 RID: 175129 RVA: 0x005E4C88 File Offset: 0x005E2E88
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700B8BE RID: 47294
		// (get) Token: 0x0602AC1A RID: 175130 RVA: 0x005E4C91 File Offset: 0x005E2E91
		// (set) Token: 0x0602AC1B RID: 175131 RVA: 0x005E4C99 File Offset: 0x005E2E99
		public IVectorInfoT CenterRot { get; set; }

		// Token: 0x1700B8BF RID: 47295
		// (get) Token: 0x0602AC1C RID: 175132 RVA: 0x005E4CA2 File Offset: 0x005E2EA2
		// (set) Token: 0x0602AC1D RID: 175133 RVA: 0x005E4CAA File Offset: 0x005E2EAA
		public IBlendFunctionT BlendIn { get; set; }

		// Token: 0x1700B8C0 RID: 47296
		// (get) Token: 0x0602AC1E RID: 175134 RVA: 0x005E4CB3 File Offset: 0x005E2EB3
		// (set) Token: 0x0602AC1F RID: 175135 RVA: 0x005E4CBB File Offset: 0x005E2EBB
		public IBlendFunctionT BlendOut { get; set; }

		// Token: 0x1700B8C1 RID: 47297
		// (get) Token: 0x0602AC20 RID: 175136 RVA: 0x005E4CC4 File Offset: 0x005E2EC4
		// (set) Token: 0x0602AC21 RID: 175137 RVA: 0x005E4CCC File Offset: 0x005E2ECC
		public IAdjustFixedCameraOrthogonalConfigT OrthogonalConfig { get; set; }

		// Token: 0x1700B8C2 RID: 47298
		// (get) Token: 0x0602AC22 RID: 175138 RVA: 0x005E4CD5 File Offset: 0x005E2ED5
		// (set) Token: 0x0602AC23 RID: 175139 RVA: 0x005E4CDD File Offset: 0x005E2EDD
		public IAdjustFixedCameraRotateConfigT RotateConfig { get; set; }

		// Token: 0x1700B8C3 RID: 47299
		// (get) Token: 0x0602AC24 RID: 175140 RVA: 0x005E4CE6 File Offset: 0x005E2EE6
		// (set) Token: 0x0602AC25 RID: 175141 RVA: 0x005E4CEE File Offset: 0x005E2EEE
		public TTargetEntityUnion FollowTarget { get; set; }

		// Token: 0x1700B8C4 RID: 47300
		// (get) Token: 0x0602AC26 RID: 175142 RVA: 0x005E4CF7 File Offset: 0x005E2EF7
		// (set) Token: 0x0602AC27 RID: 175143 RVA: 0x005E4CFF File Offset: 0x005E2EFF
		public bool IsPlotEnable { get; set; }

		// Token: 0x1700B8C5 RID: 47301
		// (get) Token: 0x0602AC28 RID: 175144 RVA: 0x005E4D08 File Offset: 0x005E2F08
		// (set) Token: 0x0602AC29 RID: 175145 RVA: 0x005E4D10 File Offset: 0x005E2F10
		public bool HidePlayer { get; set; }

		// Token: 0x1700B8C6 RID: 47302
		// (get) Token: 0x0602AC2A RID: 175146 RVA: 0x005E4D19 File Offset: 0x005E2F19
		// (set) Token: 0x0602AC2B RID: 175147 RVA: 0x005E4D21 File Offset: 0x005E2F21
		public ushort NullMask { get; set; }

		// Token: 0x0602AC2C RID: 175148 RVA: 0x005E4D2C File Offset: 0x005E2F2C
		public IAdjustFixedCameraT()
		{
			this.Type = EAdjustPlayerCamera.Basic;
			this.Priority = 0;
			this.FadeInTime = 0f;
			this.FadeInCurve = null;
			this.FadeOutTime = 0f;
			this.FadeOutCurve = null;
			this.ArmLength = 0f;
			this.MinumArmLength = 0f;
			this.MaxiumArmLength = 0f;
			this.Offset = null;
			this.ArmOffset = null;
			this.YawLimitMin = 0f;
			this.YawLimitMax = 0f;
			this.PitchLimitMin = 0f;
			this.PitchLimitMax = 0f;
			this.Fov = 0f;
			this.IsDisableResetFocus = false;
			this.GravityDirection = null;
			this.IsDisableCollision = false;
			this.IsDisableDither = false;
			this.SubScreenBindKey = null;
			this.CenterPos = null;
			this.CenterRot = null;
			this.BlendIn = null;
			this.BlendOut = null;
			this.OrthogonalConfig = null;
			this.RotateConfig = null;
			this.FollowTarget = null;
			this.IsPlotEnable = false;
			this.HidePlayer = false;
			this.NullMask = 0;
		}
	}
}
