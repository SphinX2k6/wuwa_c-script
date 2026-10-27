using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411F RID: 16671
	public class IShowUiAllT
	{
		// Token: 0x1700760C RID: 30220
		// (get) Token: 0x06018699 RID: 99993 RVA: 0x003854C6 File Offset: 0x003836C6
		// (set) Token: 0x0601869A RID: 99994 RVA: 0x003854CE File Offset: 0x003836CE
		public EShowUiType Type { get; set; }

		// Token: 0x0601869B RID: 99995 RVA: 0x003854D7 File Offset: 0x003836D7
		public IShowUiAllT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
