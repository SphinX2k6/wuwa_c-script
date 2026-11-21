using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC1 RID: 20161
	public class ICheckEntityGravityDirectionT
	{
		// Token: 0x17008FE4 RID: 36836
		// (get) Token: 0x0601F465 RID: 128101 RVA: 0x0045C199 File Offset: 0x0045A399
		// (set) Token: 0x0601F466 RID: 128102 RVA: 0x0045C1A1 File Offset: 0x0045A3A1
		public ECondition Type { get; set; }

		// Token: 0x17008FE5 RID: 36837
		// (get) Token: 0x0601F467 RID: 128103 RVA: 0x0045C1AA File Offset: 0x0045A3AA
		// (set) Token: 0x0601F468 RID: 128104 RVA: 0x0045C1B2 File Offset: 0x0045A3B2
		public TCheckTargetUnion Target { get; set; }

		// Token: 0x17008FE6 RID: 36838
		// (get) Token: 0x0601F469 RID: 128105 RVA: 0x0045C1BB File Offset: 0x0045A3BB
		// (set) Token: 0x0601F46A RID: 128106 RVA: 0x0045C1C3 File Offset: 0x0045A3C3
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17008FE7 RID: 36839
		// (get) Token: 0x0601F46B RID: 128107 RVA: 0x0045C1CC File Offset: 0x0045A3CC
		// (set) Token: 0x0601F46C RID: 128108 RVA: 0x0045C1D4 File Offset: 0x0045A3D4
		public bool IsNotInTargetDirection { get; set; }

		// Token: 0x17008FE8 RID: 36840
		// (get) Token: 0x0601F46D RID: 128109 RVA: 0x0045C1DD File Offset: 0x0045A3DD
		// (set) Token: 0x0601F46E RID: 128110 RVA: 0x0045C1E5 File Offset: 0x0045A3E5
		public byte NullMask { get; set; }

		// Token: 0x0601F46F RID: 128111 RVA: 0x0045C1EE File Offset: 0x0045A3EE
		public ICheckEntityGravityDirectionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.GravityDirection = null;
			this.IsNotInTargetDirection = false;
			this.NullMask = 0;
		}
	}
}
