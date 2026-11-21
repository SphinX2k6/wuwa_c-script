using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079DB RID: 31195
	public class ISubScreenCustomInitDataT
	{
		// Token: 0x1700E4B5 RID: 58549
		// (get) Token: 0x06036F70 RID: 225136 RVA: 0x00759445 File Offset: 0x00757645
		// (set) Token: 0x06036F71 RID: 225137 RVA: 0x0075944D File Offset: 0x0075764D
		public ESubScreenInitDataType Type { get; set; }

		// Token: 0x1700E4B6 RID: 58550
		// (get) Token: 0x06036F72 RID: 225138 RVA: 0x00759456 File Offset: 0x00757656
		// (set) Token: 0x06036F73 RID: 225139 RVA: 0x0075945E File Offset: 0x0075765E
		public string SubScreenKey { get; set; }

		// Token: 0x1700E4B7 RID: 58551
		// (get) Token: 0x06036F74 RID: 225140 RVA: 0x00759467 File Offset: 0x00757667
		// (set) Token: 0x06036F75 RID: 225141 RVA: 0x0075946F File Offset: 0x0075766F
		public ISubScreenConfigT InitConfig { get; set; }

		// Token: 0x06036F76 RID: 225142 RVA: 0x00759478 File Offset: 0x00757678
		public ISubScreenCustomInitDataT()
		{
			this.Type = ESubScreenInitDataType.Preset;
			this.SubScreenKey = null;
			this.InitConfig = null;
		}
	}
}
