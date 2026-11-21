using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A08 RID: 31240
	public class ISummonEntityTypeT
	{
		// Token: 0x1700E4F0 RID: 58608
		// (get) Token: 0x060370B6 RID: 225462 RVA: 0x0075B662 File Offset: 0x00759862
		// (set) Token: 0x060370B7 RID: 225463 RVA: 0x0075B66A File Offset: 0x0075986A
		public ESummonEntityType Type { get; set; }

		// Token: 0x060370B8 RID: 225464 RVA: 0x0075B673 File Offset: 0x00759873
		public ISummonEntityTypeT()
		{
			this.Type = ESummonEntityType.Vehicle;
		}
	}
}
