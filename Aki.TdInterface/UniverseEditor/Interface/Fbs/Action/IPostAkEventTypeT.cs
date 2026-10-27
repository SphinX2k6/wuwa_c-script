using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7E RID: 28030
	public class IPostAkEventTypeT
	{
		// Token: 0x1700D127 RID: 53543
		// (get) Token: 0x06031844 RID: 202820 RVA: 0x006B65DA File Offset: 0x006B47DA
		// (set) Token: 0x06031845 RID: 202821 RVA: 0x006B65E2 File Offset: 0x006B47E2
		public EPostAkEvent Type { get; set; }

		// Token: 0x06031846 RID: 202822 RVA: 0x006B65EB File Offset: 0x006B47EB
		public IPostAkEventTypeT()
		{
			this.Type = EPostAkEvent.Global;
		}
	}
}
