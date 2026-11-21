using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C7 RID: 26567
	public class IAdjustFixedSurveillanceCameraT
	{
		// Token: 0x1700C2AA RID: 49834
		// (get) Token: 0x0602D472 RID: 185458 RVA: 0x00632BD7 File Offset: 0x00630DD7
		// (set) Token: 0x0602D473 RID: 185459 RVA: 0x00632BDF File Offset: 0x00630DDF
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C2AB RID: 49835
		// (get) Token: 0x0602D474 RID: 185460 RVA: 0x00632BE8 File Offset: 0x00630DE8
		// (set) Token: 0x0602D475 RID: 185461 RVA: 0x00632BF0 File Offset: 0x00630DF0
		public int Priority { get; set; }

		// Token: 0x1700C2AC RID: 49836
		// (get) Token: 0x0602D476 RID: 185462 RVA: 0x00632BF9 File Offset: 0x00630DF9
		// (set) Token: 0x0602D477 RID: 185463 RVA: 0x00632C01 File Offset: 0x00630E01
		public float FadeInTime { get; set; }

		// Token: 0x1700C2AD RID: 49837
		// (get) Token: 0x0602D478 RID: 185464 RVA: 0x00632C0A File Offset: 0x00630E0A
		// (set) Token: 0x0602D479 RID: 185465 RVA: 0x00632C12 File Offset: 0x00630E12
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C2AE RID: 49838
		// (get) Token: 0x0602D47A RID: 185466 RVA: 0x00632C1B File Offset: 0x00630E1B
		// (set) Token: 0x0602D47B RID: 185467 RVA: 0x00632C23 File Offset: 0x00630E23
		public float FadeOutTime { get; set; }

		// Token: 0x1700C2AF RID: 49839
		// (get) Token: 0x0602D47C RID: 185468 RVA: 0x00632C2C File Offset: 0x00630E2C
		// (set) Token: 0x0602D47D RID: 185469 RVA: 0x00632C34 File Offset: 0x00630E34
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C2B0 RID: 49840
		// (get) Token: 0x0602D47E RID: 185470 RVA: 0x00632C3D File Offset: 0x00630E3D
		// (set) Token: 0x0602D47F RID: 185471 RVA: 0x00632C45 File Offset: 0x00630E45
		public float ArmLength { get; set; }

		// Token: 0x1700C2B1 RID: 49841
		// (get) Token: 0x0602D480 RID: 185472 RVA: 0x00632C4E File Offset: 0x00630E4E
		// (set) Token: 0x0602D481 RID: 185473 RVA: 0x00632C56 File Offset: 0x00630E56
		public float MinumArmLength { get; set; }

		// Token: 0x1700C2B2 RID: 49842
		// (get) Token: 0x0602D482 RID: 185474 RVA: 0x00632C5F File Offset: 0x00630E5F
		// (set) Token: 0x0602D483 RID: 185475 RVA: 0x00632C67 File Offset: 0x00630E67
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C2B3 RID: 49843
		// (get) Token: 0x0602D484 RID: 185476 RVA: 0x00632C70 File Offset: 0x00630E70
		// (set) Token: 0x0602D485 RID: 185477 RVA: 0x00632C78 File Offset: 0x00630E78
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C2B4 RID: 49844
		// (get) Token: 0x0602D486 RID: 185478 RVA: 0x00632C81 File Offset: 0x00630E81
		// (set) Token: 0x0602D487 RID: 185479 RVA: 0x00632C89 File Offset: 0x00630E89
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C2B5 RID: 49845
		// (get) Token: 0x0602D488 RID: 185480 RVA: 0x00632C92 File Offset: 0x00630E92
		// (set) Token: 0x0602D489 RID: 185481 RVA: 0x00632C9A File Offset: 0x00630E9A
		public float YawLimitMin { get; set; }

		// Token: 0x1700C2B6 RID: 49846
		// (get) Token: 0x0602D48A RID: 185482 RVA: 0x00632CA3 File Offset: 0x00630EA3
		// (set) Token: 0x0602D48B RID: 185483 RVA: 0x00632CAB File Offset: 0x00630EAB
		public float YawLimitMax { get; set; }

		// Token: 0x1700C2B7 RID: 49847
		// (get) Token: 0x0602D48C RID: 185484 RVA: 0x00632CB4 File Offset: 0x00630EB4
		// (set) Token: 0x0602D48D RID: 185485 RVA: 0x00632CBC File Offset: 0x00630EBC
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C2B8 RID: 49848
		// (get) Token: 0x0602D48E RID: 185486 RVA: 0x00632CC5 File Offset: 0x00630EC5
		// (set) Token: 0x0602D48F RID: 185487 RVA: 0x00632CCD File Offset: 0x00630ECD
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C2B9 RID: 49849
		// (get) Token: 0x0602D490 RID: 185488 RVA: 0x00632CD6 File Offset: 0x00630ED6
		// (set) Token: 0x0602D491 RID: 185489 RVA: 0x00632CDE File Offset: 0x00630EDE
		public float Fov { get; set; }

		// Token: 0x1700C2BA RID: 49850
		// (get) Token: 0x0602D492 RID: 185490 RVA: 0x00632CE7 File Offset: 0x00630EE7
		// (set) Token: 0x0602D493 RID: 185491 RVA: 0x00632CEF File Offset: 0x00630EEF
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C2BB RID: 49851
		// (get) Token: 0x0602D494 RID: 185492 RVA: 0x00632CF8 File Offset: 0x00630EF8
		// (set) Token: 0x0602D495 RID: 185493 RVA: 0x00632D00 File Offset: 0x00630F00
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C2BC RID: 49852
		// (get) Token: 0x0602D496 RID: 185494 RVA: 0x00632D09 File Offset: 0x00630F09
		// (set) Token: 0x0602D497 RID: 185495 RVA: 0x00632D11 File Offset: 0x00630F11
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C2BD RID: 49853
		// (get) Token: 0x0602D498 RID: 185496 RVA: 0x00632D1A File Offset: 0x00630F1A
		// (set) Token: 0x0602D499 RID: 185497 RVA: 0x00632D22 File Offset: 0x00630F22
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C2BE RID: 49854
		// (get) Token: 0x0602D49A RID: 185498 RVA: 0x00632D2B File Offset: 0x00630F2B
		// (set) Token: 0x0602D49B RID: 185499 RVA: 0x00632D33 File Offset: 0x00630F33
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C2BF RID: 49855
		// (get) Token: 0x0602D49C RID: 185500 RVA: 0x00632D3C File Offset: 0x00630F3C
		// (set) Token: 0x0602D49D RID: 185501 RVA: 0x00632D44 File Offset: 0x00630F44
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700C2C0 RID: 49856
		// (get) Token: 0x0602D49E RID: 185502 RVA: 0x00632D4D File Offset: 0x00630F4D
		// (set) Token: 0x0602D49F RID: 185503 RVA: 0x00632D55 File Offset: 0x00630F55
		public IBlendFunctionT BlendIn { get; set; }

		// Token: 0x1700C2C1 RID: 49857
		// (get) Token: 0x0602D4A0 RID: 185504 RVA: 0x00632D5E File Offset: 0x00630F5E
		// (set) Token: 0x0602D4A1 RID: 185505 RVA: 0x00632D66 File Offset: 0x00630F66
		public IBlendFunctionT BlendOut { get; set; }

		// Token: 0x1700C2C2 RID: 49858
		// (get) Token: 0x0602D4A2 RID: 185506 RVA: 0x00632D6F File Offset: 0x00630F6F
		// (set) Token: 0x0602D4A3 RID: 185507 RVA: 0x00632D77 File Offset: 0x00630F77
		public IAdjustFixedCameraOrthogonalConfigT OrthogonalConfig { get; set; }

		// Token: 0x1700C2C3 RID: 49859
		// (get) Token: 0x0602D4A4 RID: 185508 RVA: 0x00632D80 File Offset: 0x00630F80
		// (set) Token: 0x0602D4A5 RID: 185509 RVA: 0x00632D88 File Offset: 0x00630F88
		public TTargetEntityUnion FollowTarget { get; set; }

		// Token: 0x1700C2C4 RID: 49860
		// (get) Token: 0x0602D4A6 RID: 185510 RVA: 0x00632D91 File Offset: 0x00630F91
		// (set) Token: 0x0602D4A7 RID: 185511 RVA: 0x00632D99 File Offset: 0x00630F99
		public byte NullMask { get; set; }

		// Token: 0x0602D4A8 RID: 185512 RVA: 0x00632DA4 File Offset: 0x00630FA4
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
