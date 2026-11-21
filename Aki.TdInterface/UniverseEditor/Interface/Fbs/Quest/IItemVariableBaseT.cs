using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FF RID: 17151
	public class IItemVariableBaseT
	{
		// Token: 0x17007572 RID: 30066
		// (get) Token: 0x06018199 RID: 98713 RVA: 0x0037040B File Offset: 0x0036E60B
		// (set) Token: 0x0601819A RID: 98714 RVA: 0x00370413 File Offset: 0x0036E613
		public EHandInItemType Type { get; set; }

		// Token: 0x17007573 RID: 30067
		// (get) Token: 0x0601819B RID: 98715 RVA: 0x0037041C File Offset: 0x0036E61C
		// (set) Token: 0x0601819C RID: 98716 RVA: 0x00370424 File Offset: 0x0036E624
		public TVarRefUnion Var { get; set; }

		// Token: 0x0601819D RID: 98717 RVA: 0x0037042D File Offset: 0x0036E62D
		public IItemVariableBaseT()
		{
			this.Type = EHandInItemType.ItemIds;
			this.Var = null;
		}
	}
}
