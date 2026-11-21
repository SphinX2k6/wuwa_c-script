using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005533 RID: 21811
	public class ICommonSplinePointT
	{
		// Token: 0x17009BEB RID: 39915
		// (get) Token: 0x060227E5 RID: 141285 RVA: 0x004C06DF File Offset: 0x004BE8DF
		// (set) Token: 0x060227E6 RID: 141286 RVA: 0x004C06E7 File Offset: 0x004BE8E7
		public IVectorInfoT Position { get; set; }

		// Token: 0x17009BEC RID: 39916
		// (get) Token: 0x060227E7 RID: 141287 RVA: 0x004C06F0 File Offset: 0x004BE8F0
		// (set) Token: 0x060227E8 RID: 141288 RVA: 0x004C06F8 File Offset: 0x004BE8F8
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x17009BED RID: 39917
		// (get) Token: 0x060227E9 RID: 141289 RVA: 0x004C0701 File Offset: 0x004BE901
		// (set) Token: 0x060227EA RID: 141290 RVA: 0x004C0709 File Offset: 0x004BE909
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x17009BEE RID: 39918
		// (get) Token: 0x060227EB RID: 141291 RVA: 0x004C0712 File Offset: 0x004BE912
		// (set) Token: 0x060227EC RID: 141292 RVA: 0x004C071A File Offset: 0x004BE91A
		public ESplineLine LineType { get; set; }

		// Token: 0x17009BEF RID: 39919
		// (get) Token: 0x060227ED RID: 141293 RVA: 0x004C0723 File Offset: 0x004BE923
		// (set) Token: 0x060227EE RID: 141294 RVA: 0x004C072B File Offset: 0x004BE92B
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x060227EF RID: 141295 RVA: 0x004C0734 File Offset: 0x004BE934
		public ICommonSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
		}
	}
}
