using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007233 RID: 29235
	public class ISummonEntityTypeT
	{
		// Token: 0x1700D8F7 RID: 55543
		// (get) Token: 0x06033DB4 RID: 212404 RVA: 0x006FA302 File Offset: 0x006F8502
		// (set) Token: 0x06033DB5 RID: 212405 RVA: 0x006FA30A File Offset: 0x006F850A
		public ESummonEntityType Type { get; set; }

		// Token: 0x06033DB6 RID: 212406 RVA: 0x006FA313 File Offset: 0x006F8513
		public ISummonEntityTypeT()
		{
			this.Type = ESummonEntityType.Vehicle;
		}
	}
}
