using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B81 RID: 23425
	public class IWindSourceBaseT
	{
		// Token: 0x1700B10B RID: 45323
		// (get) Token: 0x060281A5 RID: 164261 RVA: 0x00583322 File Offset: 0x00581522
		// (set) Token: 0x060281A6 RID: 164262 RVA: 0x0058332A File Offset: 0x0058152A
		public EWindSourceType Type { get; set; }

		// Token: 0x060281A7 RID: 164263 RVA: 0x00583333 File Offset: 0x00581533
		public IWindSourceBaseT()
		{
			this.Type = EWindSourceType.Directional;
		}
	}
}
