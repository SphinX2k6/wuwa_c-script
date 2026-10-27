using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC1 RID: 16065
	public class IItemVariableBaseT
	{
		// Token: 0x17006F85 RID: 28549
		// (get) Token: 0x06016B4C RID: 93004 RVA: 0x00347483 File Offset: 0x00345683
		// (set) Token: 0x06016B4D RID: 93005 RVA: 0x0034748B File Offset: 0x0034568B
		public EHandInItemType Type { get; set; }

		// Token: 0x17006F86 RID: 28550
		// (get) Token: 0x06016B4E RID: 93006 RVA: 0x00347494 File Offset: 0x00345694
		// (set) Token: 0x06016B4F RID: 93007 RVA: 0x0034749C File Offset: 0x0034569C
		public TVarRefUnion Var { get; set; }

		// Token: 0x06016B50 RID: 93008 RVA: 0x003474A5 File Offset: 0x003456A5
		public IItemVariableBaseT()
		{
			this.Type = EHandInItemType.ItemIds;
			this.Var = null;
		}
	}
}
