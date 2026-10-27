using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007191 RID: 29073
	public class ISplineMoveTargetTypeT
	{
		// Token: 0x1700D7F4 RID: 55284
		// (get) Token: 0x060338C6 RID: 211142 RVA: 0x006F1686 File Offset: 0x006EF886
		// (set) Token: 0x060338C7 RID: 211143 RVA: 0x006F168E File Offset: 0x006EF88E
		public ESplineMoveTargetType Type { get; set; }

		// Token: 0x060338C8 RID: 211144 RVA: 0x006F1697 File Offset: 0x006EF897
		public ISplineMoveTargetTypeT()
		{
			this.Type = ESplineMoveTargetType.Entity;
		}
	}
}
