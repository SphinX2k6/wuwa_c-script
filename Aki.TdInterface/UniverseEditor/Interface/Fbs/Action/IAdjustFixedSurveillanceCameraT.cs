using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006162 RID: 24930
	public class IAdjustFixedSurveillanceCameraT
	{
		// Token: 0x1700B93A RID: 47418
		// (get) Token: 0x0602AD79 RID: 175481 RVA: 0x005E89FB File Offset: 0x005E6BFB
		// (set) Token: 0x0602AD7A RID: 175482 RVA: 0x005E8A03 File Offset: 0x005E6C03
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B93B RID: 47419
		// (get) Token: 0x0602AD7B RID: 175483 RVA: 0x005E8A0C File Offset: 0x005E6C0C
		// (set) Token: 0x0602AD7C RID: 175484 RVA: 0x005E8A14 File Offset: 0x005E6C14
		public int Priority { get; set; }

		// Token: 0x1700B93C RID: 47420
		// (get) Token: 0x0602AD7D RID: 175485 RVA: 0x005E8A1D File Offset: 0x005E6C1D
		// (set) Token: 0x0602AD7E RID: 175486 RVA: 0x005E8A25 File Offset: 0x005E6C25
		public float FadeInTime { get; set; }

		// Token: 0x1700B93D RID: 47421
		// (get) Token: 0x0602AD7F RID: 175487 RVA: 0x005E8A2E File Offset: 0x005E6C2E
		// (set) Token: 0x0602AD80 RID: 175488 RVA: 0x005E8A36 File Offset: 0x005E6C36
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B93E RID: 47422
		// (get) Token: 0x0602AD81 RID: 175489 RVA: 0x005E8A3F File Offset: 0x005E6C3F
		// (set) Token: 0x0602AD82 RID: 175490 RVA: 0x005E8A47 File Offset: 0x005E6C47
		public float FadeOutTime { get; set; }

		// Token: 0x1700B93F RID: 47423
		// (get) Token: 0x0602AD83 RID: 175491 RVA: 0x005E8A50 File Offset: 0x005E6C50
		// (set) Token: 0x0602AD84 RID: 175492 RVA: 0x005E8A58 File Offset: 0x005E6C58
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B940 RID: 47424
		// (get) Token: 0x0602AD85 RID: 175493 RVA: 0x005E8A61 File Offset: 0x005E6C61
		// (set) Token: 0x0602AD86 RID: 175494 RVA: 0x005E8A69 File Offset: 0x005E6C69
		public float ArmLength { get; set; }

		// Token: 0x1700B941 RID: 47425
		// (get) Token: 0x0602AD87 RID: 175495 RVA: 0x005E8A72 File Offset: 0x005E6C72
		// (set) Token: 0x0602AD88 RID: 175496 RVA: 0x005E8A7A File Offset: 0x005E6C7A
		public float MinumArmLength { get; set; }

		// Token: 0x1700B942 RID: 47426
		// (get) Token: 0x0602AD89 RID: 175497 RVA: 0x005E8A83 File Offset: 0x005E6C83
		// (set) Token: 0x0602AD8A RID: 175498 RVA: 0x005E8A8B File Offset: 0x005E6C8B
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B943 RID: 47427
		// (get) Token: 0x0602AD8B RID: 175499 RVA: 0x005E8A94 File Offset: 0x005E6C94
		// (set) Token: 0x0602AD8C RID: 175500 RVA: 0x005E8A9C File Offset: 0x005E6C9C
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B944 RID: 47428
		// (get) Token: 0x0602AD8D RID: 175501 RVA: 0x005E8AA5 File Offset: 0x005E6CA5
		// (set) Token: 0x0602AD8E RID: 175502 RVA: 0x005E8AAD File Offset: 0x005E6CAD
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B945 RID: 47429
		// (get) Token: 0x0602AD8F RID: 175503 RVA: 0x005E8AB6 File Offset: 0x005E6CB6
		// (set) Token: 0x0602AD90 RID: 175504 RVA: 0x005E8ABE File Offset: 0x005E6CBE
		public float YawLimitMin { get; set; }

		// Token: 0x1700B946 RID: 47430
		// (get) Token: 0x0602AD91 RID: 175505 RVA: 0x005E8AC7 File Offset: 0x005E6CC7
		// (set) Token: 0x0602AD92 RID: 175506 RVA: 0x005E8ACF File Offset: 0x005E6CCF
		public float YawLimitMax { get; set; }

		// Token: 0x1700B947 RID: 47431
		// (get) Token: 0x0602AD93 RID: 175507 RVA: 0x005E8AD8 File Offset: 0x005E6CD8
		// (set) Token: 0x0602AD94 RID: 175508 RVA: 0x005E8AE0 File Offset: 0x005E6CE0
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B948 RID: 47432
		// (get) Token: 0x0602AD95 RID: 175509 RVA: 0x005E8AE9 File Offset: 0x005E6CE9
		// (set) Token: 0x0602AD96 RID: 175510 RVA: 0x005E8AF1 File Offset: 0x005E6CF1
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B949 RID: 47433
		// (get) Token: 0x0602AD97 RID: 175511 RVA: 0x005E8AFA File Offset: 0x005E6CFA
		// (set) Token: 0x0602AD98 RID: 175512 RVA: 0x005E8B02 File Offset: 0x005E6D02
		public float Fov { get; set; }

		// Token: 0x1700B94A RID: 47434
		// (get) Token: 0x0602AD99 RID: 175513 RVA: 0x005E8B0B File Offset: 0x005E6D0B
		// (set) Token: 0x0602AD9A RID: 175514 RVA: 0x005E8B13 File Offset: 0x005E6D13
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B94B RID: 47435
		// (get) Token: 0x0602AD9B RID: 175515 RVA: 0x005E8B1C File Offset: 0x005E6D1C
		// (set) Token: 0x0602AD9C RID: 175516 RVA: 0x005E8B24 File Offset: 0x005E6D24
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B94C RID: 47436
		// (get) Token: 0x0602AD9D RID: 175517 RVA: 0x005E8B2D File Offset: 0x005E6D2D
		// (set) Token: 0x0602AD9E RID: 175518 RVA: 0x005E8B35 File Offset: 0x005E6D35
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B94D RID: 47437
		// (get) Token: 0x0602AD9F RID: 175519 RVA: 0x005E8B3E File Offset: 0x005E6D3E
		// (set) Token: 0x0602ADA0 RID: 175520 RVA: 0x005E8B46 File Offset: 0x005E6D46
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B94E RID: 47438
		// (get) Token: 0x0602ADA1 RID: 175521 RVA: 0x005E8B4F File Offset: 0x005E6D4F
		// (set) Token: 0x0602ADA2 RID: 175522 RVA: 0x005E8B57 File Offset: 0x005E6D57
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B94F RID: 47439
		// (get) Token: 0x0602ADA3 RID: 175523 RVA: 0x005E8B60 File Offset: 0x005E6D60
		// (set) Token: 0x0602ADA4 RID: 175524 RVA: 0x005E8B68 File Offset: 0x005E6D68
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700B950 RID: 47440
		// (get) Token: 0x0602ADA5 RID: 175525 RVA: 0x005E8B71 File Offset: 0x005E6D71
		// (set) Token: 0x0602ADA6 RID: 175526 RVA: 0x005E8B79 File Offset: 0x005E6D79
		public IBlendFunctionT BlendIn { get; set; }

		// Token: 0x1700B951 RID: 47441
		// (get) Token: 0x0602ADA7 RID: 175527 RVA: 0x005E8B82 File Offset: 0x005E6D82
		// (set) Token: 0x0602ADA8 RID: 175528 RVA: 0x005E8B8A File Offset: 0x005E6D8A
		public IBlendFunctionT BlendOut { get; set; }

		// Token: 0x1700B952 RID: 47442
		// (get) Token: 0x0602ADA9 RID: 175529 RVA: 0x005E8B93 File Offset: 0x005E6D93
		// (set) Token: 0x0602ADAA RID: 175530 RVA: 0x005E8B9B File Offset: 0x005E6D9B
		public IAdjustFixedCameraOrthogonalConfigT OrthogonalConfig { get; set; }

		// Token: 0x1700B953 RID: 47443
		// (get) Token: 0x0602ADAB RID: 175531 RVA: 0x005E8BA4 File Offset: 0x005E6DA4
		// (set) Token: 0x0602ADAC RID: 175532 RVA: 0x005E8BAC File Offset: 0x005E6DAC
		public TTargetEntityUnion FollowTarget { get; set; }

		// Token: 0x1700B954 RID: 47444
		// (get) Token: 0x0602ADAD RID: 175533 RVA: 0x005E8BB5 File Offset: 0x005E6DB5
		// (set) Token: 0x0602ADAE RID: 175534 RVA: 0x005E8BBD File Offset: 0x005E6DBD
		public byte NullMask { get; set; }

		// Token: 0x0602ADAF RID: 175535 RVA: 0x005E8BC8 File Offset: 0x005E6DC8
		public IAdjustFixedSurveillanceCameraT()
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
			this.BlendIn = null;
			this.BlendOut = null;
			this.OrthogonalConfig = null;
			this.FollowTarget = null;
			this.NullMask = 0;
		}
	}
}
