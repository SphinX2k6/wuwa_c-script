using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697C RID: 27004
	public class IInteractT
	{
		// Token: 0x1700C848 RID: 51272
		// (get) Token: 0x0602F292 RID: 193170 RVA: 0x0066CB0B File Offset: 0x0066AD0B
		// (set) Token: 0x0602F293 RID: 193171 RVA: 0x0066CB13 File Offset: 0x0066AD13
		public int Who { get; set; }

		// Token: 0x1700C849 RID: 51273
		// (get) Token: 0x0602F294 RID: 193172 RVA: 0x0066CB1C File Offset: 0x0066AD1C
		// (set) Token: 0x0602F295 RID: 193173 RVA: 0x0066CB24 File Offset: 0x0066AD24
		public string Param { get; set; }

		// Token: 0x0602F296 RID: 193174 RVA: 0x0066CB2D File Offset: 0x0066AD2D
		public IInteractT()
		{
			this.Who = 0;
			this.Param = null;
		}
	}
}
