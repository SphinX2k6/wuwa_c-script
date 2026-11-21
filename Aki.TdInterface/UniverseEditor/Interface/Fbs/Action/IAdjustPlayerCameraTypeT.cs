using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D3 RID: 26579
	public class IAdjustPlayerCameraTypeT
	{
		// Token: 0x1700C327 RID: 49959
		// (get) Token: 0x0602D5BF RID: 185791 RVA: 0x00636482 File Offset: 0x00634682
		// (set) Token: 0x0602D5C0 RID: 185792 RVA: 0x0063648A File Offset: 0x0063468A
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C328 RID: 49960
		// (get) Token: 0x0602D5C1 RID: 185793 RVA: 0x00636493 File Offset: 0x00634693
		// (set) Token: 0x0602D5C2 RID: 185794 RVA: 0x0063649B File Offset: 0x0063469B
		public int Priority { get; set; }

		// Token: 0x1700C329 RID: 49961
		// (get) Token: 0x0602D5C3 RID: 185795 RVA: 0x006364A4 File Offset: 0x006346A4
		// (set) Token: 0x0602D5C4 RID: 185796 RVA: 0x006364AC File Offset: 0x006346AC
		public float FadeInTime { get; set; }

		// Token: 0x1700C32A RID: 49962
		// (get) Token: 0x0602D5C5 RID: 185797 RVA: 0x006364B5 File Offset: 0x006346B5
		// (set) Token: 0x0602D5C6 RID: 185798 RVA: 0x006364BD File Offset: 0x006346BD
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C32B RID: 49963
		// (get) Token: 0x0602D5C7 RID: 185799 RVA: 0x006364C6 File Offset: 0x006346C6
		// (set) Token: 0x0602D5C8 RID: 185800 RVA: 0x006364CE File Offset: 0x006346CE
		public float FadeOutTime { get; set; }

		// Token: 0x1700C32C RID: 49964
		// (get) Token: 0x0602D5C9 RID: 185801 RVA: 0x006364D7 File Offset: 0x006346D7
		// (set) Token: 0x0602D5CA RID: 185802 RVA: 0x006364DF File Offset: 0x006346DF
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C32D RID: 49965
		// (get) Token: 0x0602D5CB RID: 185803 RVA: 0x006364E8 File Offset: 0x006346E8
		// (set) Token: 0x0602D5CC RID: 185804 RVA: 0x006364F0 File Offset: 0x006346F0
		public float ArmLength { get; set; }

		// Token: 0x1700C32E RID: 49966
		// (get) Token: 0x0602D5CD RID: 185805 RVA: 0x006364F9 File Offset: 0x006346F9
		// (set) Token: 0x0602D5CE RID: 185806 RVA: 0x00636501 File Offset: 0x00634701
		public float MinumArmLength { get; set; }

		// Token: 0x1700C32F RID: 49967
		// (get) Token: 0x0602D5CF RID: 185807 RVA: 0x0063650A File Offset: 0x0063470A
		// (set) Token: 0x0602D5D0 RID: 185808 RVA: 0x00636512 File Offset: 0x00634712
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C330 RID: 49968
		// (get) Token: 0x0602D5D1 RID: 185809 RVA: 0x0063651B File Offset: 0x0063471B
		// (set) Token: 0x0602D5D2 RID: 185810 RVA: 0x00636523 File Offset: 0x00634723
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C331 RID: 49969
		// (get) Token: 0x0602D5D3 RID: 185811 RVA: 0x0063652C File Offset: 0x0063472C
		// (set) Token: 0x0602D5D4 RID: 185812 RVA: 0x00636534 File Offset: 0x00634734
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C332 RID: 49970
		// (get) Token: 0x0602D5D5 RID: 185813 RVA: 0x0063653D File Offset: 0x0063473D
		// (set) Token: 0x0602D5D6 RID: 185814 RVA: 0x00636545 File Offset: 0x00634745
		public float YawLimitMin { get; set; }

		// Token: 0x1700C333 RID: 49971
		// (get) Token: 0x0602D5D7 RID: 185815 RVA: 0x0063654E File Offset: 0x0063474E
		// (set) Token: 0x0602D5D8 RID: 185816 RVA: 0x00636556 File Offset: 0x00634756
		public float YawLimitMax { get; set; }

		// Token: 0x1700C334 RID: 49972
		// (get) Token: 0x0602D5D9 RID: 185817 RVA: 0x0063655F File Offset: 0x0063475F
		// (set) Token: 0x0602D5DA RID: 185818 RVA: 0x00636567 File Offset: 0x00634767
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C335 RID: 49973
		// (get) Token: 0x0602D5DB RID: 185819 RVA: 0x00636570 File Offset: 0x00634770
		// (set) Token: 0x0602D5DC RID: 185820 RVA: 0x00636578 File Offset: 0x00634778
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C336 RID: 49974
		// (get) Token: 0x0602D5DD RID: 185821 RVA: 0x00636581 File Offset: 0x00634781
		// (set) Token: 0x0602D5DE RID: 185822 RVA: 0x00636589 File Offset: 0x00634789
		public float Fov { get; set; }

		// Token: 0x1700C337 RID: 49975
		// (get) Token: 0x0602D5DF RID: 185823 RVA: 0x00636592 File Offset: 0x00634792
		// (set) Token: 0x0602D5E0 RID: 185824 RVA: 0x0063659A File Offset: 0x0063479A
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C338 RID: 49976
		// (get) Token: 0x0602D5E1 RID: 185825 RVA: 0x006365A3 File Offset: 0x006347A3
		// (set) Token: 0x0602D5E2 RID: 185826 RVA: 0x006365AB File Offset: 0x006347AB
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C339 RID: 49977
		// (get) Token: 0x0602D5E3 RID: 185827 RVA: 0x006365B4 File Offset: 0x006347B4
		// (set) Token: 0x0602D5E4 RID: 185828 RVA: 0x006365BC File Offset: 0x006347BC
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C33A RID: 49978
		// (get) Token: 0x0602D5E5 RID: 185829 RVA: 0x006365C5 File Offset: 0x006347C5
		// (set) Token: 0x0602D5E6 RID: 185830 RVA: 0x006365CD File Offset: 0x006347CD
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C33B RID: 49979
		// (get) Token: 0x0602D5E7 RID: 185831 RVA: 0x006365D6 File Offset: 0x006347D6
		// (set) Token: 0x0602D5E8 RID: 185832 RVA: 0x006365DE File Offset: 0x006347DE
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C33C RID: 49980
		// (get) Token: 0x0602D5E9 RID: 185833 RVA: 0x006365E7 File Offset: 0x006347E7
		// (set) Token: 0x0602D5EA RID: 185834 RVA: 0x006365EF File Offset: 0x006347EF
		public byte NullMask { get; set; }

		// Token: 0x0602D5EB RID: 185835 RVA: 0x006365F8 File Offset: 0x006347F8
		public IAdjustPlayerCameraTypeT()
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
			this.NullMask = 0;
		}
	}
}
