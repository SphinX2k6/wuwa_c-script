using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD1 RID: 23505
	public class IWuWaGoPullRodT
	{
		// Token: 0x1700B19D RID: 45469
		// (get) Token: 0x06028465 RID: 164965 RVA: 0x00588A3F File Offset: 0x00586C3F
		// (set) Token: 0x06028466 RID: 164966 RVA: 0x00588A47 File Offset: 0x00586C47
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B19E RID: 45470
		// (get) Token: 0x06028467 RID: 164967 RVA: 0x00588A50 File Offset: 0x00586C50
		// (set) Token: 0x06028468 RID: 164968 RVA: 0x00588A58 File Offset: 0x00586C58
		public List<IWuWaGoInteractStateActionT> InteractConfig { get; set; }

		// Token: 0x06028469 RID: 164969 RVA: 0x00588A61 File Offset: 0x00586C61
		public IWuWaGoPullRodT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.InteractConfig = null;
		}
	}
}
