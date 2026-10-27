using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411C RID: 16668
	public class IShowUiT
	{
		// Token: 0x17007609 RID: 30217
		// (get) Token: 0x06018687 RID: 99975 RVA: 0x0038534E File Offset: 0x0038354E
		// (set) Token: 0x06018688 RID: 99976 RVA: 0x00385356 File Offset: 0x00383556
		public EShowUiType Type { get; set; }

		// Token: 0x06018689 RID: 99977 RVA: 0x0038535F File Offset: 0x0038355F
		public IShowUiT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
