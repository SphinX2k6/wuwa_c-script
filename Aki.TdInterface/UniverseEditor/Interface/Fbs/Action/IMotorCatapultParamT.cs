using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B13 RID: 27411
	public class IMotorCatapultParamT
	{
		// Token: 0x1700CB9A RID: 52122
		// (get) Token: 0x06030176 RID: 196982 RVA: 0x00689A4F File Offset: 0x00687C4F
		// (set) Token: 0x06030177 RID: 196983 RVA: 0x00689A57 File Offset: 0x00687C57
		public IVectorInfoT P1 { get; set; }

		// Token: 0x1700CB9B RID: 52123
		// (get) Token: 0x06030178 RID: 196984 RVA: 0x00689A60 File Offset: 0x00687C60
		// (set) Token: 0x06030179 RID: 196985 RVA: 0x00689A68 File Offset: 0x00687C68
		public IVectorInfoT P2 { get; set; }

		// Token: 0x1700CB9C RID: 52124
		// (get) Token: 0x0603017A RID: 196986 RVA: 0x00689A71 File Offset: 0x00687C71
		// (set) Token: 0x0603017B RID: 196987 RVA: 0x00689A79 File Offset: 0x00687C79
		public float Gravity { get; set; }

		// Token: 0x1700CB9D RID: 52125
		// (get) Token: 0x0603017C RID: 196988 RVA: 0x00689A82 File Offset: 0x00687C82
		// (set) Token: 0x0603017D RID: 196989 RVA: 0x00689A8A File Offset: 0x00687C8A
		public float Time { get; set; }

		// Token: 0x1700CB9E RID: 52126
		// (get) Token: 0x0603017E RID: 196990 RVA: 0x00689A93 File Offset: 0x00687C93
		// (set) Token: 0x0603017F RID: 196991 RVA: 0x00689A9B File Offset: 0x00687C9B
		public string MotionCurve { get; set; }

		// Token: 0x1700CB9F RID: 52127
		// (get) Token: 0x06030180 RID: 196992 RVA: 0x00689AA4 File Offset: 0x00687CA4
		// (set) Token: 0x06030181 RID: 196993 RVA: 0x00689AAC File Offset: 0x00687CAC
		public IVectorInfoT P2Rot { get; set; }

		// Token: 0x1700CBA0 RID: 52128
		// (get) Token: 0x06030182 RID: 196994 RVA: 0x00689AB5 File Offset: 0x00687CB5
		// (set) Token: 0x06030183 RID: 196995 RVA: 0x00689ABD File Offset: 0x00687CBD
		public string P2RotCurve { get; set; }

		// Token: 0x1700CBA1 RID: 52129
		// (get) Token: 0x06030184 RID: 196996 RVA: 0x00689AC6 File Offset: 0x00687CC6
		// (set) Token: 0x06030185 RID: 196997 RVA: 0x00689ACE File Offset: 0x00687CCE
		public byte NullMask { get; set; }

		// Token: 0x06030186 RID: 196998 RVA: 0x00689AD8 File Offset: 0x00687CD8
		public IMotorCatapultParamT()
		{
			this.P1 = null;
			this.P2 = null;
			this.Gravity = 0f;
			this.Time = 0f;
			this.MotionCurve = null;
			this.P2Rot = null;
			this.P2RotCurve = null;
			this.NullMask = 0;
		}
	}
}
