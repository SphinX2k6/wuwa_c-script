using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200476E RID: 18286
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyCharacteristicData
	{
		// Token: 0x17005C46 RID: 23622
		// (get) Token: 0x0602DE93 RID: 188051 RVA: 0x00CD9F52 File Offset: 0x00CD8152
		// (set) Token: 0x0602DE94 RID: 188052 RVA: 0x00CD9F5A File Offset: 0x00CD815A
		public int Id { get; set; }

		// Token: 0x17005C47 RID: 23623
		// (get) Token: 0x0602DE95 RID: 188053 RVA: 0x00CD9F63 File Offset: 0x00CD8163
		// (set) Token: 0x0602DE96 RID: 188054 RVA: 0x00CD9F6B File Offset: 0x00CD816B
		public string IconPath { get; set; } = "";

		// Token: 0x17005C48 RID: 23624
		// (get) Token: 0x0602DE97 RID: 188055 RVA: 0x00CD9F74 File Offset: 0x00CD8174
		// (set) Token: 0x0602DE98 RID: 188056 RVA: 0x00CD9F7C File Offset: 0x00CD817C
		public string Name { get; set; } = "";

		// Token: 0x17005C49 RID: 23625
		// (get) Token: 0x0602DE99 RID: 188057 RVA: 0x00CD9F85 File Offset: 0x00CD8185
		// (set) Token: 0x0602DE9A RID: 188058 RVA: 0x00CD9F8D File Offset: 0x00CD818D
		public string Desc { get; set; } = "";

		// Token: 0x0602DE9B RID: 188059 RVA: 0x00CD9F98 File Offset: 0x00CD8198
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
