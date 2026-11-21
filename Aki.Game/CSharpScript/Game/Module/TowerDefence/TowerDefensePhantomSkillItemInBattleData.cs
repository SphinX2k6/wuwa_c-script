using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD8 RID: 15064
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomSkillItemInBattleData : ITowerDefensePhantomSkillItemInBattleData
	{
		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x06026B1F RID: 158495 RVA: 0x00AD6713 File Offset: 0x00AD4913
		// (set) Token: 0x06026B20 RID: 158496 RVA: 0x00AD671B File Offset: 0x00AD491B
		public string Skill { get; set; }

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x06026B21 RID: 158497 RVA: 0x00AD6724 File Offset: 0x00AD4924
		// (set) Token: 0x06026B22 RID: 158498 RVA: 0x00AD672C File Offset: 0x00AD492C
		public string Description { get; set; }

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x06026B23 RID: 158499 RVA: 0x00AD6735 File Offset: 0x00AD4935
		// (set) Token: 0x06026B24 RID: 158500 RVA: 0x00AD673D File Offset: 0x00AD493D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> DescriptionArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x06026B25 RID: 158501 RVA: 0x00AD6746 File Offset: 0x00AD4946
		// (set) Token: 0x06026B26 RID: 158502 RVA: 0x00AD674E File Offset: 0x00AD494E
		public bool IsUnlock { get; set; }

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x06026B27 RID: 158503 RVA: 0x00AD6757 File Offset: 0x00AD4957
		// (set) Token: 0x06026B28 RID: 158504 RVA: 0x00AD675F File Offset: 0x00AD495F
		public bool IsCurrent { get; set; }
	}
}
