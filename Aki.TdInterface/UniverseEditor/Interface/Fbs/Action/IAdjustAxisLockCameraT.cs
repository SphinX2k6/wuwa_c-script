using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A6 RID: 26534
	public class IAdjustAxisLockCameraT
	{
		// Token: 0x1700C13C RID: 49468
		// (get) Token: 0x0602D0D6 RID: 184534 RVA: 0x00628FEC File Offset: 0x006271EC
		// (set) Token: 0x0602D0D7 RID: 184535 RVA: 0x00628FF4 File Offset: 0x006271F4
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C13D RID: 49469
		// (get) Token: 0x0602D0D8 RID: 184536 RVA: 0x00628FFD File Offset: 0x006271FD
		// (set) Token: 0x0602D0D9 RID: 184537 RVA: 0x00629005 File Offset: 0x00627205
		public int Priority { get; set; }

		// Token: 0x1700C13E RID: 49470
		// (get) Token: 0x0602D0DA RID: 184538 RVA: 0x0062900E File Offset: 0x0062720E
		// (set) Token: 0x0602D0DB RID: 184539 RVA: 0x00629016 File Offset: 0x00627216
		public float FadeInTime { get; set; }

		// Token: 0x1700C13F RID: 49471
		// (get) Token: 0x0602D0DC RID: 184540 RVA: 0x0062901F File Offset: 0x0062721F
		// (set) Token: 0x0602D0DD RID: 184541 RVA: 0x00629027 File Offset: 0x00627227
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C140 RID: 49472
		// (get) Token: 0x0602D0DE RID: 184542 RVA: 0x00629030 File Offset: 0x00627230
		// (set) Token: 0x0602D0DF RID: 184543 RVA: 0x00629038 File Offset: 0x00627238
		public float FadeOutTime { get; set; }

		// Token: 0x1700C141 RID: 49473
		// (get) Token: 0x0602D0E0 RID: 184544 RVA: 0x00629041 File Offset: 0x00627241
		// (set) Token: 0x0602D0E1 RID: 184545 RVA: 0x00629049 File Offset: 0x00627249
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C142 RID: 49474
		// (get) Token: 0x0602D0E2 RID: 184546 RVA: 0x00629052 File Offset: 0x00627252
		// (set) Token: 0x0602D0E3 RID: 184547 RVA: 0x0062905A File Offset: 0x0062725A
		public float ArmLength { get; set; }

		// Token: 0x1700C143 RID: 49475
		// (get) Token: 0x0602D0E4 RID: 184548 RVA: 0x00629063 File Offset: 0x00627263
		// (set) Token: 0x0602D0E5 RID: 184549 RVA: 0x0062906B File Offset: 0x0062726B
		public float MinumArmLength { get; set; }

		// Token: 0x1700C144 RID: 49476
		// (get) Token: 0x0602D0E6 RID: 184550 RVA: 0x00629074 File Offset: 0x00627274
		// (set) Token: 0x0602D0E7 RID: 184551 RVA: 0x0062907C File Offset: 0x0062727C
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C145 RID: 49477
		// (get) Token: 0x0602D0E8 RID: 184552 RVA: 0x00629085 File Offset: 0x00627285
		// (set) Token: 0x0602D0E9 RID: 184553 RVA: 0x0062908D File Offset: 0x0062728D
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C146 RID: 49478
		// (get) Token: 0x0602D0EA RID: 184554 RVA: 0x00629096 File Offset: 0x00627296
		// (set) Token: 0x0602D0EB RID: 184555 RVA: 0x0062909E File Offset: 0x0062729E
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C147 RID: 49479
		// (get) Token: 0x0602D0EC RID: 184556 RVA: 0x006290A7 File Offset: 0x006272A7
		// (set) Token: 0x0602D0ED RID: 184557 RVA: 0x006290AF File Offset: 0x006272AF
		public float YawLimitMin { get; set; }

		// Token: 0x1700C148 RID: 49480
		// (get) Token: 0x0602D0EE RID: 184558 RVA: 0x006290B8 File Offset: 0x006272B8
		// (set) Token: 0x0602D0EF RID: 184559 RVA: 0x006290C0 File Offset: 0x006272C0
		public float YawLimitMax { get; set; }

		// Token: 0x1700C149 RID: 49481
		// (get) Token: 0x0602D0F0 RID: 184560 RVA: 0x006290C9 File Offset: 0x006272C9
		// (set) Token: 0x0602D0F1 RID: 184561 RVA: 0x006290D1 File Offset: 0x006272D1
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C14A RID: 49482
		// (get) Token: 0x0602D0F2 RID: 184562 RVA: 0x006290DA File Offset: 0x006272DA
		// (set) Token: 0x0602D0F3 RID: 184563 RVA: 0x006290E2 File Offset: 0x006272E2
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C14B RID: 49483
		// (get) Token: 0x0602D0F4 RID: 184564 RVA: 0x006290EB File Offset: 0x006272EB
		// (set) Token: 0x0602D0F5 RID: 184565 RVA: 0x006290F3 File Offset: 0x006272F3
		public float Fov { get; set; }

		// Token: 0x1700C14C RID: 49484
		// (get) Token: 0x0602D0F6 RID: 184566 RVA: 0x006290FC File Offset: 0x006272FC
		// (set) Token: 0x0602D0F7 RID: 184567 RVA: 0x00629104 File Offset: 0x00627304
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C14D RID: 49485
		// (get) Token: 0x0602D0F8 RID: 184568 RVA: 0x0062910D File Offset: 0x0062730D
		// (set) Token: 0x0602D0F9 RID: 184569 RVA: 0x00629115 File Offset: 0x00627315
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C14E RID: 49486
		// (get) Token: 0x0602D0FA RID: 184570 RVA: 0x0062911E File Offset: 0x0062731E
		// (set) Token: 0x0602D0FB RID: 184571 RVA: 0x00629126 File Offset: 0x00627326
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C14F RID: 49487
		// (get) Token: 0x0602D0FC RID: 184572 RVA: 0x0062912F File Offset: 0x0062732F
		// (set) Token: 0x0602D0FD RID: 184573 RVA: 0x00629137 File Offset: 0x00627337
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C150 RID: 49488
		// (get) Token: 0x0602D0FE RID: 184574 RVA: 0x00629140 File Offset: 0x00627340
		// (set) Token: 0x0602D0FF RID: 184575 RVA: 0x00629148 File Offset: 0x00627348
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C151 RID: 49489
		// (get) Token: 0x0602D100 RID: 184576 RVA: 0x00629151 File Offset: 0x00627351
		// (set) Token: 0x0602D101 RID: 184577 RVA: 0x00629159 File Offset: 0x00627359
		public IVectorInfoT AxisRotate { get; set; }

		// Token: 0x1700C152 RID: 49490
		// (get) Token: 0x0602D102 RID: 184578 RVA: 0x00629162 File Offset: 0x00627362
		// (set) Token: 0x0602D103 RID: 184579 RVA: 0x0062916A File Offset: 0x0062736A
		public bool IsLockRoll { get; set; }

		// Token: 0x1700C153 RID: 49491
		// (get) Token: 0x0602D104 RID: 184580 RVA: 0x00629173 File Offset: 0x00627373
		// (set) Token: 0x0602D105 RID: 184581 RVA: 0x0062917B File Offset: 0x0062737B
		public IAxisLockScreenConfigT ScreenConfig { get; set; }

		// Token: 0x1700C154 RID: 49492
		// (get) Token: 0x0602D106 RID: 184582 RVA: 0x00629184 File Offset: 0x00627384
		// (set) Token: 0x0602D107 RID: 184583 RVA: 0x0062918C File Offset: 0x0062738C
		public float NearClipDistanceToTarget { get; set; }

		// Token: 0x1700C155 RID: 49493
		// (get) Token: 0x0602D108 RID: 184584 RVA: 0x00629195 File Offset: 0x00627395
		// (set) Token: 0x0602D109 RID: 184585 RVA: 0x0062919D File Offset: 0x0062739D
		public ISpringArmSoftZoneConfigT SpringArmSoftZoneConfig { get; set; }

		// Token: 0x1700C156 RID: 49494
		// (get) Token: 0x0602D10A RID: 184586 RVA: 0x006291A6 File Offset: 0x006273A6
		// (set) Token: 0x0602D10B RID: 184587 RVA: 0x006291AE File Offset: 0x006273AE
		public ISpringArmFixConfigT SpringArmFix { get; set; }

		// Token: 0x1700C157 RID: 49495
		// (get) Token: 0x0602D10C RID: 184588 RVA: 0x006291B7 File Offset: 0x006273B7
		// (set) Token: 0x0602D10D RID: 184589 RVA: 0x006291BF File Offset: 0x006273BF
		public bool HidePlayer { get; set; }

		// Token: 0x1700C158 RID: 49496
		// (get) Token: 0x0602D10E RID: 184590 RVA: 0x006291C8 File Offset: 0x006273C8
		// (set) Token: 0x0602D10F RID: 184591 RVA: 0x006291D0 File Offset: 0x006273D0
		public ushort NullMask { get; set; }

		// Token: 0x0602D110 RID: 184592 RVA: 0x006291DC File Offset: 0x006273DC
		public IAdjustAxisLockCameraT()
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
			this.AxisRotate = null;
			this.IsLockRoll = false;
			this.ScreenConfig = null;
			this.NearClipDistanceToTarget = 0f;
			this.SpringArmSoftZoneConfig = null;
			this.SpringArmFix = null;
			this.HidePlayer = false;
			this.NullMask = 0;
		}
	}
}
