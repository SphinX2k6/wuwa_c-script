using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005422 RID: 21538
	public class IBaseShapeElementalRangeT
	{
		// Token: 0x170098D4 RID: 39124
		// (get) Token: 0x06021BEA RID: 138218 RVA: 0x004A6FC7 File Offset: 0x004A51C7
		// (set) Token: 0x06021BEB RID: 138219 RVA: 0x004A6FCF File Offset: 0x004A51CF
		public EElementalRangeType Type { get; set; }

		// Token: 0x170098D5 RID: 39125
		// (get) Token: 0x06021BEC RID: 138220 RVA: 0x004A6FD8 File Offset: 0x004A51D8
		// (set) Token: 0x06021BED RID: 138221 RVA: 0x004A6FE0 File Offset: 0x004A51E0
		public TTriggerShapeUnion Shape { get; set; }

		// Token: 0x06021BEE RID: 138222 RVA: 0x004A6FE9 File Offset: 0x004A51E9
		public IBaseShapeElementalRangeT()
		{
			this.Type = EElementalRangeType.BaseShape;
			this.Shape = null;
		}
	}
}
