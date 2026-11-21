using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D3E RID: 23870
	public class IPickInteractComponentT
	{
		// Token: 0x1700AF95 RID: 44949
		// (get) Token: 0x06027B41 RID: 162625 RVA: 0x0056E9FD File Offset: 0x0056CBFD
		// (set) Token: 0x06027B42 RID: 162626 RVA: 0x0056EA05 File Offset: 0x0056CC05
		public bool Disabled { get; set; }

		// Token: 0x1700AF96 RID: 44950
		// (get) Token: 0x06027B43 RID: 162627 RVA: 0x0056EA0E File Offset: 0x0056CC0E
		// (set) Token: 0x06027B44 RID: 162628 RVA: 0x0056EA16 File Offset: 0x0056CC16
		public IChessmanPickInteractionT PickInteractType { get; set; }

		// Token: 0x1700AF97 RID: 44951
		// (get) Token: 0x06027B45 RID: 162629 RVA: 0x0056EA1F File Offset: 0x0056CC1F
		// (set) Token: 0x06027B46 RID: 162630 RVA: 0x0056EA27 File Offset: 0x0056CC27
		public byte NullMask { get; set; }

		// Token: 0x06027B47 RID: 162631 RVA: 0x0056EA30 File Offset: 0x0056CC30
		public IPickInteractComponentT()
		{
			this.Disabled = false;
			this.PickInteractType = null;
			this.NullMask = 0;
		}
	}
}
