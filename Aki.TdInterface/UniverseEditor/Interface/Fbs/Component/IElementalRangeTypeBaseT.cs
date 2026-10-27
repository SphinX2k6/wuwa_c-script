using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005139 RID: 20793
	public class IElementalRangeTypeBaseT
	{
		// Token: 0x1700978E RID: 38798
		// (get) Token: 0x0602189E RID: 137374 RVA: 0x004A806A File Offset: 0x004A626A
		// (set) Token: 0x0602189F RID: 137375 RVA: 0x004A8072 File Offset: 0x004A6272
		public EElementalRangeType Type { get; set; }

		// Token: 0x060218A0 RID: 137376 RVA: 0x004A807B File Offset: 0x004A627B
		public IElementalRangeTypeBaseT()
		{
			this.Type = EElementalRangeType.BaseShape;
		}
	}
}
