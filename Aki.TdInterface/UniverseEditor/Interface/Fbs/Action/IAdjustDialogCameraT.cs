using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AC RID: 26540
	public class IAdjustDialogCameraT
	{
		// Token: 0x1700C1B0 RID: 49584
		// (get) Token: 0x0602D1E8 RID: 184808 RVA: 0x0062BE72 File Offset: 0x0062A072
		// (set) Token: 0x0602D1E9 RID: 184809 RVA: 0x0062BE7A File Offset: 0x0062A07A
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C1B1 RID: 49585
		// (get) Token: 0x0602D1EA RID: 184810 RVA: 0x0062BE83 File Offset: 0x0062A083
		// (set) Token: 0x0602D1EB RID: 184811 RVA: 0x0062BE8B File Offset: 0x0062A08B
		public int Priority { get; set; }

		// Token: 0x1700C1B2 RID: 49586
		// (get) Token: 0x0602D1EC RID: 184812 RVA: 0x0062BE94 File Offset: 0x0062A094
		// (set) Token: 0x0602D1ED RID: 184813 RVA: 0x0062BE9C File Offset: 0x0062A09C
		public float FadeInTime { get; set; }

		// Token: 0x1700C1B3 RID: 49587
		// (get) Token: 0x0602D1EE RID: 184814 RVA: 0x0062BEA5 File Offset: 0x0062A0A5
		// (set) Token: 0x0602D1EF RID: 184815 RVA: 0x0062BEAD File Offset: 0x0062A0AD
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C1B4 RID: 49588
		// (get) Token: 0x0602D1F0 RID: 184816 RVA: 0x0062BEB6 File Offset: 0x0062A0B6
		// (set) Token: 0x0602D1F1 RID: 184817 RVA: 0x0062BEBE File Offset: 0x0062A0BE
		public float FadeOutTime { get; set; }

		// Token: 0x1700C1B5 RID: 49589
		// (get) Token: 0x0602D1F2 RID: 184818 RVA: 0x0062BEC7 File Offset: 0x0062A0C7
		// (set) Token: 0x0602D1F3 RID: 184819 RVA: 0x0062BECF File Offset: 0x0062A0CF
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C1B6 RID: 49590
		// (get) Token: 0x0602D1F4 RID: 184820 RVA: 0x0062BED8 File Offset: 0x0062A0D8
		// (set) Token: 0x0602D1F5 RID: 184821 RVA: 0x0062BEE0 File Offset: 0x0062A0E0
		public float ArmLength { get; set; }

		// Token: 0x1700C1B7 RID: 49591
		// (get) Token: 0x0602D1F6 RID: 184822 RVA: 0x0062BEE9 File Offset: 0x0062A0E9
		// (set) Token: 0x0602D1F7 RID: 184823 RVA: 0x0062BEF1 File Offset: 0x0062A0F1
		public float MinumArmLength { get; set; }

		// Token: 0x1700C1B8 RID: 49592
		// (get) Token: 0x0602D1F8 RID: 184824 RVA: 0x0062BEFA File Offset: 0x0062A0FA
		// (set) Token: 0x0602D1F9 RID: 184825 RVA: 0x0062BF02 File Offset: 0x0062A102
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C1B9 RID: 49593
		// (get) Token: 0x0602D1FA RID: 184826 RVA: 0x0062BF0B File Offset: 0x0062A10B
		// (set) Token: 0x0602D1FB RID: 184827 RVA: 0x0062BF13 File Offset: 0x0062A113
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C1BA RID: 49594
		// (get) Token: 0x0602D1FC RID: 184828 RVA: 0x0062BF1C File Offset: 0x0062A11C
		// (set) Token: 0x0602D1FD RID: 184829 RVA: 0x0062BF24 File Offset: 0x0062A124
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C1BB RID: 49595
		// (get) Token: 0x0602D1FE RID: 184830 RVA: 0x0062BF2D File Offset: 0x0062A12D
		// (set) Token: 0x0602D1FF RID: 184831 RVA: 0x0062BF35 File Offset: 0x0062A135
		public float YawLimitMin { get; set; }

		// Token: 0x1700C1BC RID: 49596
		// (get) Token: 0x0602D200 RID: 184832 RVA: 0x0062BF3E File Offset: 0x0062A13E
		// (set) Token: 0x0602D201 RID: 184833 RVA: 0x0062BF46 File Offset: 0x0062A146
		public float YawLimitMax { get; set; }

		// Token: 0x1700C1BD RID: 49597
		// (get) Token: 0x0602D202 RID: 184834 RVA: 0x0062BF4F File Offset: 0x0062A14F
		// (set) Token: 0x0602D203 RID: 184835 RVA: 0x0062BF57 File Offset: 0x0062A157
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C1BE RID: 49598
		// (get) Token: 0x0602D204 RID: 184836 RVA: 0x0062BF60 File Offset: 0x0062A160
		// (set) Token: 0x0602D205 RID: 184837 RVA: 0x0062BF68 File Offset: 0x0062A168
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C1BF RID: 49599
		// (get) Token: 0x0602D206 RID: 184838 RVA: 0x0062BF71 File Offset: 0x0062A171
		// (set) Token: 0x0602D207 RID: 184839 RVA: 0x0062BF79 File Offset: 0x0062A179
		public float Fov { get; set; }

		// Token: 0x1700C1C0 RID: 49600
		// (get) Token: 0x0602D208 RID: 184840 RVA: 0x0062BF82 File Offset: 0x0062A182
		// (set) Token: 0x0602D209 RID: 184841 RVA: 0x0062BF8A File Offset: 0x0062A18A
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C1C1 RID: 49601
		// (get) Token: 0x0602D20A RID: 184842 RVA: 0x0062BF93 File Offset: 0x0062A193
		// (set) Token: 0x0602D20B RID: 184843 RVA: 0x0062BF9B File Offset: 0x0062A19B
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C1C2 RID: 49602
		// (get) Token: 0x0602D20C RID: 184844 RVA: 0x0062BFA4 File Offset: 0x0062A1A4
		// (set) Token: 0x0602D20D RID: 184845 RVA: 0x0062BFAC File Offset: 0x0062A1AC
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C1C3 RID: 49603
		// (get) Token: 0x0602D20E RID: 184846 RVA: 0x0062BFB5 File Offset: 0x0062A1B5
		// (set) Token: 0x0602D20F RID: 184847 RVA: 0x0062BFBD File Offset: 0x0062A1BD
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C1C4 RID: 49604
		// (get) Token: 0x0602D210 RID: 184848 RVA: 0x0062BFC6 File Offset: 0x0062A1C6
		// (set) Token: 0x0602D211 RID: 184849 RVA: 0x0062BFCE File Offset: 0x0062A1CE
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C1C5 RID: 49605
		// (get) Token: 0x0602D212 RID: 184850 RVA: 0x0062BFD7 File Offset: 0x0062A1D7
		// (set) Token: 0x0602D213 RID: 184851 RVA: 0x0062BFDF File Offset: 0x0062A1DF
		public float YawAngle { get; set; }

		// Token: 0x1700C1C6 RID: 49606
		// (get) Token: 0x0602D214 RID: 184852 RVA: 0x0062BFE8 File Offset: 0x0062A1E8
		// (set) Token: 0x0602D215 RID: 184853 RVA: 0x0062BFF0 File Offset: 0x0062A1F0
		public float PitchAngle { get; set; }

		// Token: 0x1700C1C7 RID: 49607
		// (get) Token: 0x0602D216 RID: 184854 RVA: 0x0062BFF9 File Offset: 0x0062A1F9
		// (set) Token: 0x0602D217 RID: 184855 RVA: 0x0062C001 File Offset: 0x0062A201
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700C1C8 RID: 49608
		// (get) Token: 0x0602D218 RID: 184856 RVA: 0x0062C00A File Offset: 0x0062A20A
		// (set) Token: 0x0602D219 RID: 184857 RVA: 0x0062C012 File Offset: 0x0062A212
		public byte NullMask { get; set; }

		// Token: 0x0602D21A RID: 184858 RVA: 0x0062C01C File Offset: 0x0062A21C
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
