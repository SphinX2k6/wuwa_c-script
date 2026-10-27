using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004122 RID: 16674
	public class IShowUiConditionT
	{
		// Token: 0x17007613 RID: 30227
		// (get) Token: 0x060186C2 RID: 100034 RVA: 0x00385D81 File Offset: 0x00383F81
		// (set) Token: 0x060186C3 RID: 100035 RVA: 0x00385D89 File Offset: 0x00383F89
		public EChildQuest Type { get; set; }

		// Token: 0x17007614 RID: 30228
		// (get) Token: 0x060186C4 RID: 100036 RVA: 0x00385D92 File Offset: 0x00383F92
		// (set) Token: 0x060186C5 RID: 100037 RVA: 0x00385D9A File Offset: 0x00383F9A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007615 RID: 30229
		// (get) Token: 0x060186C6 RID: 100038 RVA: 0x00385DA3 File Offset: 0x00383FA3
		// (set) Token: 0x060186C7 RID: 100039 RVA: 0x00385DAB File Offset: 0x00383FAB
		public TShowUiUnion UiType { get; set; }

		// Token: 0x17007616 RID: 30230
		// (get) Token: 0x060186C8 RID: 100040 RVA: 0x00385DB4 File Offset: 0x00383FB4
		// (set) Token: 0x060186C9 RID: 100041 RVA: 0x00385DBC File Offset: 0x00383FBC
		public bool KeepUiOpen { get; set; }

		// Token: 0x17007617 RID: 30231
		// (get) Token: 0x060186CA RID: 100042 RVA: 0x00385DC5 File Offset: 0x00383FC5
		// (set) Token: 0x060186CB RID: 100043 RVA: 0x00385DCD File Offset: 0x00383FCD
		public byte NullMask { get; set; }

		// Token: 0x060186CC RID: 100044 RVA: 0x00385DD6 File Offset: 0x00383FD6
		public IShowUiConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.UiType = null;
			this.KeepUiOpen = false;
			this.NullMask = 0;
		}
	}
}
