using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006165 RID: 24933
	public class IAdjustHorizontalCameraT
	{
		// Token: 0x1700B976 RID: 47478
		// (get) Token: 0x0602AE05 RID: 175621 RVA: 0x005EA39E File Offset: 0x005E859E
		// (set) Token: 0x0602AE06 RID: 175622 RVA: 0x005EA3A6 File Offset: 0x005E85A6
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B977 RID: 47479
		// (get) Token: 0x0602AE07 RID: 175623 RVA: 0x005EA3AF File Offset: 0x005E85AF
		// (set) Token: 0x0602AE08 RID: 175624 RVA: 0x005EA3B7 File Offset: 0x005E85B7
		public int Priority { get; set; }

		// Token: 0x1700B978 RID: 47480
		// (get) Token: 0x0602AE09 RID: 175625 RVA: 0x005EA3C0 File Offset: 0x005E85C0
		// (set) Token: 0x0602AE0A RID: 175626 RVA: 0x005EA3C8 File Offset: 0x005E85C8
		public float FadeInTime { get; set; }

		// Token: 0x1700B979 RID: 47481
		// (get) Token: 0x0602AE0B RID: 175627 RVA: 0x005EA3D1 File Offset: 0x005E85D1
		// (set) Token: 0x0602AE0C RID: 175628 RVA: 0x005EA3D9 File Offset: 0x005E85D9
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B97A RID: 47482
		// (get) Token: 0x0602AE0D RID: 175629 RVA: 0x005EA3E2 File Offset: 0x005E85E2
		// (set) Token: 0x0602AE0E RID: 175630 RVA: 0x005EA3EA File Offset: 0x005E85EA
		public float FadeOutTime { get; set; }

		// Token: 0x1700B97B RID: 47483
		// (get) Token: 0x0602AE0F RID: 175631 RVA: 0x005EA3F3 File Offset: 0x005E85F3
		// (set) Token: 0x0602AE10 RID: 175632 RVA: 0x005EA3FB File Offset: 0x005E85FB
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B97C RID: 47484
		// (get) Token: 0x0602AE11 RID: 175633 RVA: 0x005EA404 File Offset: 0x005E8604
		// (set) Token: 0x0602AE12 RID: 175634 RVA: 0x005EA40C File Offset: 0x005E860C
		public float ArmLength { get; set; }

		// Token: 0x1700B97D RID: 47485
		// (get) Token: 0x0602AE13 RID: 175635 RVA: 0x005EA415 File Offset: 0x005E8615
		// (set) Token: 0x0602AE14 RID: 175636 RVA: 0x005EA41D File Offset: 0x005E861D
		public float MinumArmLength { get; set; }

		// Token: 0x1700B97E RID: 47486
		// (get) Token: 0x0602AE15 RID: 175637 RVA: 0x005EA426 File Offset: 0x005E8626
		// (set) Token: 0x0602AE16 RID: 175638 RVA: 0x005EA42E File Offset: 0x005E862E
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B97F RID: 47487
		// (get) Token: 0x0602AE17 RID: 175639 RVA: 0x005EA437 File Offset: 0x005E8637
		// (set) Token: 0x0602AE18 RID: 175640 RVA: 0x005EA43F File Offset: 0x005E863F
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B980 RID: 47488
		// (get) Token: 0x0602AE19 RID: 175641 RVA: 0x005EA448 File Offset: 0x005E8648
		// (set) Token: 0x0602AE1A RID: 175642 RVA: 0x005EA450 File Offset: 0x005E8650
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B981 RID: 47489
		// (get) Token: 0x0602AE1B RID: 175643 RVA: 0x005EA459 File Offset: 0x005E8659
		// (set) Token: 0x0602AE1C RID: 175644 RVA: 0x005EA461 File Offset: 0x005E8661
		public float YawLimitMin { get; set; }

		// Token: 0x1700B982 RID: 47490
		// (get) Token: 0x0602AE1D RID: 175645 RVA: 0x005EA46A File Offset: 0x005E866A
		// (set) Token: 0x0602AE1E RID: 175646 RVA: 0x005EA472 File Offset: 0x005E8672
		public float YawLimitMax { get; set; }

		// Token: 0x1700B983 RID: 47491
		// (get) Token: 0x0602AE1F RID: 175647 RVA: 0x005EA47B File Offset: 0x005E867B
		// (set) Token: 0x0602AE20 RID: 175648 RVA: 0x005EA483 File Offset: 0x005E8683
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B984 RID: 47492
		// (get) Token: 0x0602AE21 RID: 175649 RVA: 0x005EA48C File Offset: 0x005E868C
		// (set) Token: 0x0602AE22 RID: 175650 RVA: 0x005EA494 File Offset: 0x005E8694
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B985 RID: 47493
		// (get) Token: 0x0602AE23 RID: 175651 RVA: 0x005EA49D File Offset: 0x005E869D
		// (set) Token: 0x0602AE24 RID: 175652 RVA: 0x005EA4A5 File Offset: 0x005E86A5
		public float Fov { get; set; }

		// Token: 0x1700B986 RID: 47494
		// (get) Token: 0x0602AE25 RID: 175653 RVA: 0x005EA4AE File Offset: 0x005E86AE
		// (set) Token: 0x0602AE26 RID: 175654 RVA: 0x005EA4B6 File Offset: 0x005E86B6
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B987 RID: 47495
		// (get) Token: 0x0602AE27 RID: 175655 RVA: 0x005EA4BF File Offset: 0x005E86BF
		// (set) Token: 0x0602AE28 RID: 175656 RVA: 0x005EA4C7 File Offset: 0x005E86C7
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B988 RID: 47496
		// (get) Token: 0x0602AE29 RID: 175657 RVA: 0x005EA4D0 File Offset: 0x005E86D0
		// (set) Token: 0x0602AE2A RID: 175658 RVA: 0x005EA4D8 File Offset: 0x005E86D8
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B989 RID: 47497
		// (get) Token: 0x0602AE2B RID: 175659 RVA: 0x005EA4E1 File Offset: 0x005E86E1
		// (set) Token: 0x0602AE2C RID: 175660 RVA: 0x005EA4E9 File Offset: 0x005E86E9
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B98A RID: 47498
		// (get) Token: 0x0602AE2D RID: 175661 RVA: 0x005EA4F2 File Offset: 0x005E86F2
		// (set) Token: 0x0602AE2E RID: 175662 RVA: 0x005EA4FA File Offset: 0x005E86FA
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B98B RID: 47499
		// (get) Token: 0x0602AE2F RID: 175663 RVA: 0x005EA503 File Offset: 0x005E8703
		// (set) Token: 0x0602AE30 RID: 175664 RVA: 0x005EA50B File Offset: 0x005E870B
		public int SplineEntityId { get; set; }

		// Token: 0x1700B98C RID: 47500
		// (get) Token: 0x0602AE31 RID: 175665 RVA: 0x005EA514 File Offset: 0x005E8714
		// (set) Token: 0x0602AE32 RID: 175666 RVA: 0x005EA51C File Offset: 0x005E871C
		public float YawAngle { get; set; }

		// Token: 0x1700B98D RID: 47501
		// (get) Token: 0x0602AE33 RID: 175667 RVA: 0x005EA525 File Offset: 0x005E8725
		// (set) Token: 0x0602AE34 RID: 175668 RVA: 0x005EA52D File Offset: 0x005E872D
		public float PitchAngle { get; set; }

		// Token: 0x1700B98E RID: 47502
		// (get) Token: 0x0602AE35 RID: 175669 RVA: 0x005EA536 File Offset: 0x005E8736
		// (set) Token: 0x0602AE36 RID: 175670 RVA: 0x005EA53E File Offset: 0x005E873E
		public float RollAngle { get; set; }

		// Token: 0x1700B98F RID: 47503
		// (get) Token: 0x0602AE37 RID: 175671 RVA: 0x005EA547 File Offset: 0x005E8747
		// (set) Token: 0x0602AE38 RID: 175672 RVA: 0x005EA54F File Offset: 0x005E874F
		public ICameraDepthOfFieldT DepthOfField { get; set; }

		// Token: 0x1700B990 RID: 47504
		// (get) Token: 0x0602AE39 RID: 175673 RVA: 0x005EA558 File Offset: 0x005E8758
		// (set) Token: 0x0602AE3A RID: 175674 RVA: 0x005EA560 File Offset: 0x005E8760
		public ICameraOffsetInMovementDirectionT OffsetInMovementDirection { get; set; }

		// Token: 0x1700B991 RID: 47505
		// (get) Token: 0x0602AE3B RID: 175675 RVA: 0x005EA569 File Offset: 0x005E8769
		// (set) Token: 0x0602AE3C RID: 175676 RVA: 0x005EA571 File Offset: 0x005E8771
		public float NearClipDistanceToTarget { get; set; }

		// Token: 0x1700B992 RID: 47506
		// (get) Token: 0x0602AE3D RID: 175677 RVA: 0x005EA57A File Offset: 0x005E877A
		// (set) Token: 0x0602AE3E RID: 175678 RVA: 0x005EA582 File Offset: 0x005E8782
		public ISpringArmSoftZoneConfigT SpringArmSoftZoneConfig { get; set; }

		// Token: 0x1700B993 RID: 47507
		// (get) Token: 0x0602AE3F RID: 175679 RVA: 0x005EA58B File Offset: 0x005E878B
		// (set) Token: 0x0602AE40 RID: 175680 RVA: 0x005EA593 File Offset: 0x005E8793
		public ISpringArmFixConfigT SpringArmFix { get; set; }

		// Token: 0x1700B994 RID: 47508
		// (get) Token: 0x0602AE41 RID: 175681 RVA: 0x005EA59C File Offset: 0x005E879C
		// (set) Token: 0x0602AE42 RID: 175682 RVA: 0x005EA5A4 File Offset: 0x005E87A4
		public bool IsCameraFollowSplineRoll { get; set; }

		// Token: 0x1700B995 RID: 47509
		// (get) Token: 0x0602AE43 RID: 175683 RVA: 0x005EA5AD File Offset: 0x005E87AD
		// (set) Token: 0x0602AE44 RID: 175684 RVA: 0x005EA5B5 File Offset: 0x005E87B5
		public ushort NullMask { get; set; }

		// Token: 0x0602AE45 RID: 175685 RVA: 0x005EA5C0 File Offset: 0x005E87C0
		public IAdjustHorizontalCameraT()
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
			this.SplineEntityId = 0;
			this.YawAngle = 0f;
			this.PitchAngle = 0f;
			this.RollAngle = 0f;
			this.DepthOfField = null;
			this.OffsetInMovementDirection = null;
			this.NearClipDistanceToTarget = 0f;
			this.SpringArmSoftZoneConfig = null;
			this.SpringArmFix = null;
			this.IsCameraFollowSplineRoll = false;
			this.NullMask = 0;
		}
	}
}
