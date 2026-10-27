using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B8 RID: 25272
	public class ICatapultParamT
	{
		// Token: 0x1700BCAB RID: 48299
		// (get) Token: 0x0602BACF RID: 178895 RVA: 0x00603040 File Offset: 0x00601240
		// (set) Token: 0x0602BAD0 RID: 178896 RVA: 0x00603048 File Offset: 0x00601248
		public IVectorInfoT P1 { get; set; }

		// Token: 0x1700BCAC RID: 48300
		// (get) Token: 0x0602BAD1 RID: 178897 RVA: 0x00603051 File Offset: 0x00601251
		// (set) Token: 0x0602BAD2 RID: 178898 RVA: 0x00603059 File Offset: 0x00601259
		public IVectorInfoT P2 { get; set; }

		// Token: 0x1700BCAD RID: 48301
		// (get) Token: 0x0602BAD3 RID: 178899 RVA: 0x00603062 File Offset: 0x00601262
		// (set) Token: 0x0602BAD4 RID: 178900 RVA: 0x0060306A File Offset: 0x0060126A
		public float Gravity { get; set; }

		// Token: 0x1700BCAE RID: 48302
		// (get) Token: 0x0602BAD5 RID: 178901 RVA: 0x00603073 File Offset: 0x00601273
		// (set) Token: 0x0602BAD6 RID: 178902 RVA: 0x0060307B File Offset: 0x0060127B
		public float Time { get; set; }

		// Token: 0x1700BCAF RID: 48303
		// (get) Token: 0x0602BAD7 RID: 178903 RVA: 0x00603084 File Offset: 0x00601284
		// (set) Token: 0x0602BAD8 RID: 178904 RVA: 0x0060308C File Offset: 0x0060128C
		public string MotionCurve { get; set; }

		// Token: 0x1700BCB0 RID: 48304
		// (get) Token: 0x0602BAD9 RID: 178905 RVA: 0x00603095 File Offset: 0x00601295
		// (set) Token: 0x0602BADA RID: 178906 RVA: 0x0060309D File Offset: 0x0060129D
		public byte NullMask { get; set; }

		// Token: 0x0602BADB RID: 178907 RVA: 0x006030A6 File Offset: 0x006012A6
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
