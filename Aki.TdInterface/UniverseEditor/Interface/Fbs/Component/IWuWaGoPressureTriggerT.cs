using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCE RID: 23502
	public class IWuWaGoPressureTriggerT
	{
		// Token: 0x1700B196 RID: 45462
		// (get) Token: 0x06028445 RID: 164933 RVA: 0x00588626 File Offset: 0x00586826
		// (set) Token: 0x06028446 RID: 164934 RVA: 0x0058862E File Offset: 0x0058682E
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B197 RID: 45463
		// (get) Token: 0x06028447 RID: 164935 RVA: 0x00588637 File Offset: 0x00586837
		// (set) Token: 0x06028448 RID: 164936 RVA: 0x0058863F File Offset: 0x0058683F
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700B198 RID: 45464
		// (get) Token: 0x06028449 RID: 164937 RVA: 0x00588648 File Offset: 0x00586848
		// (set) Token: 0x0602844A RID: 164938 RVA: 0x00588650 File Offset: 0x00586850
		public List<IActionInfoT> EnterActionList { get; set; }

		// Token: 0x1700B199 RID: 45465
		// (get) Token: 0x0602844B RID: 164939 RVA: 0x00588659 File Offset: 0x00586859
		// (set) Token: 0x0602844C RID: 164940 RVA: 0x00588661 File Offset: 0x00586861
		public List<IActionInfoT> ExitActionList { get; set; }

		// Token: 0x0602844D RID: 164941 RVA: 0x0058866A File Offset: 0x0058686A
		public IWuWaGoPressureTriggerT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.EnterActionList = null;
			this.ExitActionList = null;
		}
	}
}
