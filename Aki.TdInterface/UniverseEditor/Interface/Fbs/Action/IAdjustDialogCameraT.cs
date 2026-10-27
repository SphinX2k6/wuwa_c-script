using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006147 RID: 24903
	public class IAdjustDialogCameraT
	{
		// Token: 0x1700B840 RID: 47168
		// (get) Token: 0x0602AAEF RID: 174831 RVA: 0x005E1C96 File Offset: 0x005DFE96
		// (set) Token: 0x0602AAF0 RID: 174832 RVA: 0x005E1C9E File Offset: 0x005DFE9E
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B841 RID: 47169
		// (get) Token: 0x0602AAF1 RID: 174833 RVA: 0x005E1CA7 File Offset: 0x005DFEA7
		// (set) Token: 0x0602AAF2 RID: 174834 RVA: 0x005E1CAF File Offset: 0x005DFEAF
		public int Priority { get; set; }

		// Token: 0x1700B842 RID: 47170
		// (get) Token: 0x0602AAF3 RID: 174835 RVA: 0x005E1CB8 File Offset: 0x005DFEB8
		// (set) Token: 0x0602AAF4 RID: 174836 RVA: 0x005E1CC0 File Offset: 0x005DFEC0
		public float FadeInTime { get; set; }

		// Token: 0x1700B843 RID: 47171
		// (get) Token: 0x0602AAF5 RID: 174837 RVA: 0x005E1CC9 File Offset: 0x005DFEC9
		// (set) Token: 0x0602AAF6 RID: 174838 RVA: 0x005E1CD1 File Offset: 0x005DFED1
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B844 RID: 47172
		// (get) Token: 0x0602AAF7 RID: 174839 RVA: 0x005E1CDA File Offset: 0x005DFEDA
		// (set) Token: 0x0602AAF8 RID: 174840 RVA: 0x005E1CE2 File Offset: 0x005DFEE2
		public float FadeOutTime { get; set; }

		// Token: 0x1700B845 RID: 47173
		// (get) Token: 0x0602AAF9 RID: 174841 RVA: 0x005E1CEB File Offset: 0x005DFEEB
		// (set) Token: 0x0602AAFA RID: 174842 RVA: 0x005E1CF3 File Offset: 0x005DFEF3
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B846 RID: 47174
		// (get) Token: 0x0602AAFB RID: 174843 RVA: 0x005E1CFC File Offset: 0x005DFEFC
		// (set) Token: 0x0602AAFC RID: 174844 RVA: 0x005E1D04 File Offset: 0x005DFF04
		public float ArmLength { get; set; }

		// Token: 0x1700B847 RID: 47175
		// (get) Token: 0x0602AAFD RID: 174845 RVA: 0x005E1D0D File Offset: 0x005DFF0D
		// (set) Token: 0x0602AAFE RID: 174846 RVA: 0x005E1D15 File Offset: 0x005DFF15
		public float MinumArmLength { get; set; }

		// Token: 0x1700B848 RID: 47176
		// (get) Token: 0x0602AAFF RID: 174847 RVA: 0x005E1D1E File Offset: 0x005DFF1E
		// (set) Token: 0x0602AB00 RID: 174848 RVA: 0x005E1D26 File Offset: 0x005DFF26
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B849 RID: 47177
		// (get) Token: 0x0602AB01 RID: 174849 RVA: 0x005E1D2F File Offset: 0x005DFF2F
		// (set) Token: 0x0602AB02 RID: 174850 RVA: 0x005E1D37 File Offset: 0x005DFF37
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B84A RID: 47178
		// (get) Token: 0x0602AB03 RID: 174851 RVA: 0x005E1D40 File Offset: 0x005DFF40
		// (set) Token: 0x0602AB04 RID: 174852 RVA: 0x005E1D48 File Offset: 0x005DFF48
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B84B RID: 47179
		// (get) Token: 0x0602AB05 RID: 174853 RVA: 0x005E1D51 File Offset: 0x005DFF51
		// (set) Token: 0x0602AB06 RID: 174854 RVA: 0x005E1D59 File Offset: 0x005DFF59
		public float YawLimitMin { get; set; }

		// Token: 0x1700B84C RID: 47180
		// (get) Token: 0x0602AB07 RID: 174855 RVA: 0x005E1D62 File Offset: 0x005DFF62
		// (set) Token: 0x0602AB08 RID: 174856 RVA: 0x005E1D6A File Offset: 0x005DFF6A
		public float YawLimitMax { get; set; }

		// Token: 0x1700B84D RID: 47181
		// (get) Token: 0x0602AB09 RID: 174857 RVA: 0x005E1D73 File Offset: 0x005DFF73
		// (set) Token: 0x0602AB0A RID: 174858 RVA: 0x005E1D7B File Offset: 0x005DFF7B
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B84E RID: 47182
		// (get) Token: 0x0602AB0B RID: 174859 RVA: 0x005E1D84 File Offset: 0x005DFF84
		// (set) Token: 0x0602AB0C RID: 174860 RVA: 0x005E1D8C File Offset: 0x005DFF8C
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B84F RID: 47183
		// (get) Token: 0x0602AB0D RID: 174861 RVA: 0x005E1D95 File Offset: 0x005DFF95
		// (set) Token: 0x0602AB0E RID: 174862 RVA: 0x005E1D9D File Offset: 0x005DFF9D
		public float Fov { get; set; }

		// Token: 0x1700B850 RID: 47184
		// (get) Token: 0x0602AB0F RID: 174863 RVA: 0x005E1DA6 File Offset: 0x005DFFA6
		// (set) Token: 0x0602AB10 RID: 174864 RVA: 0x005E1DAE File Offset: 0x005DFFAE
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B851 RID: 47185
		// (get) Token: 0x0602AB11 RID: 174865 RVA: 0x005E1DB7 File Offset: 0x005DFFB7
		// (set) Token: 0x0602AB12 RID: 174866 RVA: 0x005E1DBF File Offset: 0x005DFFBF
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B852 RID: 47186
		// (get) Token: 0x0602AB13 RID: 174867 RVA: 0x005E1DC8 File Offset: 0x005DFFC8
		// (set) Token: 0x0602AB14 RID: 174868 RVA: 0x005E1DD0 File Offset: 0x005DFFD0
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B853 RID: 47187
		// (get) Token: 0x0602AB15 RID: 174869 RVA: 0x005E1DD9 File Offset: 0x005DFFD9
		// (set) Token: 0x0602AB16 RID: 174870 RVA: 0x005E1DE1 File Offset: 0x005DFFE1
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B854 RID: 47188
		// (get) Token: 0x0602AB17 RID: 174871 RVA: 0x005E1DEA File Offset: 0x005DFFEA
		// (set) Token: 0x0602AB18 RID: 174872 RVA: 0x005E1DF2 File Offset: 0x005DFFF2
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B855 RID: 47189
		// (get) Token: 0x0602AB19 RID: 174873 RVA: 0x005E1DFB File Offset: 0x005DFFFB
		// (set) Token: 0x0602AB1A RID: 174874 RVA: 0x005E1E03 File Offset: 0x005E0003
		public float YawAngle { get; set; }

		// Token: 0x1700B856 RID: 47190
		// (get) Token: 0x0602AB1B RID: 174875 RVA: 0x005E1E0C File Offset: 0x005E000C
		// (set) Token: 0x0602AB1C RID: 174876 RVA: 0x005E1E14 File Offset: 0x005E0014
		public float PitchAngle { get; set; }

		// Token: 0x1700B857 RID: 47191
		// (get) Token: 0x0602AB1D RID: 174877 RVA: 0x005E1E1D File Offset: 0x005E001D
		// (set) Token: 0x0602AB1E RID: 174878 RVA: 0x005E1E25 File Offset: 0x005E0025
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700B858 RID: 47192
		// (get) Token: 0x0602AB1F RID: 174879 RVA: 0x005E1E2E File Offset: 0x005E002E
		// (set) Token: 0x0602AB20 RID: 174880 RVA: 0x005E1E36 File Offset: 0x005E0036
		public byte NullMask { get; set; }

		// Token: 0x0602AB21 RID: 174881 RVA: 0x005E1E40 File Offset: 0x005E0040
		public IAdjustDialogCameraT()
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
			this.YawAngle = 0f;
			this.PitchAngle = 0f;
			this.CenterPos = null;
			this.NullMask = 0;
		}
	}
}
