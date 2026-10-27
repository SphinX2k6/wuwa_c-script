using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006177 RID: 24951
	public class IAdjustZoneFollowCameraT
	{
		// Token: 0x1700B9EF RID: 47599
		// (get) Token: 0x0602AF6E RID: 175982 RVA: 0x005EDB8A File Offset: 0x005EBD8A
		// (set) Token: 0x0602AF6F RID: 175983 RVA: 0x005EDB92 File Offset: 0x005EBD92
		public EAdjustPlayerCamera Type { get; set; }

		// Token: 0x1700B9F0 RID: 47600
		// (get) Token: 0x0602AF70 RID: 175984 RVA: 0x005EDB9B File Offset: 0x005EBD9B
		// (set) Token: 0x0602AF71 RID: 175985 RVA: 0x005EDBA3 File Offset: 0x005EBDA3
		public int Priority { get; set; }

		// Token: 0x1700B9F1 RID: 47601
		// (get) Token: 0x0602AF72 RID: 175986 RVA: 0x005EDBAC File Offset: 0x005EBDAC
		// (set) Token: 0x0602AF73 RID: 175987 RVA: 0x005EDBB4 File Offset: 0x005EBDB4
		public float FadeInTime { get; set; }

		// Token: 0x1700B9F2 RID: 47602
		// (get) Token: 0x0602AF74 RID: 175988 RVA: 0x005EDBBD File Offset: 0x005EBDBD
		// (set) Token: 0x0602AF75 RID: 175989 RVA: 0x005EDBC5 File Offset: 0x005EBDC5
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x1700B9F3 RID: 47603
		// (get) Token: 0x0602AF76 RID: 175990 RVA: 0x005EDBCE File Offset: 0x005EBDCE
		// (set) Token: 0x0602AF77 RID: 175991 RVA: 0x005EDBD6 File Offset: 0x005EBDD6
		public float FadeOutTime { get; set; }

		// Token: 0x1700B9F4 RID: 47604
		// (get) Token: 0x0602AF78 RID: 175992 RVA: 0x005EDBDF File Offset: 0x005EBDDF
		// (set) Token: 0x0602AF79 RID: 175993 RVA: 0x005EDBE7 File Offset: 0x005EBDE7
		public IBaseCurveT FadeOutCurve { get; set; }

		// Token: 0x1700B9F5 RID: 47605
		// (get) Token: 0x0602AF7A RID: 175994 RVA: 0x005EDBF0 File Offset: 0x005EBDF0
		// (set) Token: 0x0602AF7B RID: 175995 RVA: 0x005EDBF8 File Offset: 0x005EBDF8
		public float ArmLength { get; set; }

		// Token: 0x1700B9F6 RID: 47606
		// (get) Token: 0x0602AF7C RID: 175996 RVA: 0x005EDC01 File Offset: 0x005EBE01
		// (set) Token: 0x0602AF7D RID: 175997 RVA: 0x005EDC09 File Offset: 0x005EBE09
		public float MinumArmLength { get; set; }

		// Token: 0x1700B9F7 RID: 47607
		// (get) Token: 0x0602AF7E RID: 175998 RVA: 0x005EDC12 File Offset: 0x005EBE12
		// (set) Token: 0x0602AF7F RID: 175999 RVA: 0x005EDC1A File Offset: 0x005EBE1A
		public float MaxiumArmLength { get; set; }

		// Token: 0x1700B9F8 RID: 47608
		// (get) Token: 0x0602AF80 RID: 176000 RVA: 0x005EDC23 File Offset: 0x005EBE23
		// (set) Token: 0x0602AF81 RID: 176001 RVA: 0x005EDC2B File Offset: 0x005EBE2B
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B9F9 RID: 47609
		// (get) Token: 0x0602AF82 RID: 176002 RVA: 0x005EDC34 File Offset: 0x005EBE34
		// (set) Token: 0x0602AF83 RID: 176003 RVA: 0x005EDC3C File Offset: 0x005EBE3C
		public IVectorInfoT ArmOffset { get; set; }

		// Token: 0x1700B9FA RID: 47610
		// (get) Token: 0x0602AF84 RID: 176004 RVA: 0x005EDC45 File Offset: 0x005EBE45
		// (set) Token: 0x0602AF85 RID: 176005 RVA: 0x005EDC4D File Offset: 0x005EBE4D
		public float YawLimitMin { get; set; }

		// Token: 0x1700B9FB RID: 47611
		// (get) Token: 0x0602AF86 RID: 176006 RVA: 0x005EDC56 File Offset: 0x005EBE56
		// (set) Token: 0x0602AF87 RID: 176007 RVA: 0x005EDC5E File Offset: 0x005EBE5E
		public float YawLimitMax { get; set; }

		// Token: 0x1700B9FC RID: 47612
		// (get) Token: 0x0602AF88 RID: 176008 RVA: 0x005EDC67 File Offset: 0x005EBE67
		// (set) Token: 0x0602AF89 RID: 176009 RVA: 0x005EDC6F File Offset: 0x005EBE6F
		public float PitchLimitMin { get; set; }

		// Token: 0x1700B9FD RID: 47613
		// (get) Token: 0x0602AF8A RID: 176010 RVA: 0x005EDC78 File Offset: 0x005EBE78
		// (set) Token: 0x0602AF8B RID: 176011 RVA: 0x005EDC80 File Offset: 0x005EBE80
		public float PitchLimitMax { get; set; }

		// Token: 0x1700B9FE RID: 47614
		// (get) Token: 0x0602AF8C RID: 176012 RVA: 0x005EDC89 File Offset: 0x005EBE89
		// (set) Token: 0x0602AF8D RID: 176013 RVA: 0x005EDC91 File Offset: 0x005EBE91
		public float Fov { get; set; }

		// Token: 0x1700B9FF RID: 47615
		// (get) Token: 0x0602AF8E RID: 176014 RVA: 0x005EDC9A File Offset: 0x005EBE9A
		// (set) Token: 0x0602AF8F RID: 176015 RVA: 0x005EDCA2 File Offset: 0x005EBEA2
		public bool IsDisableResetFocus { get; set; }

		// Token: 0x1700BA00 RID: 47616
		// (get) Token: 0x0602AF90 RID: 176016 RVA: 0x005EDCAB File Offset: 0x005EBEAB
		// (set) Token: 0x0602AF91 RID: 176017 RVA: 0x005EDCB3 File Offset: 0x005EBEB3
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700BA01 RID: 47617
		// (get) Token: 0x0602AF92 RID: 176018 RVA: 0x005EDCBC File Offset: 0x005EBEBC
		// (set) Token: 0x0602AF93 RID: 176019 RVA: 0x005EDCC4 File Offset: 0x005EBEC4
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700BA02 RID: 47618
		// (get) Token: 0x0602AF94 RID: 176020 RVA: 0x005EDCCD File Offset: 0x005EBECD
		// (set) Token: 0x0602AF95 RID: 176021 RVA: 0x005EDCD5 File Offset: 0x005EBED5
		public bool IsDisableDither { get; set; }

		// Token: 0x1700BA03 RID: 47619
		// (get) Token: 0x0602AF96 RID: 176022 RVA: 0x005EDCDE File Offset: 0x005EBEDE
		// (set) Token: 0x0602AF97 RID: 176023 RVA: 0x005EDCE6 File Offset: 0x005EBEE6
		public string SubScreenBindKey { get; set; }

		// Token: 0x1700BA04 RID: 47620
		// (get) Token: 0x0602AF98 RID: 176024 RVA: 0x005EDCEF File Offset: 0x005EBEEF
		// (set) Token: 0x0602AF99 RID: 176025 RVA: 0x005EDCF7 File Offset: 0x005EBEF7
		public bool IsFollowPlayer { get; set; }

		// Token: 0x1700BA05 RID: 47621
		// (get) Token: 0x0602AF9A RID: 176026 RVA: 0x005EDD00 File Offset: 0x005EBF00
		// (set) Token: 0x0602AF9B RID: 176027 RVA: 0x005EDD08 File Offset: 0x005EBF08
		public int SceneActorRefEntityId { get; set; }

		// Token: 0x1700BA06 RID: 47622
		// (get) Token: 0x0602AF9C RID: 176028 RVA: 0x005EDD11 File Offset: 0x005EBF11
		// (set) Token: 0x0602AF9D RID: 176029 RVA: 0x005EDD19 File Offset: 0x005EBF19
		public byte NullMask { get; set; }

		// Token: 0x0602AF9E RID: 176030 RVA: 0x005EDD24 File Offset: 0x005EBF24
		public IAdjustZoneFollowCameraT()
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
			this.IsFollowPlayer = false;
			this.SceneActorRefEntityId = 0;
			this.NullMask = 0;
		}
	}
}
