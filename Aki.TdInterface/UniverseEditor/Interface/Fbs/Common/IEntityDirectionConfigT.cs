using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DAA RID: 23978
	public class IEntityDirectionConfigT
	{
		// Token: 0x1700B395 RID: 45973
		// (get) Token: 0x060290B0 RID: 168112 RVA: 0x005A2C77 File Offset: 0x005A0E77
		// (set) Token: 0x060290B1 RID: 168113 RVA: 0x005A2C7F File Offset: 0x005A0E7F
		public int LevelId { get; set; }

		// Token: 0x1700B396 RID: 45974
		// (get) Token: 0x060290B2 RID: 168114 RVA: 0x005A2C88 File Offset: 0x005A0E88
		// (set) Token: 0x060290B3 RID: 168115 RVA: 0x005A2C90 File Offset: 0x005A0E90
		public List<IEntityDirectionT> EntityDirectionConfig { get; set; }

		// Token: 0x060290B4 RID: 168116 RVA: 0x005A2C99 File Offset: 0x005A0E99
		public IEntityDirectionConfigT()
		{
			this.LevelId = 0;
			this.EntityDirectionConfig = null;
		}
	}
}
