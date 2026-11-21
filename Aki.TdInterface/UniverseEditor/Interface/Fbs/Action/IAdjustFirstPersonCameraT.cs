using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AF RID: 26543
	public class IAdjustFirstPersonCameraT
	{
		// Token: 0x1700C1E1 RID: 49633
		// (get) Token: 0x0602D25E RID: 184926 RVA: 0x0062D1E4 File Offset: 0x0062B3E4
		// (set) Token: 0x0602D25F RID: 184927 RVA: 0x0062D1EC File Offset: 0x0062B3EC
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C1E2 RID: 49634
		// (get) Token: 0x0602D260 RID: 184928 RVA: 0x0062D1F5 File Offset: 0x0062B3F5
		// (set) Token: 0x0602D261 RID: 184929 RVA: 0x0062D1FD File Offset: 0x0062B3FD
		public int Priority { get; set; }

		// Token: 0x1700C1E3 RID: 49635
		// (get) Token: 0x0602D262 RID: 184930 RVA: 0x0062D206 File Offset: 0x0062B406
		// (set) Token: 0x0602D263 RID: 184931 RVA: 0x0062D20E File Offset: 0x0062B40E
		public float FadeInTime { get; set; }

		// Token: 0x1700C1E4 RID: 49636
		// (get) Token: 0x0602D264 RID: 184932 RVA: 0x0062D217 File Offset: 0x0062B417
		// (set) Token: 0x0602D265 RID: 184933 RVA: 0x0062D21F File Offset: 0x0062B41F
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C1E5 RID: 49637
		// (get) Token: 0x0602D266 RID: 184934 RVA: 0x0062D228 File Offset: 0x0062B428
		// (set) Token: 0x0602D267 RID: 184935 RVA: 0x0062D230 File Offset: 0x0062B430
		public float FadeOutTime { get; set; }

		// Token: 0x1700C1E6 RID: 49638
		// (get) Token: 0x0602D268 RID: 184936 RVA: 0x0062D239 File Offset: 0x0062B439
		// (set) Token: 0x0602D269 RID: 184937 RVA: 0x0062D241 File Offset: 0x0062B441
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C1E7 RID: 49639
		// (get) Token: 0x0602D26A RID: 184938 RVA: 0x0062D24A File Offset: 0x0062B44A
		// (set) Token: 0x0602D26B RID: 184939 RVA: 0x0062D252 File Offset: 0x0062B452
		public float ArmLength { get; set; }

		// Token: 0x1700C1E8 RID: 49640
		// (get) Token: 0x0602D26C RID: 184940 RVA: 0x0062D25B File Offset: 0x0062B45B
		// (set) Token: 0x0602D26D RID: 184941 RVA: 0x0062D263 File Offset: 0x0062B463
		public float MinumArmLength { get; set; }

		// Token: 0x1700C1E9 RID: 49641
		// (get) Token: 0x0602D26E RID: 184942 RVA: 0x0062D26C File Offset: 0x0062B46C
		// (set) Token: 0x0602D26F RID: 184943 RVA: 0x0062D274 File Offset: 0x0062B474
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C1EA RID: 49642
		// (get) Token: 0x0602D270 RID: 184944 RVA: 0x0062D27D File Offset: 0x0062B47D
		// (set) Token: 0x0602D271 RID: 184945 RVA: 0x0062D285 File Offset: 0x0062B485
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C1EB RID: 49643
		// (get) Token: 0x0602D272 RID: 184946 RVA: 0x0062D28E File Offset: 0x0062B48E
		// (set) Token: 0x0602D273 RID: 184947 RVA: 0x0062D296 File Offset: 0x0062B496
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C1EC RID: 49644
		// (get) Token: 0x0602D274 RID: 184948 RVA: 0x0062D29F File Offset: 0x0062B49F
		// (set) Token: 0x0602D275 RID: 184949 RVA: 0x0062D2A7 File Offset: 0x0062B4A7
		public float YawLimitMin { get; set; }

		// Token: 0x1700C1ED RID: 49645
		// (get) Token: 0x0602D276 RID: 184950 RVA: 0x0062D2B0 File Offset: 0x0062B4B0
		// (set) Token: 0x0602D277 RID: 184951 RVA: 0x0062D2B8 File Offset: 0x0062B4B8
		public float YawLimitMax { get; set; }

		// Token: 0x1700C1EE RID: 49646
		// (get) Token: 0x0602D278 RID: 184952 RVA: 0x0062D2C1 File Offset: 0x0062B4C1
		// (set) Token: 0x0602D279 RID: 184953 RVA: 0x0062D2C9 File Offset: 0x0062B4C9
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C1EF RID: 49647
		// (get) Token: 0x0602D27A RID: 184954 RVA: 0x0062D2D2 File Offset: 0x0062B4D2
		// (set) Token: 0x0602D27B RID: 184955 RVA: 0x0062D2DA File Offset: 0x0062B4DA
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C1F0 RID: 49648
		// (get) Token: 0x0602D27C RID: 184956 RVA: 0x0062D2E3 File Offset: 0x0062B4E3
		// (set) Token: 0x0602D27D RID: 184957 RVA: 0x0062D2EB File Offset: 0x0062B4EB
		public float Fov { get; set; }

		// Token: 0x1700C1F1 RID: 49649
		// (get) Token: 0x0602D27E RID: 184958 RVA: 0x0062D2F4 File Offset: 0x0062B4F4
		// (set) Token: 0x0602D27F RID: 184959 RVA: 0x0062D2FC File Offset: 0x0062B4FC
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C1F2 RID: 49650
		// (get) Token: 0x0602D280 RID: 184960 RVA: 0x0062D305 File Offset: 0x0062B505
		// (set) Token: 0x0602D281 RID: 184961 RVA: 0x0062D30D File Offset: 0x0062B50D
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C1F3 RID: 49651
		// (get) Token: 0x0602D282 RID: 184962 RVA: 0x0062D316 File Offset: 0x0062B516
		// (set) Token: 0x0602D283 RID: 184963 RVA: 0x0062D31E File Offset: 0x0062B51E
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C1F4 RID: 49652
		// (get) Token: 0x0602D284 RID: 184964 RVA: 0x0062D327 File Offset: 0x0062B527
		// (set) Token: 0x0602D285 RID: 184965 RVA: 0x0062D32F File Offset: 0x0062B52F
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C1F5 RID: 49653
		// (get) Token: 0x0602D286 RID: 184966 RVA: 0x0062D338 File Offset: 0x0062B538
		// (set) Token: 0x0602D287 RID: 184967 RVA: 0x0062D340 File Offset: 0x0062B540
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C1F6 RID: 49654
		// (get) Token: 0x0602D288 RID: 184968 RVA: 0x0062D349 File Offset: 0x0062B549
		// (set) Token: 0x0602D289 RID: 184969 RVA: 0x0062D351 File Offset: 0x0062B551
		public bool HidePlayer { get; set; }

		// Token: 0x1700C1F7 RID: 49655
		// (get) Token: 0x0602D28A RID: 184970 RVA: 0x0062D35A File Offset: 0x0062B55A
		// (set) Token: 0x0602D28B RID: 184971 RVA: 0x0062D362 File Offset: 0x0062B562
		public byte NullMask { get; set; }

		// Token: 0x0602D28C RID: 184972 RVA: 0x0062D36C File Offset: 0x0062B56C
		public IAdjustFirstPersonCameraT()
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
			this.HidePlayer = false;
			this.NullMask = 0;
		}
	}
}
