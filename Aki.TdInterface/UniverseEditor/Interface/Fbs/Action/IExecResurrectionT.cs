using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006712 RID: 26386
	public class IExecResurrectionT
	{
		// Token: 0x1700C402 RID: 50178
		// (get) Token: 0x0602DE51 RID: 187985 RVA: 0x006468FA File Offset: 0x00644AFA
		// (set) Token: 0x0602DE52 RID: 187986 RVA: 0x00646902 File Offset: 0x00644B02
		public int ReviveId { get; set; }

		// Token: 0x0602DE53 RID: 187987 RVA: 0x0064690B File Offset: 0x00644B0B
		public IExecResurrectionT()
		{
			this.ReviveId = 0;
		}
	}
}
