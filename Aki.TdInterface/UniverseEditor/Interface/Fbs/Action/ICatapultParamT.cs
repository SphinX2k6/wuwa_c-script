using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006929 RID: 26921
	public class ICatapultParamT
	{
		// Token: 0x1700C635 RID: 50741
		// (get) Token: 0x0602E238 RID: 188984 RVA: 0x0064E04C File Offset: 0x0064C24C
		// (set) Token: 0x0602E239 RID: 188985 RVA: 0x0064E054 File Offset: 0x0064C254
		public IVectorInfoT P1 { get; set; }

		// Token: 0x1700C636 RID: 50742
		// (get) Token: 0x0602E23A RID: 188986 RVA: 0x0064E05D File Offset: 0x0064C25D
		// (set) Token: 0x0602E23B RID: 188987 RVA: 0x0064E065 File Offset: 0x0064C265
		public IVectorInfoT P2 { get; set; }

		// Token: 0x1700C637 RID: 50743
		// (get) Token: 0x0602E23C RID: 188988 RVA: 0x0064E06E File Offset: 0x0064C26E
		// (set) Token: 0x0602E23D RID: 188989 RVA: 0x0064E076 File Offset: 0x0064C276
		public float Gravity { get; set; }

		// Token: 0x1700C638 RID: 50744
		// (get) Token: 0x0602E23E RID: 188990 RVA: 0x0064E07F File Offset: 0x0064C27F
		// (set) Token: 0x0602E23F RID: 188991 RVA: 0x0064E087 File Offset: 0x0064C287
		public float Time { get; set; }

		// Token: 0x1700C639 RID: 50745
		// (get) Token: 0x0602E240 RID: 188992 RVA: 0x0064E090 File Offset: 0x0064C290
		// (set) Token: 0x0602E241 RID: 188993 RVA: 0x0064E098 File Offset: 0x0064C298
		public string MotionCurve { get; set; }

		// Token: 0x1700C63A RID: 50746
		// (get) Token: 0x0602E242 RID: 188994 RVA: 0x0064E0A1 File Offset: 0x0064C2A1
		// (set) Token: 0x0602E243 RID: 188995 RVA: 0x0064E0A9 File Offset: 0x0064C2A9
		public byte NullMask { get; set; }

		// Token: 0x0602E244 RID: 188996 RVA: 0x0064E0B2 File Offset: 0x0064C2B2
		public ICatapultParamT()
		{
			this.P1 = null;
			this.P2 = null;
			this.Gravity = 0f;
			this.Time = 0f;
			this.MotionCurve = null;
			this.NullMask = 0;
		}
	}
}
