using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007047 RID: 28743
	public class ISetNumberVarT
	{
		// Token: 0x1700D57F RID: 54655
		// (get) Token: 0x06032DCF RID: 208335 RVA: 0x006DC62B File Offset: 0x006DA82B
		// (set) Token: 0x06032DD0 RID: 208336 RVA: 0x006DC633 File Offset: 0x006DA833
		public string Name { get; set; }

		// Token: 0x1700D580 RID: 54656
		// (get) Token: 0x06032DD1 RID: 208337 RVA: 0x006DC63C File Offset: 0x006DA83C
		// (set) Token: 0x06032DD2 RID: 208338 RVA: 0x006DC644 File Offset: 0x006DA844
		public TVarValueUnion Value { get; set; }

		// Token: 0x06032DD3 RID: 208339 RVA: 0x006DC64D File Offset: 0x006DA84D
		public ISetNumberVarT()
		{
			this.Name = null;
			this.Value = null;
		}
	}
}
