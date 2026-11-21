using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BB RID: 26555
	public class IAdjustFixedLookAtCameraT
	{
		// Token: 0x1700C266 RID: 49766
		// (get) Token: 0x0602D3AF RID: 185263 RVA: 0x00630B44 File Offset: 0x0062ED44
		// (set) Token: 0x0602D3B0 RID: 185264 RVA: 0x00630B4C File Offset: 0x0062ED4C
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700C267 RID: 49767
		// (get) Token: 0x0602D3B1 RID: 185265 RVA: 0x00630B55 File Offset: 0x0062ED55
		// (set) Token: 0x0602D3B2 RID: 185266 RVA: 0x00630B5D File Offset: 0x0062ED5D
		public int Priority { get; set; }

		// Token: 0x1700C268 RID: 49768
		// (get) Token: 0x0602D3B3 RID: 185267 RVA: 0x00630B66 File Offset: 0x0062ED66
		// (set) Token: 0x0602D3B4 RID: 185268 RVA: 0x00630B6E File Offset: 0x0062ED6E
		public float FadeInTime { get; set; }

		// Token: 0x1700C269 RID: 49769
		// (get) Token: 0x0602D3B5 RID: 185269 RVA: 0x00630B77 File Offset: 0x0062ED77
		// (set) Token: 0x0602D3B6 RID: 185270 RVA: 0x00630B7F File Offset: 0x0062ED7F
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700C26A RID: 49770
		// (get) Token: 0x0602D3B7 RID: 185271 RVA: 0x00630B88 File Offset: 0x0062ED88
		// (set) Token: 0x0602D3B8 RID: 185272 RVA: 0x00630B90 File Offset: 0x0062ED90
		public float FadeOutTime { get; set; }

		// Token: 0x1700C26B RID: 49771
		// (get) Token: 0x0602D3B9 RID: 185273 RVA: 0x00630B99 File Offset: 0x0062ED99
		// (set) Token: 0x0602D3BA RID: 185274 RVA: 0x00630BA1 File Offset: 0x0062EDA1
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700C26C RID: 49772
		// (get) Token: 0x0602D3BB RID: 185275 RVA: 0x00630BAA File Offset: 0x0062EDAA
		// (set) Token: 0x0602D3BC RID: 185276 RVA: 0x00630BB2 File Offset: 0x0062EDB2
		public float ArmLength { get; set; }

		// Token: 0x1700C26D RID: 49773
		// (get) Token: 0x0602D3BD RID: 185277 RVA: 0x00630BBB File Offset: 0x0062EDBB
		// (set) Token: 0x0602D3BE RID: 185278 RVA: 0x00630BC3 File Offset: 0x0062EDC3
		public float MinumArmLength { get; set; }

		// Token: 0x1700C26E RID: 49774
		// (get) Token: 0x0602D3BF RID: 185279 RVA: 0x00630BCC File Offset: 0x0062EDCC
		// (set) Token: 0x0602D3C0 RID: 185280 RVA: 0x00630BD4 File Offset: 0x0062EDD4
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700C26F RID: 49775
		// (get) Token: 0x0602D3C1 RID: 185281 RVA: 0x00630BDD File Offset: 0x0062EDDD
		// (set) Token: 0x0602D3C2 RID: 185282 RVA: 0x00630BE5 File Offset: 0x0062EDE5
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700C270 RID: 49776
		// (get) Token: 0x0602D3C3 RID: 185283 RVA: 0x00630BEE File Offset: 0x0062EDEE
		// (set) Token: 0x0602D3C4 RID: 185284 RVA: 0x00630BF6 File Offset: 0x0062EDF6
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700C271 RID: 49777
		// (get) Token: 0x0602D3C5 RID: 185285 RVA: 0x00630BFF File Offset: 0x0062EDFF
		// (set) Token: 0x0602D3C6 RID: 185286 RVA: 0x00630C07 File Offset: 0x0062EE07
		public float YawLimitMin { get; set; }

		// Token: 0x1700C272 RID: 49778
		// (get) Token: 0x0602D3C7 RID: 185287 RVA: 0x00630C10 File Offset: 0x0062EE10
		// (set) Token: 0x0602D3C8 RID: 185288 RVA: 0x00630C18 File Offset: 0x0062EE18
		public float YawLimitMax { get; set; }

		// Token: 0x1700C273 RID: 49779
		// (get) Token: 0x0602D3C9 RID: 185289 RVA: 0x00630C21 File Offset: 0x0062EE21
		// (set) Token: 0x0602D3CA RID: 185290 RVA: 0x00630C29 File Offset: 0x0062EE29
		public float PitchLimitMin { get; set; }

		// Token: 0x1700C274 RID: 49780
		// (get) Token: 0x0602D3CB RID: 185291 RVA: 0x00630C32 File Offset: 0x0062EE32
		// (set) Token: 0x0602D3CC RID: 185292 RVA: 0x00630C3A File Offset: 0x0062EE3A
		public float PitchLimitMax { get; set; }

		// Token: 0x1700C275 RID: 49781
		// (get) Token: 0x0602D3CD RID: 185293 RVA: 0x00630C43 File Offset: 0x0062EE43
		// (set) Token: 0x0602D3CE RID: 185294 RVA: 0x00630C4B File Offset: 0x0062EE4B
		public float Fov { get; set; }

		// Token: 0x1700C276 RID: 49782
		// (get) Token: 0x0602D3CF RID: 185295 RVA: 0x00630C54 File Offset: 0x0062EE54
		// (set) Token: 0x0602D3D0 RID: 185296 RVA: 0x00630C5C File Offset: 0x0062EE5C
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700C277 RID: 49783
		// (get) Token: 0x0602D3D1 RID: 185297 RVA: 0x00630C65 File Offset: 0x0062EE65
		// (set) Token: 0x0602D3D2 RID: 185298 RVA: 0x00630C6D File Offset: 0x0062EE6D
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C278 RID: 49784
		// (get) Token: 0x0602D3D3 RID: 185299 RVA: 0x00630C76 File Offset: 0x0062EE76
		// (set) Token: 0x0602D3D4 RID: 185300 RVA: 0x00630C7E File Offset: 0x0062EE7E
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C279 RID: 49785
		// (get) Token: 0x0602D3D5 RID: 185301 RVA: 0x00630C87 File Offset: 0x0062EE87
		// (set) Token: 0x0602D3D6 RID: 185302 RVA: 0x00630C8F File Offset: 0x0062EE8F
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C27A RID: 49786
		// (get) Token: 0x0602D3D7 RID: 185303 RVA: 0x00630C98 File Offset: 0x0062EE98
		// (set) Token: 0x0602D3D8 RID: 185304 RVA: 0x00630CA0 File Offset: 0x0062EEA0
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700C27B RID: 49787
		// (get) Token: 0x0602D3D9 RID: 185305 RVA: 0x00630CA9 File Offset: 0x0062EEA9
		// (set) Token: 0x0602D3DA RID: 185306 RVA: 0x00630CB1 File Offset: 0x0062EEB1
		public IAdjustFixedLookAtTargetRangeEntityT TargetType { get; set; }

		// Token: 0x1700C27C RID: 49788
		// (get) Token: 0x0602D3DB RID: 185307 RVA: 0x00630CBA File Offset: 0x0062EEBA
		// (set) Token: 0x0602D3DC RID: 185308 RVA: 0x00630CC2 File Offset: 0x0062EEC2
		public EPlayerMoveTag PlayerMoveTag { get; set; }

		// Token: 0x1700C27D RID: 49789
		// (get) Token: 0x0602D3DD RID: 185309 RVA: 0x00630CCB File Offset: 0x0062EECB
		// (set) Token: 0x0602D3DE RID: 185310 RVA: 0x00630CD3 File Offset: 0x0062EED3
		public byte NullMask { get; set; }

		// Token: 0x0602D3DF RID: 185311 RVA: 0x00630CDC File Offset: 0x0062EEDC
		public IAdjustFixedLookAtCameraT()
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
			this.TargetType = null;
			this.PlayerMoveTag = EPlayerMoveTag.VehicleMotorHighSpeed;
			this.NullMask = 0;
		}
	}
}
