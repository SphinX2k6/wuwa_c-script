using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006144 RID: 24900
	public class IAdjustBasicCameraT
	{
		// Token: 0x1700B808 RID: 47112
		// (get) Token: 0x0602AA6B RID: 174699 RVA: 0x005E06D2 File Offset: 0x005DE8D2
		// (set) Token: 0x0602AA6C RID: 174700 RVA: 0x005E06DA File Offset: 0x005DE8DA
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B809 RID: 47113
		// (get) Token: 0x0602AA6D RID: 174701 RVA: 0x005E06E3 File Offset: 0x005DE8E3
		// (set) Token: 0x0602AA6E RID: 174702 RVA: 0x005E06EB File Offset: 0x005DE8EB
		public int Priority { get; set; }

		// Token: 0x1700B80A RID: 47114
		// (get) Token: 0x0602AA6F RID: 174703 RVA: 0x005E06F4 File Offset: 0x005DE8F4
		// (set) Token: 0x0602AA70 RID: 174704 RVA: 0x005E06FC File Offset: 0x005DE8FC
		public float FadeInTime { get; set; }

		// Token: 0x1700B80B RID: 47115
		// (get) Token: 0x0602AA71 RID: 174705 RVA: 0x005E0705 File Offset: 0x005DE905
		// (set) Token: 0x0602AA72 RID: 174706 RVA: 0x005E070D File Offset: 0x005DE90D
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B80C RID: 47116
		// (get) Token: 0x0602AA73 RID: 174707 RVA: 0x005E0716 File Offset: 0x005DE916
		// (set) Token: 0x0602AA74 RID: 174708 RVA: 0x005E071E File Offset: 0x005DE91E
		public float FadeOutTime { get; set; }

		// Token: 0x1700B80D RID: 47117
		// (get) Token: 0x0602AA75 RID: 174709 RVA: 0x005E0727 File Offset: 0x005DE927
		// (set) Token: 0x0602AA76 RID: 174710 RVA: 0x005E072F File Offset: 0x005DE92F
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B80E RID: 47118
		// (get) Token: 0x0602AA77 RID: 174711 RVA: 0x005E0738 File Offset: 0x005DE938
		// (set) Token: 0x0602AA78 RID: 174712 RVA: 0x005E0740 File Offset: 0x005DE940
		public float ArmLength { get; set; }

		// Token: 0x1700B80F RID: 47119
		// (get) Token: 0x0602AA79 RID: 174713 RVA: 0x005E0749 File Offset: 0x005DE949
		// (set) Token: 0x0602AA7A RID: 174714 RVA: 0x005E0751 File Offset: 0x005DE951
		public float MinumArmLength { get; set; }

		// Token: 0x1700B810 RID: 47120
		// (get) Token: 0x0602AA7B RID: 174715 RVA: 0x005E075A File Offset: 0x005DE95A
		// (set) Token: 0x0602AA7C RID: 174716 RVA: 0x005E0762 File Offset: 0x005DE962
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B811 RID: 47121
		// (get) Token: 0x0602AA7D RID: 174717 RVA: 0x005E076B File Offset: 0x005DE96B
		// (set) Token: 0x0602AA7E RID: 174718 RVA: 0x005E0773 File Offset: 0x005DE973
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B812 RID: 47122
		// (get) Token: 0x0602AA7F RID: 174719 RVA: 0x005E077C File Offset: 0x005DE97C
		// (set) Token: 0x0602AA80 RID: 174720 RVA: 0x005E0784 File Offset: 0x005DE984
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B813 RID: 47123
		// (get) Token: 0x0602AA81 RID: 174721 RVA: 0x005E078D File Offset: 0x005DE98D
		// (set) Token: 0x0602AA82 RID: 174722 RVA: 0x005E0795 File Offset: 0x005DE995
		public float YawLimitMin { get; set; }

		// Token: 0x1700B814 RID: 47124
		// (get) Token: 0x0602AA83 RID: 174723 RVA: 0x005E079E File Offset: 0x005DE99E
		// (set) Token: 0x0602AA84 RID: 174724 RVA: 0x005E07A6 File Offset: 0x005DE9A6
		public float YawLimitMax { get; set; }

		// Token: 0x1700B815 RID: 47125
		// (get) Token: 0x0602AA85 RID: 174725 RVA: 0x005E07AF File Offset: 0x005DE9AF
		// (set) Token: 0x0602AA86 RID: 174726 RVA: 0x005E07B7 File Offset: 0x005DE9B7
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B816 RID: 47126
		// (get) Token: 0x0602AA87 RID: 174727 RVA: 0x005E07C0 File Offset: 0x005DE9C0
		// (set) Token: 0x0602AA88 RID: 174728 RVA: 0x005E07C8 File Offset: 0x005DE9C8
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B817 RID: 47127
		// (get) Token: 0x0602AA89 RID: 174729 RVA: 0x005E07D1 File Offset: 0x005DE9D1
		// (set) Token: 0x0602AA8A RID: 174730 RVA: 0x005E07D9 File Offset: 0x005DE9D9
		public float Fov { get; set; }

		// Token: 0x1700B818 RID: 47128
		// (get) Token: 0x0602AA8B RID: 174731 RVA: 0x005E07E2 File Offset: 0x005DE9E2
		// (set) Token: 0x0602AA8C RID: 174732 RVA: 0x005E07EA File Offset: 0x005DE9EA
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B819 RID: 47129
		// (get) Token: 0x0602AA8D RID: 174733 RVA: 0x005E07F3 File Offset: 0x005DE9F3
		// (set) Token: 0x0602AA8E RID: 174734 RVA: 0x005E07FB File Offset: 0x005DE9FB
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B81A RID: 47130
		// (get) Token: 0x0602AA8F RID: 174735 RVA: 0x005E0804 File Offset: 0x005DEA04
		// (set) Token: 0x0602AA90 RID: 174736 RVA: 0x005E080C File Offset: 0x005DEA0C
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B81B RID: 47131
		// (get) Token: 0x0602AA91 RID: 174737 RVA: 0x005E0815 File Offset: 0x005DEA15
		// (set) Token: 0x0602AA92 RID: 174738 RVA: 0x005E081D File Offset: 0x005DEA1D
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B81C RID: 47132
		// (get) Token: 0x0602AA93 RID: 174739 RVA: 0x005E0826 File Offset: 0x005DEA26
		// (set) Token: 0x0602AA94 RID: 174740 RVA: 0x005E082E File Offset: 0x005DEA2E
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B81D RID: 47133
		// (get) Token: 0x0602AA95 RID: 174741 RVA: 0x005E0837 File Offset: 0x005DEA37
		// (set) Token: 0x0602AA96 RID: 174742 RVA: 0x005E083F File Offset: 0x005DEA3F
		public float OverlayArmLength { get; set; }

		// Token: 0x1700B81E RID: 47134
		// (get) Token: 0x0602AA97 RID: 174743 RVA: 0x005E0848 File Offset: 0x005DEA48
		// (set) Token: 0x0602AA98 RID: 174744 RVA: 0x005E0850 File Offset: 0x005DEA50
		public string SightUi { get; set; }

		// Token: 0x1700B81F RID: 47135
		// (get) Token: 0x0602AA99 RID: 174745 RVA: 0x005E0859 File Offset: 0x005DEA59
		// (set) Token: 0x0602AA9A RID: 174746 RVA: 0x005E0861 File Offset: 0x005DEA61
		public bool IsSynchronous { get; set; }

		// Token: 0x1700B820 RID: 47136
		// (get) Token: 0x0602AA9B RID: 174747 RVA: 0x005E086A File Offset: 0x005DEA6A
		// (set) Token: 0x0602AA9C RID: 174748 RVA: 0x005E0872 File Offset: 0x005DEA72
		public float NearClipDistanceToTarget { get; set; }

		// Token: 0x1700B821 RID: 47137
		// (get) Token: 0x0602AA9D RID: 174749 RVA: 0x005E087B File Offset: 0x005DEA7B
		// (set) Token: 0x0602AA9E RID: 174750 RVA: 0x005E0883 File Offset: 0x005DEA83
		public ISpringArmSoftZoneConfigT SpringArmSoftZoneConfig { get; set; }

		// Token: 0x1700B822 RID: 47138
		// (get) Token: 0x0602AA9F RID: 174751 RVA: 0x005E088C File Offset: 0x005DEA8C
		// (set) Token: 0x0602AAA0 RID: 174752 RVA: 0x005E0894 File Offset: 0x005DEA94
		public ISpringArmFixConfigT SpringArmFix { get; set; }

		// Token: 0x1700B823 RID: 47139
		// (get) Token: 0x0602AAA1 RID: 174753 RVA: 0x005E089D File Offset: 0x005DEA9D
		// (set) Token: 0x0602AAA2 RID: 174754 RVA: 0x005E08A5 File Offset: 0x005DEAA5
		public bool HidePlayer { get; set; }

		// Token: 0x1700B824 RID: 47140
		// (get) Token: 0x0602AAA3 RID: 174755 RVA: 0x005E08AE File Offset: 0x005DEAAE
		// (set) Token: 0x0602AAA4 RID: 174756 RVA: 0x005E08B6 File Offset: 0x005DEAB6
		public ICameraLockConfigT LockConfig { get; set; }

		// Token: 0x1700B825 RID: 47141
		// (get) Token: 0x0602AAA5 RID: 174757 RVA: 0x005E08BF File Offset: 0x005DEABF
		// (set) Token: 0x0602AAA6 RID: 174758 RVA: 0x005E08C7 File Offset: 0x005DEAC7
		public ushort NullMask { get; set; }

		// Token: 0x0602AAA7 RID: 174759 RVA: 0x005E08D0 File Offset: 0x005DEAD0
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
