using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E28 RID: 24104
	public class IOutAreaBorderTypeT
	{
		// Token: 0x1700B451 RID: 46161
		// (get) Token: 0x0602944A RID: 169034 RVA: 0x005A8EE6 File Offset: 0x005A70E6
		// (set) Token: 0x0602944B RID: 169035 RVA: 0x005A8EEE File Offset: 0x005A70EE
		public EOutAreaBorderType Type { get; set; }

		// Token: 0x0602944C RID: 169036 RVA: 0x005A8EF7 File Offset: 0x005A70F7
		public IOutAreaBorderTypeT()
		{
			this.Type = EOutAreaBorderType.TeleportTimer;
		}
	}
}
