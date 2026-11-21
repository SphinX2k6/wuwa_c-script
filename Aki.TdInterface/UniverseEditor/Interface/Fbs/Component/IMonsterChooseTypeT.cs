using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFC RID: 23292
	public class IMonsterChooseTypeT
	{
		// Token: 0x1700AA03 RID: 43523
		// (get) Token: 0x06026472 RID: 156786 RVA: 0x0053E9BE File Offset: 0x0053CBBE
		// (set) Token: 0x06026473 RID: 156787 RVA: 0x0053E9C6 File Offset: 0x0053CBC6
		public EMonsterChooseType Type { get; set; }

		// Token: 0x06026474 RID: 156788 RVA: 0x0053E9CF File Offset: 0x0053CBCF
		public IMonsterChooseTypeT()
		{
			this.Type = EMonsterChooseType.RandomPoolChoose;
		}
	}
}
