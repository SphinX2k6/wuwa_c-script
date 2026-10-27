using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200616E RID: 24942
	public class IAdjustPlayerCameraTypeT
	{
		// Token: 0x1700B9B7 RID: 47543
		// (get) Token: 0x0602AEC6 RID: 175814 RVA: 0x005EC2A6 File Offset: 0x005EA4A6
		// (set) Token: 0x0602AEC7 RID: 175815 RVA: 0x005EC2AE File Offset: 0x005EA4AE
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B9B8 RID: 47544
		// (get) Token: 0x0602AEC8 RID: 175816 RVA: 0x005EC2B7 File Offset: 0x005EA4B7
		// (set) Token: 0x0602AEC9 RID: 175817 RVA: 0x005EC2BF File Offset: 0x005EA4BF
		public int Priority { get; set; }

		// Token: 0x1700B9B9 RID: 47545
		// (get) Token: 0x0602AECA RID: 175818 RVA: 0x005EC2C8 File Offset: 0x005EA4C8
		// (set) Token: 0x0602AECB RID: 175819 RVA: 0x005EC2D0 File Offset: 0x005EA4D0
		public float FadeInTime { get; set; }

		// Token: 0x1700B9BA RID: 47546
		// (get) Token: 0x0602AECC RID: 175820 RVA: 0x005EC2D9 File Offset: 0x005EA4D9
		// (set) Token: 0x0602AECD RID: 175821 RVA: 0x005EC2E1 File Offset: 0x005EA4E1
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B9BB RID: 47547
		// (get) Token: 0x0602AECE RID: 175822 RVA: 0x005EC2EA File Offset: 0x005EA4EA
		// (set) Token: 0x0602AECF RID: 175823 RVA: 0x005EC2F2 File Offset: 0x005EA4F2
		public float FadeOutTime { get; set; }

		// Token: 0x1700B9BC RID: 47548
		// (get) Token: 0x0602AED0 RID: 175824 RVA: 0x005EC2FB File Offset: 0x005EA4FB
		// (set) Token: 0x0602AED1 RID: 175825 RVA: 0x005EC303 File Offset: 0x005EA503
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B9BD RID: 47549
		// (get) Token: 0x0602AED2 RID: 175826 RVA: 0x005EC30C File Offset: 0x005EA50C
		// (set) Token: 0x0602AED3 RID: 175827 RVA: 0x005EC314 File Offset: 0x005EA514
		public float ArmLength { get; set; }

		// Token: 0x1700B9BE RID: 47550
		// (get) Token: 0x0602AED4 RID: 175828 RVA: 0x005EC31D File Offset: 0x005EA51D
		// (set) Token: 0x0602AED5 RID: 175829 RVA: 0x005EC325 File Offset: 0x005EA525
		public float MinumArmLength { get; set; }

		// Token: 0x1700B9BF RID: 47551
		// (get) Token: 0x0602AED6 RID: 175830 RVA: 0x005EC32E File Offset: 0x005EA52E
		// (set) Token: 0x0602AED7 RID: 175831 RVA: 0x005EC336 File Offset: 0x005EA536
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B9C0 RID: 47552
		// (get) Token: 0x0602AED8 RID: 175832 RVA: 0x005EC33F File Offset: 0x005EA53F
		// (set) Token: 0x0602AED9 RID: 175833 RVA: 0x005EC347 File Offset: 0x005EA547
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B9C1 RID: 47553
		// (get) Token: 0x0602AEDA RID: 175834 RVA: 0x005EC350 File Offset: 0x005EA550
		// (set) Token: 0x0602AEDB RID: 175835 RVA: 0x005EC358 File Offset: 0x005EA558
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B9C2 RID: 47554
		// (get) Token: 0x0602AEDC RID: 175836 RVA: 0x005EC361 File Offset: 0x005EA561
		// (set) Token: 0x0602AEDD RID: 175837 RVA: 0x005EC369 File Offset: 0x005EA569
		public float YawLimitMin { get; set; }

		// Token: 0x1700B9C3 RID: 47555
		// (get) Token: 0x0602AEDE RID: 175838 RVA: 0x005EC372 File Offset: 0x005EA572
		// (set) Token: 0x0602AEDF RID: 175839 RVA: 0x005EC37A File Offset: 0x005EA57A
		public float YawLimitMax { get; set; }

		// Token: 0x1700B9C4 RID: 47556
		// (get) Token: 0x0602AEE0 RID: 175840 RVA: 0x005EC383 File Offset: 0x005EA583
		// (set) Token: 0x0602AEE1 RID: 175841 RVA: 0x005EC38B File Offset: 0x005EA58B
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B9C5 RID: 47557
		// (get) Token: 0x0602AEE2 RID: 175842 RVA: 0x005EC394 File Offset: 0x005EA594
		// (set) Token: 0x0602AEE3 RID: 175843 RVA: 0x005EC39C File Offset: 0x005EA59C
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B9C6 RID: 47558
		// (get) Token: 0x0602AEE4 RID: 175844 RVA: 0x005EC3A5 File Offset: 0x005EA5A5
		// (set) Token: 0x0602AEE5 RID: 175845 RVA: 0x005EC3AD File Offset: 0x005EA5AD
		public float Fov { get; set; }

		// Token: 0x1700B9C7 RID: 47559
		// (get) Token: 0x0602AEE6 RID: 175846 RVA: 0x005EC3B6 File Offset: 0x005EA5B6
		// (set) Token: 0x0602AEE7 RID: 175847 RVA: 0x005EC3BE File Offset: 0x005EA5BE
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B9C8 RID: 47560
		// (get) Token: 0x0602AEE8 RID: 175848 RVA: 0x005EC3C7 File Offset: 0x005EA5C7
		// (set) Token: 0x0602AEE9 RID: 175849 RVA: 0x005EC3CF File Offset: 0x005EA5CF
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B9C9 RID: 47561
		// (get) Token: 0x0602AEEA RID: 175850 RVA: 0x005EC3D8 File Offset: 0x005EA5D8
		// (set) Token: 0x0602AEEB RID: 175851 RVA: 0x005EC3E0 File Offset: 0x005EA5E0
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B9CA RID: 47562
		// (get) Token: 0x0602AEEC RID: 175852 RVA: 0x005EC3E9 File Offset: 0x005EA5E9
		// (set) Token: 0x0602AEED RID: 175853 RVA: 0x005EC3F1 File Offset: 0x005EA5F1
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B9CB RID: 47563
		// (get) Token: 0x0602AEEE RID: 175854 RVA: 0x005EC3FA File Offset: 0x005EA5FA
		// (set) Token: 0x0602AEEF RID: 175855 RVA: 0x005EC402 File Offset: 0x005EA602
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B9CC RID: 47564
		// (get) Token: 0x0602AEF0 RID: 175856 RVA: 0x005EC40B File Offset: 0x005EA60B
		// (set) Token: 0x0602AEF1 RID: 175857 RVA: 0x005EC413 File Offset: 0x005EA613
		public byte NullMask { get; set; }

		// Token: 0x0602AEF2 RID: 175858 RVA: 0x005EC41C File Offset: 0x005EA61C
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
