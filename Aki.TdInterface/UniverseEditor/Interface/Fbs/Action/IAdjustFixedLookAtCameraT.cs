using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006156 RID: 24918
	public class IAdjustFixedLookAtCameraT
	{
		// Token: 0x1700B8F6 RID: 47350
		// (get) Token: 0x0602ACB6 RID: 175286 RVA: 0x005E6968 File Offset: 0x005E4B68
		// (set) Token: 0x0602ACB7 RID: 175287 RVA: 0x005E6970 File Offset: 0x005E4B70
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B8F7 RID: 47351
		// (get) Token: 0x0602ACB8 RID: 175288 RVA: 0x005E6979 File Offset: 0x005E4B79
		// (set) Token: 0x0602ACB9 RID: 175289 RVA: 0x005E6981 File Offset: 0x005E4B81
		public int Priority { get; set; }

		// Token: 0x1700B8F8 RID: 47352
		// (get) Token: 0x0602ACBA RID: 175290 RVA: 0x005E698A File Offset: 0x005E4B8A
		// (set) Token: 0x0602ACBB RID: 175291 RVA: 0x005E6992 File Offset: 0x005E4B92
		public float FadeInTime { get; set; }

		// Token: 0x1700B8F9 RID: 47353
		// (get) Token: 0x0602ACBC RID: 175292 RVA: 0x005E699B File Offset: 0x005E4B9B
		// (set) Token: 0x0602ACBD RID: 175293 RVA: 0x005E69A3 File Offset: 0x005E4BA3
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B8FA RID: 47354
		// (get) Token: 0x0602ACBE RID: 175294 RVA: 0x005E69AC File Offset: 0x005E4BAC
		// (set) Token: 0x0602ACBF RID: 175295 RVA: 0x005E69B4 File Offset: 0x005E4BB4
		public float FadeOutTime { get; set; }

		// Token: 0x1700B8FB RID: 47355
		// (get) Token: 0x0602ACC0 RID: 175296 RVA: 0x005E69BD File Offset: 0x005E4BBD
		// (set) Token: 0x0602ACC1 RID: 175297 RVA: 0x005E69C5 File Offset: 0x005E4BC5
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B8FC RID: 47356
		// (get) Token: 0x0602ACC2 RID: 175298 RVA: 0x005E69CE File Offset: 0x005E4BCE
		// (set) Token: 0x0602ACC3 RID: 175299 RVA: 0x005E69D6 File Offset: 0x005E4BD6
		public float ArmLength { get; set; }

		// Token: 0x1700B8FD RID: 47357
		// (get) Token: 0x0602ACC4 RID: 175300 RVA: 0x005E69DF File Offset: 0x005E4BDF
		// (set) Token: 0x0602ACC5 RID: 175301 RVA: 0x005E69E7 File Offset: 0x005E4BE7
		public float MinumArmLength { get; set; }

		// Token: 0x1700B8FE RID: 47358
		// (get) Token: 0x0602ACC6 RID: 175302 RVA: 0x005E69F0 File Offset: 0x005E4BF0
		// (set) Token: 0x0602ACC7 RID: 175303 RVA: 0x005E69F8 File Offset: 0x005E4BF8
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B8FF RID: 47359
		// (get) Token: 0x0602ACC8 RID: 175304 RVA: 0x005E6A01 File Offset: 0x005E4C01
		// (set) Token: 0x0602ACC9 RID: 175305 RVA: 0x005E6A09 File Offset: 0x005E4C09
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B900 RID: 47360
		// (get) Token: 0x0602ACCA RID: 175306 RVA: 0x005E6A12 File Offset: 0x005E4C12
		// (set) Token: 0x0602ACCB RID: 175307 RVA: 0x005E6A1A File Offset: 0x005E4C1A
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B901 RID: 47361
		// (get) Token: 0x0602ACCC RID: 175308 RVA: 0x005E6A23 File Offset: 0x005E4C23
		// (set) Token: 0x0602ACCD RID: 175309 RVA: 0x005E6A2B File Offset: 0x005E4C2B
		public float YawLimitMin { get; set; }

		// Token: 0x1700B902 RID: 47362
		// (get) Token: 0x0602ACCE RID: 175310 RVA: 0x005E6A34 File Offset: 0x005E4C34
		// (set) Token: 0x0602ACCF RID: 175311 RVA: 0x005E6A3C File Offset: 0x005E4C3C
		public float YawLimitMax { get; set; }

		// Token: 0x1700B903 RID: 47363
		// (get) Token: 0x0602ACD0 RID: 175312 RVA: 0x005E6A45 File Offset: 0x005E4C45
		// (set) Token: 0x0602ACD1 RID: 175313 RVA: 0x005E6A4D File Offset: 0x005E4C4D
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B904 RID: 47364
		// (get) Token: 0x0602ACD2 RID: 175314 RVA: 0x005E6A56 File Offset: 0x005E4C56
		// (set) Token: 0x0602ACD3 RID: 175315 RVA: 0x005E6A5E File Offset: 0x005E4C5E
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B905 RID: 47365
		// (get) Token: 0x0602ACD4 RID: 175316 RVA: 0x005E6A67 File Offset: 0x005E4C67
		// (set) Token: 0x0602ACD5 RID: 175317 RVA: 0x005E6A6F File Offset: 0x005E4C6F
		public float Fov { get; set; }

		// Token: 0x1700B906 RID: 47366
		// (get) Token: 0x0602ACD6 RID: 175318 RVA: 0x005E6A78 File Offset: 0x005E4C78
		// (set) Token: 0x0602ACD7 RID: 175319 RVA: 0x005E6A80 File Offset: 0x005E4C80
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B907 RID: 47367
		// (get) Token: 0x0602ACD8 RID: 175320 RVA: 0x005E6A89 File Offset: 0x005E4C89
		// (set) Token: 0x0602ACD9 RID: 175321 RVA: 0x005E6A91 File Offset: 0x005E4C91
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B908 RID: 47368
		// (get) Token: 0x0602ACDA RID: 175322 RVA: 0x005E6A9A File Offset: 0x005E4C9A
		// (set) Token: 0x0602ACDB RID: 175323 RVA: 0x005E6AA2 File Offset: 0x005E4CA2
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B909 RID: 47369
		// (get) Token: 0x0602ACDC RID: 175324 RVA: 0x005E6AAB File Offset: 0x005E4CAB
		// (set) Token: 0x0602ACDD RID: 175325 RVA: 0x005E6AB3 File Offset: 0x005E4CB3
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B90A RID: 47370
		// (get) Token: 0x0602ACDE RID: 175326 RVA: 0x005E6ABC File Offset: 0x005E4CBC
		// (set) Token: 0x0602ACDF RID: 175327 RVA: 0x005E6AC4 File Offset: 0x005E4CC4
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B90B RID: 47371
		// (get) Token: 0x0602ACE0 RID: 175328 RVA: 0x005E6ACD File Offset: 0x005E4CCD
		// (set) Token: 0x0602ACE1 RID: 175329 RVA: 0x005E6AD5 File Offset: 0x005E4CD5
		public IAdjustFixedLookAtTargetRangeEntityT TargetType { get; set; }

		// Token: 0x1700B90C RID: 47372
		// (get) Token: 0x0602ACE2 RID: 175330 RVA: 0x005E6ADE File Offset: 0x005E4CDE
		// (set) Token: 0x0602ACE3 RID: 175331 RVA: 0x005E6AE6 File Offset: 0x005E4CE6
		public EPlayerMoveTag PlayerMoveTag { get; set; }

		// Token: 0x1700B90D RID: 47373
		// (get) Token: 0x0602ACE4 RID: 175332 RVA: 0x005E6AEF File Offset: 0x005E4CEF
		// (set) Token: 0x0602ACE5 RID: 175333 RVA: 0x005E6AF7 File Offset: 0x005E4CF7
		public byte NullMask { get; set; }

		// Token: 0x0602ACE6 RID: 175334 RVA: 0x005E6B00 File Offset: 0x005E4D00
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
