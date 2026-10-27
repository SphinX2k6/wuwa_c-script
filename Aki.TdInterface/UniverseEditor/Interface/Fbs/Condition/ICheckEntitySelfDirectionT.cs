using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A19 RID: 18969
	public class ICheckEntitySelfDirectionT
	{
		// Token: 0x17008956 RID: 35158
		// (get) Token: 0x0601DAED RID: 121581 RVA: 0x0042D1FD File Offset: 0x0042B3FD
		// (set) Token: 0x0601DAEE RID: 121582 RVA: 0x0042D205 File Offset: 0x0042B405
		public ECondition Type { get; set; }

		// Token: 0x17008957 RID: 35159
		// (get) Token: 0x0601DAEF RID: 121583 RVA: 0x0042D20E File Offset: 0x0042B40E
		// (set) Token: 0x0601DAF0 RID: 121584 RVA: 0x0042D216 File Offset: 0x0042B416
		public IVectorInfoT Direction { get; set; }

		// Token: 0x17008958 RID: 35160
		// (get) Token: 0x0601DAF1 RID: 121585 RVA: 0x0042D21F File Offset: 0x0042B41F
		// (set) Token: 0x0601DAF2 RID: 121586 RVA: 0x0042D227 File Offset: 0x0042B427
		public float Tolerance { get; set; }

		// Token: 0x0601DAF3 RID: 121587 RVA: 0x0042D230 File Offset: 0x0042B430
		public ICheckEntitySelfDirectionT()
		{
			this.Type = ECondition.CompareVar;
			this.Direction = null;
			this.Tolerance = 0f;
		}
	}
}
