using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CA RID: 26570
	public class IAdjustHorizontalCameraT
	{
		// Token: 0x1700C2E6 RID: 49894
		// (get) Token: 0x0602D4FE RID: 185598 RVA: 0x0063457A File Offset: 0x0063277A
		// (set) Token: 0x0602D4FF RID: 185599 RVA: 0x00634582 File Offset: 0x00632782
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C2E7 RID: 49895
		// (get) Token: 0x0602D500 RID: 185600 RVA: 0x0063458B File Offset: 0x0063278B
		// (set) Token: 0x0602D501 RID: 185601 RVA: 0x00634593 File Offset: 0x00632793
		public int Priority { get; set; }

		// Token: 0x1700C2E8 RID: 49896
		// (get) Token: 0x0602D502 RID: 185602 RVA: 0x0063459C File Offset: 0x0063279C
		// (set) Token: 0x0602D503 RID: 185603 RVA: 0x006345A4 File Offset: 0x006327A4
		public float FadeInTime { get; set; }

		// Token: 0x1700C2E9 RID: 49897
		// (get) Token: 0x0602D504 RID: 185604 RVA: 0x006345AD File Offset: 0x006327AD
		// (set) Token: 0x0602D505 RID: 185605 RVA: 0x006345B5 File Offset: 0x006327B5
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C2EA RID: 49898
		// (get) Token: 0x0602D506 RID: 185606 RVA: 0x006345BE File Offset: 0x006327BE
		// (set) Token: 0x0602D507 RID: 185607 RVA: 0x006345C6 File Offset: 0x006327C6
		public float FadeOutTime { get; set; }

		// Token: 0x1700C2EB RID: 49899
		// (get) Token: 0x0602D508 RID: 185608 RVA: 0x006345CF File Offset: 0x006327CF
		// (set) Token: 0x0602D509 RID: 185609 RVA: 0x006345D7 File Offset: 0x006327D7
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C2EC RID: 49900
		// (get) Token: 0x0602D50A RID: 185610 RVA: 0x006345E0 File Offset: 0x006327E0
		// (set) Token: 0x0602D50B RID: 185611 RVA: 0x006345E8 File Offset: 0x006327E8
		public float ArmLength { get; set; }

		// Token: 0x1700C2ED RID: 49901
		// (get) Token: 0x0602D50C RID: 185612 RVA: 0x006345F1 File Offset: 0x006327F1
		// (set) Token: 0x0602D50D RID: 185613 RVA: 0x006345F9 File Offset: 0x006327F9
		public float MinumArmLength { get; set; }

		// Token: 0x1700C2EE RID: 49902
		// (get) Token: 0x0602D50E RID: 185614 RVA: 0x00634602 File Offset: 0x00632802
		// (set) Token: 0x0602D50F RID: 185615 RVA: 0x0063460A File Offset: 0x0063280A
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C2EF RID: 49903
		// (get) Token: 0x0602D510 RID: 185616 RVA: 0x00634613 File Offset: 0x00632813
		// (set) Token: 0x0602D511 RID: 185617 RVA: 0x0063461B File Offset: 0x0063281B
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C2F0 RID: 49904
		// (get) Token: 0x0602D512 RID: 185618 RVA: 0x00634624 File Offset: 0x00632824
		// (set) Token: 0x0602D513 RID: 185619 RVA: 0x0063462C File Offset: 0x0063282C
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C2F1 RID: 49905
		// (get) Token: 0x0602D514 RID: 185620 RVA: 0x00634635 File Offset: 0x00632835
		// (set) Token: 0x0602D515 RID: 185621 RVA: 0x0063463D File Offset: 0x0063283D
		public float YawLimitMin { get; set; }

		// Token: 0x1700C2F2 RID: 49906
		// (get) Token: 0x0602D516 RID: 185622 RVA: 0x00634646 File Offset: 0x00632846
		// (set) Token: 0x0602D517 RID: 185623 RVA: 0x0063464E File Offset: 0x0063284E
		public float YawLimitMax { get; set; }

		// Token: 0x1700C2F3 RID: 49907
		// (get) Token: 0x0602D518 RID: 185624 RVA: 0x00634657 File Offset: 0x00632857
		// (set) Token: 0x0602D519 RID: 185625 RVA: 0x0063465F File Offset: 0x0063285F
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C2F4 RID: 49908
		// (get) Token: 0x0602D51A RID: 185626 RVA: 0x00634668 File Offset: 0x00632868
		// (set) Token: 0x0602D51B RID: 185627 RVA: 0x00634670 File Offset: 0x00632870
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C2F5 RID: 49909
		// (get) Token: 0x0602D51C RID: 185628 RVA: 0x00634679 File Offset: 0x00632879
		// (set) Token: 0x0602D51D RID: 185629 RVA: 0x00634681 File Offset: 0x00632881
		public float Fov { get; set; }

		// Token: 0x1700C2F6 RID: 49910
		// (get) Token: 0x0602D51E RID: 185630 RVA: 0x0063468A File Offset: 0x0063288A
		// (set) Token: 0x0602D51F RID: 185631 RVA: 0x00634692 File Offset: 0x00632892
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C2F7 RID: 49911
		// (get) Token: 0x0602D520 RID: 185632 RVA: 0x0063469B File Offset: 0x0063289B
		// (set) Token: 0x0602D521 RID: 185633 RVA: 0x006346A3 File Offset: 0x006328A3
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C2F8 RID: 49912
		// (get) Token: 0x0602D522 RID: 185634 RVA: 0x006346AC File Offset: 0x006328AC
		// (set) Token: 0x0602D523 RID: 185635 RVA: 0x006346B4 File Offset: 0x006328B4
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C2F9 RID: 49913
		// (get) Token: 0x0602D524 RID: 185636 RVA: 0x006346BD File Offset: 0x006328BD
		// (set) Token: 0x0602D525 RID: 185637 RVA: 0x006346C5 File Offset: 0x006328C5
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C2FA RID: 49914
		// (get) Token: 0x0602D526 RID: 185638 RVA: 0x006346CE File Offset: 0x006328CE
		// (set) Token: 0x0602D527 RID: 185639 RVA: 0x006346D6 File Offset: 0x006328D6
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C2FB RID: 49915
		// (get) Token: 0x0602D528 RID: 185640 RVA: 0x006346DF File Offset: 0x006328DF
		// (set) Token: 0x0602D529 RID: 185641 RVA: 0x006346E7 File Offset: 0x006328E7
		public int SplineEntityId { get; set; }

		// Token: 0x1700C2FC RID: 49916
		// (get) Token: 0x0602D52A RID: 185642 RVA: 0x006346F0 File Offset: 0x006328F0
		// (set) Token: 0x0602D52B RID: 185643 RVA: 0x006346F8 File Offset: 0x006328F8
		public float YawAngle { get; set; }

		// Token: 0x1700C2FD RID: 49917
		// (get) Token: 0x0602D52C RID: 185644 RVA: 0x00634701 File Offset: 0x00632901
		// (set) Token: 0x0602D52D RID: 185645 RVA: 0x00634709 File Offset: 0x00632909
		public float PitchAngle { get; set; }

		// Token: 0x1700C2FE RID: 49918
		// (get) Token: 0x0602D52E RID: 185646 RVA: 0x00634712 File Offset: 0x00632912
		// (set) Token: 0x0602D52F RID: 185647 RVA: 0x0063471A File Offset: 0x0063291A
		public float RollAngle { get; set; }

		// Token: 0x1700C2FF RID: 49919
		// (get) Token: 0x0602D530 RID: 185648 RVA: 0x00634723 File Offset: 0x00632923
		// (set) Token: 0x0602D531 RID: 185649 RVA: 0x0063472B File Offset: 0x0063292B
		public ICameraDepthOfFieldT DepthOfField { get; set; }

		// Token: 0x1700C300 RID: 49920
		// (get) Token: 0x0602D532 RID: 185650 RVA: 0x00634734 File Offset: 0x00632934
		// (set) Token: 0x0602D533 RID: 185651 RVA: 0x0063473C File Offset: 0x0063293C
		public ICameraOffsetInMovementDirectionT OffsetInMovementDirection { get; set; }

		// Token: 0x1700C301 RID: 49921
		// (get) Token: 0x0602D534 RID: 185652 RVA: 0x00634745 File Offset: 0x00632945
		// (set) Token: 0x0602D535 RID: 185653 RVA: 0x0063474D File Offset: 0x0063294D
		public float NearClipDistanceToTarget { get; set; }

		// Token: 0x1700C302 RID: 49922
		// (get) Token: 0x0602D536 RID: 185654 RVA: 0x00634756 File Offset: 0x00632956
		// (set) Token: 0x0602D537 RID: 185655 RVA: 0x0063475E File Offset: 0x0063295E
		public ISpringArmSoftZoneConfigT SpringArmSoftZoneConfig { get; set; }

		// Token: 0x1700C303 RID: 49923
		// (get) Token: 0x0602D538 RID: 185656 RVA: 0x00634767 File Offset: 0x00632967
		// (set) Token: 0x0602D539 RID: 185657 RVA: 0x0063476F File Offset: 0x0063296F
		public ISpringArmFixConfigT SpringArmFix { get; set; }

		// Token: 0x1700C304 RID: 49924
		// (get) Token: 0x0602D53A RID: 185658 RVA: 0x00634778 File Offset: 0x00632978
		// (set) Token: 0x0602D53B RID: 185659 RVA: 0x00634780 File Offset: 0x00632980
		public bool IsCameraFollowSplineRoll { get; set; }

		// Token: 0x1700C305 RID: 49925
		// (get) Token: 0x0602D53C RID: 185660 RVA: 0x00634789 File Offset: 0x00632989
		// (set) Token: 0x0602D53D RID: 185661 RVA: 0x00634791 File Offset: 0x00632991
		public ushort NullMask { get; set; }

		// Token: 0x0602D53E RID: 185662 RVA: 0x0063479C File Offset: 0x0063299C
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
