using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E7 RID: 31207
	public class ISubScreenModeConfigT
	{
		// Token: 0x1700E4C6 RID: 58566
		// (get) Token: 0x06036FC8 RID: 225224 RVA: 0x00759D52 File Offset: 0x00757F52
		// (set) Token: 0x06036FC9 RID: 225225 RVA: 0x00759D5A File Offset: 0x00757F5A
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x06036FCA RID: 225226 RVA: 0x00759D63 File Offset: 0x00757F63
		public ISubScreenModeConfigT()
		{
			this.Type = ESubScreenOperationType.Init;
		}
	}
}
