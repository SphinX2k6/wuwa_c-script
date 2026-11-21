using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A9 RID: 26537
	public class IAdjustBasicCameraT
	{
		// Token: 0x1700C178 RID: 49528
		// (get) Token: 0x0602D164 RID: 184676 RVA: 0x0062A8AE File Offset: 0x00628AAE
		// (set) Token: 0x0602D165 RID: 184677 RVA: 0x0062A8B6 File Offset: 0x00628AB6
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C179 RID: 49529
		// (get) Token: 0x0602D166 RID: 184678 RVA: 0x0062A8BF File Offset: 0x00628ABF
		// (set) Token: 0x0602D167 RID: 184679 RVA: 0x0062A8C7 File Offset: 0x00628AC7
		public int Priority { get; set; }

		// Token: 0x1700C17A RID: 49530
		// (get) Token: 0x0602D168 RID: 184680 RVA: 0x0062A8D0 File Offset: 0x00628AD0
		// (set) Token: 0x0602D169 RID: 184681 RVA: 0x0062A8D8 File Offset: 0x00628AD8
		public float FadeInTime { get; set; }

		// Token: 0x1700C17B RID: 49531
		// (get) Token: 0x0602D16A RID: 184682 RVA: 0x0062A8E1 File Offset: 0x00628AE1
		// (set) Token: 0x0602D16B RID: 184683 RVA: 0x0062A8E9 File Offset: 0x00628AE9
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C17C RID: 49532
		// (get) Token: 0x0602D16C RID: 184684 RVA: 0x0062A8F2 File Offset: 0x00628AF2
		// (set) Token: 0x0602D16D RID: 184685 RVA: 0x0062A8FA File Offset: 0x00628AFA
		public float FadeOutTime { get; set; }

		// Token: 0x1700C17D RID: 49533
		// (get) Token: 0x0602D16E RID: 184686 RVA: 0x0062A903 File Offset: 0x00628B03
		// (set) Token: 0x0602D16F RID: 184687 RVA: 0x0062A90B File Offset: 0x00628B0B
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C17E RID: 49534
		// (get) Token: 0x0602D170 RID: 184688 RVA: 0x0062A914 File Offset: 0x00628B14
		// (set) Token: 0x0602D171 RID: 184689 RVA: 0x0062A91C File Offset: 0x00628B1C
		public float ArmLength { get; set; }

		// Token: 0x1700C17F RID: 49535
		// (get) Token: 0x0602D172 RID: 184690 RVA: 0x0062A925 File Offset: 0x00628B25
		// (set) Token: 0x0602D173 RID: 184691 RVA: 0x0062A92D File Offset: 0x00628B2D
		public float MinumArmLength { get; set; }

		// Token: 0x1700C180 RID: 49536
		// (get) Token: 0x0602D174 RID: 184692 RVA: 0x0062A936 File Offset: 0x00628B36
		// (set) Token: 0x0602D175 RID: 184693 RVA: 0x0062A93E File Offset: 0x00628B3E
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C181 RID: 49537
		// (get) Token: 0x0602D176 RID: 184694 RVA: 0x0062A947 File Offset: 0x00628B47
		// (set) Token: 0x0602D177 RID: 184695 RVA: 0x0062A94F File Offset: 0x00628B4F
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C182 RID: 49538
		// (get) Token: 0x0602D178 RID: 184696 RVA: 0x0062A958 File Offset: 0x00628B58
		// (set) Token: 0x0602D179 RID: 184697 RVA: 0x0062A960 File Offset: 0x00628B60
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C183 RID: 49539
		// (get) Token: 0x0602D17A RID: 184698 RVA: 0x0062A969 File Offset: 0x00628B69
		// (set) Token: 0x0602D17B RID: 184699 RVA: 0x0062A971 File Offset: 0x00628B71
		public float YawLimitMin { get; set; }

		// Token: 0x1700C184 RID: 49540
		// (get) Token: 0x0602D17C RID: 184700 RVA: 0x0062A97A File Offset: 0x00628B7A
		// (set) Token: 0x0602D17D RID: 184701 RVA: 0x0062A982 File Offset: 0x00628B82
		public float YawLimitMax { get; set; }

		// Token: 0x1700C185 RID: 49541
		// (get) Token: 0x0602D17E RID: 184702 RVA: 0x0062A98B File Offset: 0x00628B8B
		// (set) Token: 0x0602D17F RID: 184703 RVA: 0x0062A993 File Offset: 0x00628B93
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C186 RID: 49542
		// (get) Token: 0x0602D180 RID: 184704 RVA: 0x0062A99C File Offset: 0x00628B9C
		// (set) Token: 0x0602D181 RID: 184705 RVA: 0x0062A9A4 File Offset: 0x00628BA4
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C187 RID: 49543
		// (get) Token: 0x0602D182 RID: 184706 RVA: 0x0062A9AD File Offset: 0x00628BAD
		// (set) Token: 0x0602D183 RID: 184707 RVA: 0x0062A9B5 File Offset: 0x00628BB5
		public float Fov { get; set; }

		// Token: 0x1700C188 RID: 49544
		// (get) Token: 0x0602D184 RID: 184708 RVA: 0x0062A9BE File Offset: 0x00628BBE
		// (set) Token: 0x0602D185 RID: 184709 RVA: 0x0062A9C6 File Offset: 0x00628BC6
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C189 RID: 49545
		// (get) Token: 0x0602D186 RID: 184710 RVA: 0x0062A9CF File Offset: 0x00628BCF
		// (set) Token: 0x0602D187 RID: 184711 RVA: 0x0062A9D7 File Offset: 0x00628BD7
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C18A RID: 49546
		// (get) Token: 0x0602D188 RID: 184712 RVA: 0x0062A9E0 File Offset: 0x00628BE0
		// (set) Token: 0x0602D189 RID: 184713 RVA: 0x0062A9E8 File Offset: 0x00628BE8
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C18B RID: 49547
		// (get) Token: 0x0602D18A RID: 184714 RVA: 0x0062A9F1 File Offset: 0x00628BF1
		// (set) Token: 0x0602D18B RID: 184715 RVA: 0x0062A9F9 File Offset: 0x00628BF9
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C18C RID: 49548
		// (get) Token: 0x0602D18C RID: 184716 RVA: 0x0062AA02 File Offset: 0x00628C02
		// (set) Token: 0x0602D18D RID: 184717 RVA: 0x0062AA0A File Offset: 0x00628C0A
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C18D RID: 49549
		// (get) Token: 0x0602D18E RID: 184718 RVA: 0x0062AA13 File Offset: 0x00628C13
		// (set) Token: 0x0602D18F RID: 184719 RVA: 0x0062AA1B File Offset: 0x00628C1B
		public float OverlayArmLength { get; set; }

		// Token: 0x1700C18E RID: 49550
		// (get) Token: 0x0602D190 RID: 184720 RVA: 0x0062AA24 File Offset: 0x00628C24
		// (set) Token: 0x0602D191 RID: 184721 RVA: 0x0062AA2C File Offset: 0x00628C2C
		public string SightUi { get; set; }

		// Token: 0x1700C18F RID: 49551
		// (get) Token: 0x0602D192 RID: 184722 RVA: 0x0062AA35 File Offset: 0x00628C35
		// (set) Token: 0x0602D193 RID: 184723 RVA: 0x0062AA3D File Offset: 0x00628C3D
		public bool IsSynchronous { get; set; }

		// Token: 0x1700C190 RID: 49552
		// (get) Token: 0x0602D194 RID: 184724 RVA: 0x0062AA46 File Offset: 0x00628C46
		// (set) Token: 0x0602D195 RID: 184725 RVA: 0x0062AA4E File Offset: 0x00628C4E
		public float NearClipDistanceToTarget { get; set; }

		// Token: 0x1700C191 RID: 49553
		// (get) Token: 0x0602D196 RID: 184726 RVA: 0x0062AA57 File Offset: 0x00628C57
		// (set) Token: 0x0602D197 RID: 184727 RVA: 0x0062AA5F File Offset: 0x00628C5F
		public ISpringArmSoftZoneConfigT SpringArmSoftZoneConfig { get; set; }

		// Token: 0x1700C192 RID: 49554
		// (get) Token: 0x0602D198 RID: 184728 RVA: 0x0062AA68 File Offset: 0x00628C68
		// (set) Token: 0x0602D199 RID: 184729 RVA: 0x0062AA70 File Offset: 0x00628C70
		public ISpringArmFixConfigT SpringArmFix { get; set; }

		// Token: 0x1700C193 RID: 49555
		// (get) Token: 0x0602D19A RID: 184730 RVA: 0x0062AA79 File Offset: 0x00628C79
		// (set) Token: 0x0602D19B RID: 184731 RVA: 0x0062AA81 File Offset: 0x00628C81
		public bool HidePlayer { get; set; }

		// Token: 0x1700C194 RID: 49556
		// (get) Token: 0x0602D19C RID: 184732 RVA: 0x0062AA8A File Offset: 0x00628C8A
		// (set) Token: 0x0602D19D RID: 184733 RVA: 0x0062AA92 File Offset: 0x00628C92
		public ICameraLockConfigT LockConfig { get; set; }

		// Token: 0x1700C195 RID: 49557
		// (get) Token: 0x0602D19E RID: 184734 RVA: 0x0062AA9B File Offset: 0x00628C9B
		// (set) Token: 0x0602D19F RID: 184735 RVA: 0x0062AAA3 File Offset: 0x00628CA3
		public ushort NullMask { get; set; }

		// Token: 0x0602D1A0 RID: 184736 RVA: 0x0062AAAC File Offset: 0x00628CAC
		public IAdjustBasicCameraT()
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
			this.OverlayArmLength = 0f;
			this.SightUi = null;
			this.IsSynchronous = false;
			this.NearClipDistanceToTarget = 0f;
			this.SpringArmSoftZoneConfig = null;
			this.SpringArmFix = null;
			this.HidePlayer = false;
			this.LockConfig = null;
			this.NullMask = 0;
		}
	}
}
