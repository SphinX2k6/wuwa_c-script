using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02005797 RID: 22423
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyCharacteristicData
	{
		// Token: 0x1700887E RID: 34942
		// (get) Token: 0x06038F83 RID: 233347 RVA: 0x00D8B1D6 File Offset: 0x00D893D6
		// (set) Token: 0x06038F84 RID: 233348 RVA: 0x00D8B1DE File Offset: 0x00D893DE
		public int Id { get; set; }

		// Token: 0x1700887F RID: 34943
		// (get) Token: 0x06038F85 RID: 233349 RVA: 0x00D8B1E7 File Offset: 0x00D893E7
		// (set) Token: 0x06038F86 RID: 233350 RVA: 0x00D8B1EF File Offset: 0x00D893EF
		public string IconPath { get; set; } = "";

		// Token: 0x17008880 RID: 34944
		// (get) Token: 0x06038F87 RID: 233351 RVA: 0x00D8B1F8 File Offset: 0x00D893F8
		// (set) Token: 0x06038F88 RID: 233352 RVA: 0x00D8B200 File Offset: 0x00D89400
		public string Name { get; set; } = "";

		// Token: 0x17008881 RID: 34945
		// (get) Token: 0x06038F89 RID: 233353 RVA: 0x00D8B209 File Offset: 0x00D89409
		// (set) Token: 0x06038F8A RID: 233354 RVA: 0x00D8B211 File Offset: 0x00D89411
		public string Desc { get; set; } = "";

		// Token: 0x06038F8B RID: 233355 RVA: 0x00D8B21C File Offset: 0x00D8941C
		public KurotatoEnemyCharacteristicData(int id)
		{
			this.Id = id;
			KurotatoMonsterTag? monsterTagById = KurotatoConfig.Instance.GetMonsterTagById(id);
			if (monsterTagById == null)
			{
				return;
			}
			this.IconPath = monsterTagById.Value.Icon;
			this.Name = monsterTagById.Value.Name;
			this.Desc = monsterTagById.Value.Desc;
		}
	}
}
