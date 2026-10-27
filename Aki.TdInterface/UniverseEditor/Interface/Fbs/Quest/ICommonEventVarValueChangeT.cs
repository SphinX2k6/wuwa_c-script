using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D98 RID: 15768
	public class ICommonEventVarValueChangeT
	{
		// Token: 0x17006C72 RID: 27762
		// (get) Token: 0x06015E73 RID: 89715 RVA: 0x00329A4F File Offset: 0x00327C4F
		// (set) Token: 0x06015E74 RID: 89716 RVA: 0x00329A57 File Offset: 0x00327C57
		public ECommonEventType Type { get; set; }

		// Token: 0x17006C73 RID: 27763
		// (get) Token: 0x06015E75 RID: 89717 RVA: 0x00329A60 File Offset: 0x00327C60
		// (set) Token: 0x06015E76 RID: 89718 RVA: 0x00329A68 File Offset: 0x00327C68
		public TVarRefUnion Var { get; set; }

		// Token: 0x06015E77 RID: 89719 RVA: 0x00329A71 File Offset: 0x00327C71
		public ICommonEventVarValueChangeT()
		{
			this.Type = ECommonEventType.VarValueChange;
			this.Var = null;
		}
	}
}
