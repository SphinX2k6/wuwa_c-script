using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006324 RID: 25380
	public class IChangeStateT
	{
		// Token: 0x1700BD72 RID: 48498
		// (get) Token: 0x0602BE6B RID: 179819 RVA: 0x0060918E File Offset: 0x0060738E
		// (set) Token: 0x0602BE6C RID: 179820 RVA: 0x00609196 File Offset: 0x00607396
		public int StateId { get; set; }

		// Token: 0x0602BE6D RID: 179821 RVA: 0x0060919F File Offset: 0x0060739F
		public IChangeStateT()
		{
			this.StateId = 0;
		}
	}
}
