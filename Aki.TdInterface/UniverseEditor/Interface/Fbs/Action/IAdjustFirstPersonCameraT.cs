using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200614A RID: 24906
	public class IAdjustFirstPersonCameraT
	{
		// Token: 0x1700B871 RID: 47217
		// (get) Token: 0x0602AB65 RID: 174949 RVA: 0x005E3008 File Offset: 0x005E1208
		// (set) Token: 0x0602AB66 RID: 174950 RVA: 0x005E3010 File Offset: 0x005E1210
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B872 RID: 47218
		// (get) Token: 0x0602AB67 RID: 174951 RVA: 0x005E3019 File Offset: 0x005E1219
		// (set) Token: 0x0602AB68 RID: 174952 RVA: 0x005E3021 File Offset: 0x005E1221
		public int Priority { get; set; }

		// Token: 0x1700B873 RID: 47219
		// (get) Token: 0x0602AB69 RID: 174953 RVA: 0x005E302A File Offset: 0x005E122A
		// (set) Token: 0x0602AB6A RID: 174954 RVA: 0x005E3032 File Offset: 0x005E1232
		public float FadeInTime { get; set; }

		// Token: 0x1700B874 RID: 47220
		// (get) Token: 0x0602AB6B RID: 174955 RVA: 0x005E303B File Offset: 0x005E123B
		// (set) Token: 0x0602AB6C RID: 174956 RVA: 0x005E3043 File Offset: 0x005E1243
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B875 RID: 47221
		// (get) Token: 0x0602AB6D RID: 174957 RVA: 0x005E304C File Offset: 0x005E124C
		// (set) Token: 0x0602AB6E RID: 174958 RVA: 0x005E3054 File Offset: 0x005E1254
		public float FadeOutTime { get; set; }

		// Token: 0x1700B876 RID: 47222
		// (get) Token: 0x0602AB6F RID: 174959 RVA: 0x005E305D File Offset: 0x005E125D
		// (set) Token: 0x0602AB70 RID: 174960 RVA: 0x005E3065 File Offset: 0x005E1265
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B877 RID: 47223
		// (get) Token: 0x0602AB71 RID: 174961 RVA: 0x005E306E File Offset: 0x005E126E
		// (set) Token: 0x0602AB72 RID: 174962 RVA: 0x005E3076 File Offset: 0x005E1276
		public float ArmLength { get; set; }

		// Token: 0x1700B878 RID: 47224
		// (get) Token: 0x0602AB73 RID: 174963 RVA: 0x005E307F File Offset: 0x005E127F
		// (set) Token: 0x0602AB74 RID: 174964 RVA: 0x005E3087 File Offset: 0x005E1287
		public float MinumArmLength { get; set; }

		// Token: 0x1700B879 RID: 47225
		// (get) Token: 0x0602AB75 RID: 174965 RVA: 0x005E3090 File Offset: 0x005E1290
		// (set) Token: 0x0602AB76 RID: 174966 RVA: 0x005E3098 File Offset: 0x005E1298
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B87A RID: 47226
		// (get) Token: 0x0602AB77 RID: 174967 RVA: 0x005E30A1 File Offset: 0x005E12A1
		// (set) Token: 0x0602AB78 RID: 174968 RVA: 0x005E30A9 File Offset: 0x005E12A9
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B87B RID: 47227
		// (get) Token: 0x0602AB79 RID: 174969 RVA: 0x005E30B2 File Offset: 0x005E12B2
		// (set) Token: 0x0602AB7A RID: 174970 RVA: 0x005E30BA File Offset: 0x005E12BA
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B87C RID: 47228
		// (get) Token: 0x0602AB7B RID: 174971 RVA: 0x005E30C3 File Offset: 0x005E12C3
		// (set) Token: 0x0602AB7C RID: 174972 RVA: 0x005E30CB File Offset: 0x005E12CB
		public float YawLimitMin { get; set; }

		// Token: 0x1700B87D RID: 47229
		// (get) Token: 0x0602AB7D RID: 174973 RVA: 0x005E30D4 File Offset: 0x005E12D4
		// (set) Token: 0x0602AB7E RID: 174974 RVA: 0x005E30DC File Offset: 0x005E12DC
		public float YawLimitMax { get; set; }

		// Token: 0x1700B87E RID: 47230
		// (get) Token: 0x0602AB7F RID: 174975 RVA: 0x005E30E5 File Offset: 0x005E12E5
		// (set) Token: 0x0602AB80 RID: 174976 RVA: 0x005E30ED File Offset: 0x005E12ED
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B87F RID: 47231
		// (get) Token: 0x0602AB81 RID: 174977 RVA: 0x005E30F6 File Offset: 0x005E12F6
		// (set) Token: 0x0602AB82 RID: 174978 RVA: 0x005E30FE File Offset: 0x005E12FE
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B880 RID: 47232
		// (get) Token: 0x0602AB83 RID: 174979 RVA: 0x005E3107 File Offset: 0x005E1307
		// (set) Token: 0x0602AB84 RID: 174980 RVA: 0x005E310F File Offset: 0x005E130F
		public float Fov { get; set; }

		// Token: 0x1700B881 RID: 47233
		// (get) Token: 0x0602AB85 RID: 174981 RVA: 0x005E3118 File Offset: 0x005E1318
		// (set) Token: 0x0602AB86 RID: 174982 RVA: 0x005E3120 File Offset: 0x005E1320
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700B882 RID: 47234
		// (get) Token: 0x0602AB87 RID: 174983 RVA: 0x005E3129 File Offset: 0x005E1329
		// (set) Token: 0x0602AB88 RID: 174984 RVA: 0x005E3131 File Offset: 0x005E1331
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B883 RID: 47235
		// (get) Token: 0x0602AB89 RID: 174985 RVA: 0x005E313A File Offset: 0x005E133A
		// (set) Token: 0x0602AB8A RID: 174986 RVA: 0x005E3142 File Offset: 0x005E1342
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700B884 RID: 47236
		// (get) Token: 0x0602AB8B RID: 174987 RVA: 0x005E314B File Offset: 0x005E134B
		// (set) Token: 0x0602AB8C RID: 174988 RVA: 0x005E3153 File Offset: 0x005E1353
		public bool IsDisableDither { get; set; }

		// Token: 0x1700B885 RID: 47237
		// (get) Token: 0x0602AB8D RID: 174989 RVA: 0x005E315C File Offset: 0x005E135C
		// (set) Token: 0x0602AB8E RID: 174990 RVA: 0x005E3164 File Offset: 0x005E1364
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700B886 RID: 47238
		// (get) Token: 0x0602AB8F RID: 174991 RVA: 0x005E316D File Offset: 0x005E136D
		// (set) Token: 0x0602AB90 RID: 174992 RVA: 0x005E3175 File Offset: 0x005E1375
		public bool HidePlayer { get; set; }

		// Token: 0x1700B887 RID: 47239
		// (get) Token: 0x0602AB91 RID: 174993 RVA: 0x005E317E File Offset: 0x005E137E
		// (set) Token: 0x0602AB92 RID: 174994 RVA: 0x005E3186 File Offset: 0x005E1386
		public byte NullMask { get; set; }

		// Token: 0x0602AB93 RID: 174995 RVA: 0x005E3190 File Offset: 0x005E1390
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
