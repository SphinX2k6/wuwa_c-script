using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079DE RID: 31198
	public class ISubScreenInitDataT
	{
		// Token: 0x1700E4BB RID: 58555
		// (get) Token: 0x06036F8A RID: 225162 RVA: 0x007596C3 File Offset: 0x007578C3
		// (set) Token: 0x06036F8B RID: 225163 RVA: 0x007596CB File Offset: 0x007578CB
		public ESubScreenInitDataType Type { get; set; }

		// Token: 0x1700E4BC RID: 58556
		// (get) Token: 0x06036F8C RID: 225164 RVA: 0x007596D4 File Offset: 0x007578D4
		// (set) Token: 0x06036F8D RID: 225165 RVA: 0x007596DC File Offset: 0x007578DC
		public string SubScreenKey { get; set; }

		// Token: 0x06036F8E RID: 225166 RVA: 0x007596E5 File Offset: 0x007578E5
		public ISubScreenInitDataT()
		{
			this.Type = ESubScreenInitDataType.Preset;
			this.SubScreenKey = null;
		}
	}
}
