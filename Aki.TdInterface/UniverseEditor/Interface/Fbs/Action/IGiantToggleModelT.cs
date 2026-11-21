using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F30 RID: 28464
	public class IGiantToggleModelT
	{
		// Token: 0x1700D0A5 RID: 53413
		// (get) Token: 0x06031420 RID: 201760 RVA: 0x006AC672 File Offset: 0x006AA872
		// (set) Token: 0x06031421 RID: 201761 RVA: 0x006AC67A File Offset: 0x006AA87A
		public bool IsEnabled { get; set; }

		// Token: 0x06031422 RID: 201762 RVA: 0x006AC683 File Offset: 0x006AA883
		public IGiantToggleModelT()
		{
			this.IsEnabled = false;
		}
	}
}
