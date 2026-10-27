using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006141 RID: 24897
	public class IAdjustAxisLockCameraT
	{
		// Token: 0x1700B7CC RID: 47052
		// (get) Token: 0x0602A9DD RID: 174557 RVA: 0x005DEE10 File Offset: 0x005DD010
		// (set) Token: 0x0602A9DE RID: 174558 RVA: 0x005DEE18 File Offset: 0x005DD018
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B7CD RID: 47053
		// (get) Token: 0x0602A9DF RID: 174559 RVA: 0x005DEE21 File Offset: 0x005DD021
		// (set) Token: 0x0602A9E0 RID: 174560 RVA: 0x005DEE29 File Offset: 0x005DD029
		public int Priority { get; set; }

		// Token: 0x1700B7CE RID: 47054
		// (get) Token: 0x0602A9E1 RID: 174561 RVA: 0x005DEE32 File Offset: 0x005DD032
		// (set) Token: 0x0602A9E2 RID: 174562 RVA: 0x005DEE3A File Offset: 0x005DD03A
		public float FadeInTime { get; set; }

		// Token: 0x1700B7CF RID: 47055
		// (get) Token: 0x0602A9E3 RID: 174563 RVA: 0x005DEE43 File Offset: 0x005DD043
		// (set) Token: 0x0602A9E4 RID: 174564 RVA: 0x005DEE4B File Offset: 0x005DD04B
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B7D0 RID: 47056
		// (get) Token: 0x0602A9E5 RID: 174565 RVA: 0x005DEE54 File Offset: 0x005DD054
		// (set) Token: 0x0602A9E6 RID: 174566 RVA: 0x005DEE5C File Offset: 0x005DD05C
		public float FadeOutTime { get; set; }

		// Token: 0x1700B7D1 RID: 47057
		// (get) Token: 0x0602A9E7 RID: 174567 RVA: 0x005DEE65 File Offset: 0x005DD065
		// (set) Token: 0x0602A9E8 RID: 174568 RVA: 0x005DEE6D File Offset: 0x005DD06D
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B7D2 RID: 47058
		// (get) Token: 0x0602A9E9 RID: 174569 RVA: 0x005DEE76 File Offset: 0x005DD076
		// (set) Token: 0x0602A9EA RID: 174570 RVA: 0x005DEE7E File Offset: 0x005DD07E
		public float ArmLength { get; set; }

		// Token: 0x1700B7D3 RID: 47059
		// (get) Token: 0x0602A9EB RID: 174571 RVA: 0x005DEE87 File Offset: 0x005DD087
		// (set) Token: 0x0602A9EC RID: 174572 RVA: 0x005DEE8F File Offset: 0x005DD08F
		public float MinumArmLength { get; set; }

		// Token: 0x1700B7D4 RID: 47060
		// (get) Token: 0x0602A9ED RID: 174573 RVA: 0x005DEE98 File Offset: 0x005DD098
		// (set) Token: 0x0602A9EE RID: 174574 RVA: 0x005DEEA0 File Offset: 0x005DD0A0
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B7D5 RID: 47061
		// (get) Token: 0x0602A9EF RID: 174575 RVA: 0x005DEEA9 File Offset: 0x005DD0A9
		// (set) Token: 0x0602A9F0 RID: 174576 RVA: 0x005DEEB1 File Offset: 0x005DD0B1
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B7D6 RID: 47062
		// (get) Token: 0x0602A9F1 RID: 174577 RVA: 0x005DEEBA File Offset: 0x005DD0BA
		// (set) Token: 0x0602A9F2 RID: 174578 RVA: 0x005DEEC2 File Offset: 0x005DD0C2
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B7D7 RID: 47063
		// (get) Token: 0x0602A9F3 RID: 174579 RVA: 0x005DEECB File Offset: 0x005DD0CB
		// (set) Token: 0x0602A9F4 RID: 174580 RVA: 0x005DEED3 File Offset: 0x005DD0D3
		public float YawLimitMin { get; set; }

		// Token: 0x1700B7D8 RID: 47064
		// (get) Token: 0x0602A9F5 RID: 174581 RVA: 0x005DEEDC File Offset: 0x005DD0DC
		// (set) Token: 0x0602A9F6 RID: 174582 RVA: 0x005DEEE4 File Offset: 0x005DD0E4
		public float YawLimitMax { get; set; }

		// Token: 0x1700B7D9 RID: 47065
		// (get) Token: 0x0602A9F7 RID: 174583 RVA: 0x005DEEED File Offset: 0x005DD0ED
		// (set) Token: 0x0602A9F8 RID: 174584 RVA: 0x005DEEF5 File Offset: 0x005DD0F5
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B7DA RID: 47066
		// (get) Token: 0x0602A9F9 RID: 174585 RVA: 0x005DEEFE File Offset: 0x005DD0FE
		// (set) Token: 0x0602A9FA RID: 174586 RVA: 0x005DEF06 File Offset: 0x005DD106
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B7DB RID: 47067
		// (get) Token: 0x0602A9FB RID: 174587 RVA: 0x005DEF0F File Offset: 0x005DD10F
		// (set) Token: 0x0602A9FC RID: 174588 RVA: 0x005DEF17 File Offset: 0x005DD117
		public float Fov { get; set; }

		// Token: 0x1700B7DC RID: 47068
		// (get) Token: 0x0602A9FD RID: 174589 RVA: 0x005DEF20 File Offset: 0x005DD120
		// (set) Token: 0x0602A9FE RID: 174590 RVA: 0x005DEF28 File Offset: 0x005DD128
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B7DD RID: 47069
		// (get) Token: 0x0602A9FF RID: 174591 RVA: 0x005DEF31 File Offset: 0x005DD131
		// (set) Token: 0x0602AA00 RID: 174592 RVA: 0x005DEF39 File Offset: 0x005DD139
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B7DE RID: 47070
		// (get) Token: 0x0602AA01 RID: 174593 RVA: 0x005DEF42 File Offset: 0x005DD142
		// (set) Token: 0x0602AA02 RID: 174594 RVA: 0x005DEF4A File Offset: 0x005DD14A
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B7DF RID: 47071
		// (get) Token: 0x0602AA03 RID: 174595 RVA: 0x005DEF53 File Offset: 0x005DD153
		// (set) Token: 0x0602AA04 RID: 174596 RVA: 0x005DEF5B File Offset: 0x005DD15B
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B7E0 RID: 47072
		// (get) Token: 0x0602AA05 RID: 174597 RVA: 0x005DEF64 File Offset: 0x005DD164
		// (set) Token: 0x0602AA06 RID: 174598 RVA: 0x005DEF6C File Offset: 0x005DD16C
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B7E1 RID: 47073
		// (get) Token: 0x0602AA07 RID: 174599 RVA: 0x005DEF75 File Offset: 0x005DD175
		// (set) Token: 0x0602AA08 RID: 174600 RVA: 0x005DEF7D File Offset: 0x005DD17D
		public IVectorInfoT AxisRotate { get; set; }

		// Token: 0x1700B7E2 RID: 47074
		// (get) Token: 0x0602AA09 RID: 174601 RVA: 0x005DEF86 File Offset: 0x005DD186
		// (set) Token: 0x0602AA0A RID: 174602 RVA: 0x005DEF8E File Offset: 0x005DD18E
		public bool IsLockRoll { get; set; }

		// Token: 0x1700B7E3 RID: 47075
		// (get) Token: 0x0602AA0B RID: 174603 RVA: 0x005DEF97 File Offset: 0x005DD197
		// (set) Token: 0x0602AA0C RID: 174604 RVA: 0x005DEF9F File Offset: 0x005DD19F
		public IAxisLockScreenConfigT ScreenConfig { get; set; }

		// Token: 0x1700B7E4 RID: 47076
		// (get) Token: 0x0602AA0D RID: 174605 RVA: 0x005DEFA8 File Offset: 0x005DD1A8
		// (set) Token: 0x0602AA0E RID: 174606 RVA: 0x005DEFB0 File Offset: 0x005DD1B0
		public float NearClipDistanceToTarget { get; set; }

		// Token: 0x1700B7E5 RID: 47077
		// (get) Token: 0x0602AA0F RID: 174607 RVA: 0x005DEFB9 File Offset: 0x005DD1B9
		// (set) Token: 0x0602AA10 RID: 174608 RVA: 0x005DEFC1 File Offset: 0x005DD1C1
		public ISpringArmSoftZoneConfigT SpringArmSoftZoneConfig { get; set; }

		// Token: 0x1700B7E6 RID: 47078
		// (get) Token: 0x0602AA11 RID: 174609 RVA: 0x005DEFCA File Offset: 0x005DD1CA
		// (set) Token: 0x0602AA12 RID: 174610 RVA: 0x005DEFD2 File Offset: 0x005DD1D2
		public ISpringArmFixConfigT SpringArmFix { get; set; }

		// Token: 0x1700B7E7 RID: 47079
		// (get) Token: 0x0602AA13 RID: 174611 RVA: 0x005DEFDB File Offset: 0x005DD1DB
		// (set) Token: 0x0602AA14 RID: 174612 RVA: 0x005DEFE3 File Offset: 0x005DD1E3
		public bool HidePlayer { get; set; }

		// Token: 0x1700B7E8 RID: 47080
		// (get) Token: 0x0602AA15 RID: 174613 RVA: 0x005DEFEC File Offset: 0x005DD1EC
		// (set) Token: 0x0602AA16 RID: 174614 RVA: 0x005DEFF4 File Offset: 0x005DD1F4
		public ushort NullMask { get; set; }

		// Token: 0x0602AA17 RID: 174615 RVA: 0x005DF000 File Offset: 0x005DD200
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
