using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B2 RID: 26546
	public class IAdjustFixedCameraT
	{
		// Token: 0x1700C218 RID: 49688
		// (get) Token: 0x0602D2E7 RID: 185063 RVA: 0x0062ECF7 File Offset: 0x0062CEF7
		// (set) Token: 0x0602D2E8 RID: 185064 RVA: 0x0062ECFF File Offset: 0x0062CEFF
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C219 RID: 49689
		// (get) Token: 0x0602D2E9 RID: 185065 RVA: 0x0062ED08 File Offset: 0x0062CF08
		// (set) Token: 0x0602D2EA RID: 185066 RVA: 0x0062ED10 File Offset: 0x0062CF10
		public int Priority { get; set; }

		// Token: 0x1700C21A RID: 49690
		// (get) Token: 0x0602D2EB RID: 185067 RVA: 0x0062ED19 File Offset: 0x0062CF19
		// (set) Token: 0x0602D2EC RID: 185068 RVA: 0x0062ED21 File Offset: 0x0062CF21
		public float FadeInTime { get; set; }

		// Token: 0x1700C21B RID: 49691
		// (get) Token: 0x0602D2ED RID: 185069 RVA: 0x0062ED2A File Offset: 0x0062CF2A
		// (set) Token: 0x0602D2EE RID: 185070 RVA: 0x0062ED32 File Offset: 0x0062CF32
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C21C RID: 49692
		// (get) Token: 0x0602D2EF RID: 185071 RVA: 0x0062ED3B File Offset: 0x0062CF3B
		// (set) Token: 0x0602D2F0 RID: 185072 RVA: 0x0062ED43 File Offset: 0x0062CF43
		public float FadeOutTime { get; set; }

		// Token: 0x1700C21D RID: 49693
		// (get) Token: 0x0602D2F1 RID: 185073 RVA: 0x0062ED4C File Offset: 0x0062CF4C
		// (set) Token: 0x0602D2F2 RID: 185074 RVA: 0x0062ED54 File Offset: 0x0062CF54
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C21E RID: 49694
		// (get) Token: 0x0602D2F3 RID: 185075 RVA: 0x0062ED5D File Offset: 0x0062CF5D
		// (set) Token: 0x0602D2F4 RID: 185076 RVA: 0x0062ED65 File Offset: 0x0062CF65
		public float ArmLength { get; set; }

		// Token: 0x1700C21F RID: 49695
		// (get) Token: 0x0602D2F5 RID: 185077 RVA: 0x0062ED6E File Offset: 0x0062CF6E
		// (set) Token: 0x0602D2F6 RID: 185078 RVA: 0x0062ED76 File Offset: 0x0062CF76
		public float MinumArmLength { get; set; }

		// Token: 0x1700C220 RID: 49696
		// (get) Token: 0x0602D2F7 RID: 185079 RVA: 0x0062ED7F File Offset: 0x0062CF7F
		// (set) Token: 0x0602D2F8 RID: 185080 RVA: 0x0062ED87 File Offset: 0x0062CF87
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C221 RID: 49697
		// (get) Token: 0x0602D2F9 RID: 185081 RVA: 0x0062ED90 File Offset: 0x0062CF90
		// (set) Token: 0x0602D2FA RID: 185082 RVA: 0x0062ED98 File Offset: 0x0062CF98
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C222 RID: 49698
		// (get) Token: 0x0602D2FB RID: 185083 RVA: 0x0062EDA1 File Offset: 0x0062CFA1
		// (set) Token: 0x0602D2FC RID: 185084 RVA: 0x0062EDA9 File Offset: 0x0062CFA9
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C223 RID: 49699
		// (get) Token: 0x0602D2FD RID: 185085 RVA: 0x0062EDB2 File Offset: 0x0062CFB2
		// (set) Token: 0x0602D2FE RID: 185086 RVA: 0x0062EDBA File Offset: 0x0062CFBA
		public float YawLimitMin { get; set; }

		// Token: 0x1700C224 RID: 49700
		// (get) Token: 0x0602D2FF RID: 185087 RVA: 0x0062EDC3 File Offset: 0x0062CFC3
		// (set) Token: 0x0602D300 RID: 185088 RVA: 0x0062EDCB File Offset: 0x0062CFCB
		public float YawLimitMax { get; set; }

		// Token: 0x1700C225 RID: 49701
		// (get) Token: 0x0602D301 RID: 185089 RVA: 0x0062EDD4 File Offset: 0x0062CFD4
		// (set) Token: 0x0602D302 RID: 185090 RVA: 0x0062EDDC File Offset: 0x0062CFDC
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C226 RID: 49702
		// (get) Token: 0x0602D303 RID: 185091 RVA: 0x0062EDE5 File Offset: 0x0062CFE5
		// (set) Token: 0x0602D304 RID: 185092 RVA: 0x0062EDED File Offset: 0x0062CFED
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C227 RID: 49703
		// (get) Token: 0x0602D305 RID: 185093 RVA: 0x0062EDF6 File Offset: 0x0062CFF6
		// (set) Token: 0x0602D306 RID: 185094 RVA: 0x0062EDFE File Offset: 0x0062CFFE
		public float Fov { get; set; }

		// Token: 0x1700C228 RID: 49704
		// (get) Token: 0x0602D307 RID: 185095 RVA: 0x0062EE07 File Offset: 0x0062D007
		// (set) Token: 0x0602D308 RID: 185096 RVA: 0x0062EE0F File Offset: 0x0062D00F
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C229 RID: 49705
		// (get) Token: 0x0602D309 RID: 185097 RVA: 0x0062EE18 File Offset: 0x0062D018
		// (set) Token: 0x0602D30A RID: 185098 RVA: 0x0062EE20 File Offset: 0x0062D020
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C22A RID: 49706
		// (get) Token: 0x0602D30B RID: 185099 RVA: 0x0062EE29 File Offset: 0x0062D029
		// (set) Token: 0x0602D30C RID: 185100 RVA: 0x0062EE31 File Offset: 0x0062D031
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C22B RID: 49707
		// (get) Token: 0x0602D30D RID: 185101 RVA: 0x0062EE3A File Offset: 0x0062D03A
		// (set) Token: 0x0602D30E RID: 185102 RVA: 0x0062EE42 File Offset: 0x0062D042
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C22C RID: 49708
		// (get) Token: 0x0602D30F RID: 185103 RVA: 0x0062EE4B File Offset: 0x0062D04B
		// (set) Token: 0x0602D310 RID: 185104 RVA: 0x0062EE53 File Offset: 0x0062D053
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C22D RID: 49709
		// (get) Token: 0x0602D311 RID: 185105 RVA: 0x0062EE5C File Offset: 0x0062D05C
		// (set) Token: 0x0602D312 RID: 185106 RVA: 0x0062EE64 File Offset: 0x0062D064
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700C22E RID: 49710
		// (get) Token: 0x0602D313 RID: 185107 RVA: 0x0062EE6D File Offset: 0x0062D06D
		// (set) Token: 0x0602D314 RID: 185108 RVA: 0x0062EE75 File Offset: 0x0062D075
		public IVectorInfoT CenterRot { get; set; }

		// Token: 0x1700C22F RID: 49711
		// (get) Token: 0x0602D315 RID: 185109 RVA: 0x0062EE7E File Offset: 0x0062D07E
		// (set) Token: 0x0602D316 RID: 185110 RVA: 0x0062EE86 File Offset: 0x0062D086
		public IBlendFunctionT BlendIn { get; set; }

		// Token: 0x1700C230 RID: 49712
		// (get) Token: 0x0602D317 RID: 185111 RVA: 0x0062EE8F File Offset: 0x0062D08F
		// (set) Token: 0x0602D318 RID: 185112 RVA: 0x0062EE97 File Offset: 0x0062D097
		public IBlendFunctionT BlendOut { get; set; }

		// Token: 0x1700C231 RID: 49713
		// (get) Token: 0x0602D319 RID: 185113 RVA: 0x0062EEA0 File Offset: 0x0062D0A0
		// (set) Token: 0x0602D31A RID: 185114 RVA: 0x0062EEA8 File Offset: 0x0062D0A8
		public IAdjustFixedCameraOrthogonalConfigT OrthogonalConfig { get; set; }

		// Token: 0x1700C232 RID: 49714
		// (get) Token: 0x0602D31B RID: 185115 RVA: 0x0062EEB1 File Offset: 0x0062D0B1
		// (set) Token: 0x0602D31C RID: 185116 RVA: 0x0062EEB9 File Offset: 0x0062D0B9
		public IAdjustFixedCameraRotateConfigT RotateConfig { get; set; }

		// Token: 0x1700C233 RID: 49715
		// (get) Token: 0x0602D31D RID: 185117 RVA: 0x0062EEC2 File Offset: 0x0062D0C2
		// (set) Token: 0x0602D31E RID: 185118 RVA: 0x0062EECA File Offset: 0x0062D0CA
		public TTargetEntityUnion FollowTarget { get; set; }

		// Token: 0x1700C234 RID: 49716
		// (get) Token: 0x0602D31F RID: 185119 RVA: 0x0062EED3 File Offset: 0x0062D0D3
		// (set) Token: 0x0602D320 RID: 185120 RVA: 0x0062EEDB File Offset: 0x0062D0DB
		public bool IsPlotEnable { get; set; }

		// Token: 0x1700C235 RID: 49717
		// (get) Token: 0x0602D321 RID: 185121 RVA: 0x0062EEE4 File Offset: 0x0062D0E4
		// (set) Token: 0x0602D322 RID: 185122 RVA: 0x0062EEEC File Offset: 0x0062D0EC
		public bool HidePlayer { get; set; }

		// Token: 0x1700C236 RID: 49718
		// (get) Token: 0x0602D323 RID: 185123 RVA: 0x0062EEF5 File Offset: 0x0062D0F5
		// (set) Token: 0x0602D324 RID: 185124 RVA: 0x0062EEFD File Offset: 0x0062D0FD
		public ushort NullMask { get; set; }

		// Token: 0x0602D325 RID: 185125 RVA: 0x0062EF08 File Offset: 0x0062D108
		public IAdjustFixedCameraT()
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
			this.CenterRot = null;
			this.BlendIn = null;
			this.BlendOut = null;
			this.OrthogonalConfig = null;
			this.RotateConfig = null;
			this.FollowTarget = null;
			this.IsPlotEnable = false;
			this.HidePlayer = false;
			this.NullMask = 0;
		}
	}
}
