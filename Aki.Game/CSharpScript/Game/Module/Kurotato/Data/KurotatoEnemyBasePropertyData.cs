using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200476D RID: 18285
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyBasePropertyData
	{
		// Token: 0x17005C43 RID: 23619
		// (get) Token: 0x0602DE8C RID: 188044 RVA: 0x00CD9E9B File Offset: 0x00CD809B
		// (set) Token: 0x0602DE8D RID: 188045 RVA: 0x00CD9EA3 File Offset: 0x00CD80A3
		public string IconPath { get; set; } = "";

		// Token: 0x17005C44 RID: 23620
		// (get) Token: 0x0602DE8E RID: 188046 RVA: 0x00CD9EAC File Offset: 0x00CD80AC
		// (set) Token: 0x0602DE8F RID: 188047 RVA: 0x00CD9EB4 File Offset: 0x00CD80B4
		public string Name { get; set; } = "";

		// Token: 0x17005C45 RID: 23621
		// (get) Token: 0x0602DE90 RID: 188048 RVA: 0x00CD9EBD File Offset: 0x00CD80BD
		// (set) Token: 0x0602DE91 RID: 188049 RVA: 0x00CD9EC5 File Offset: 0x00CD80C5
		public int Value { get; set; }

		// Token: 0x0602DE92 RID: 188050 RVA: 0x00CD9ED0 File Offset: 0x00CD80D0
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
