using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02005796 RID: 22422
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyBasePropertyData
	{
		// Token: 0x1700887B RID: 34939
		// (get) Token: 0x06038F7C RID: 233340 RVA: 0x00D8B11F File Offset: 0x00D8931F
		// (set) Token: 0x06038F7D RID: 233341 RVA: 0x00D8B127 File Offset: 0x00D89327
		public string IconPath { get; set; } = "";

		// Token: 0x1700887C RID: 34940
		// (get) Token: 0x06038F7E RID: 233342 RVA: 0x00D8B130 File Offset: 0x00D89330
		// (set) Token: 0x06038F7F RID: 233343 RVA: 0x00D8B138 File Offset: 0x00D89338
		public string Name { get; set; } = "";

		// Token: 0x1700887D RID: 34941
		// (get) Token: 0x06038F80 RID: 233344 RVA: 0x00D8B141 File Offset: 0x00D89341
		// (set) Token: 0x06038F81 RID: 233345 RVA: 0x00D8B149 File Offset: 0x00D89349
		public int Value { get; set; }

		// Token: 0x06038F82 RID: 233346 RVA: 0x00D8B154 File Offset: 0x00D89354
		public KurotatoEnemyBasePropertyData(EKurotatoEnemyAttrType attrType, int value)
		{
			KurotatoMonsterAttribute? monsterAttribute = KurotatoConfig.Instance.GetMonsterAttribute((int)attrType);
			if (monsterAttribute == null)
			{
				return;
			}
			this.IconPath = (monsterAttribute.Value.Icon ?? "");
			this.Name = (monsterAttribute.Value.Name ?? "");
			this.Value = value;
		}
	}
}
