using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005425 RID: 21541
	public class IBaseSplinePointTypeT
	{
		// Token: 0x170098DC RID: 39132
		// (get) Token: 0x06021C06 RID: 138246 RVA: 0x004A74C7 File Offset: 0x004A56C7
		// (set) Token: 0x06021C07 RID: 138247 RVA: 0x004A74CF File Offset: 0x004A56CF
		public IVectorInfoT Position { get; set; }

		// Token: 0x170098DD RID: 39133
		// (get) Token: 0x06021C08 RID: 138248 RVA: 0x004A74D8 File Offset: 0x004A56D8
		// (set) Token: 0x06021C09 RID: 138249 RVA: 0x004A74E0 File Offset: 0x004A56E0
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x170098DE RID: 39134
		// (get) Token: 0x06021C0A RID: 138250 RVA: 0x004A74E9 File Offset: 0x004A56E9
		// (set) Token: 0x06021C0B RID: 138251 RVA: 0x004A74F1 File Offset: 0x004A56F1
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x170098DF RID: 39135
		// (get) Token: 0x06021C0C RID: 138252 RVA: 0x004A74FA File Offset: 0x004A56FA
		// (set) Token: 0x06021C0D RID: 138253 RVA: 0x004A7502 File Offset: 0x004A5702
		public ESplineLine LineType { get; set; }

		// Token: 0x170098E0 RID: 39136
		// (get) Token: 0x06021C0E RID: 138254 RVA: 0x004A750B File Offset: 0x004A570B
		// (set) Token: 0x06021C0F RID: 138255 RVA: 0x004A7513 File Offset: 0x004A5713
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x06021C10 RID: 138256 RVA: 0x004A751C File Offset: 0x004A571C
		public IBaseSplinePointTypeT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
		}
	}
}
