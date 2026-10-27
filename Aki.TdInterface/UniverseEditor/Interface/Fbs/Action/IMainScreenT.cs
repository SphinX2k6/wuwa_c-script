using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A69 RID: 27241
	public class IMainScreenT
	{
		// Token: 0x1700CA1D RID: 51741
		// (get) Token: 0x0602FB60 RID: 195424 RVA: 0x0067E30E File Offset: 0x0067C50E
		// (set) Token: 0x0602FB61 RID: 195425 RVA: 0x0067E316 File Offset: 0x0067C516
		public EScreenType Type { get; set; }

		// Token: 0x0602FB62 RID: 195426 RVA: 0x0067E31F File Offset: 0x0067C51F
		public IMainScreenT()
		{
			this.Type = EScreenType.Main;
		}
	}
}
