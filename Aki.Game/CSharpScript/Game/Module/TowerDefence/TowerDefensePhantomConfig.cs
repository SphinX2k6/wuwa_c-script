using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE0 RID: 15072
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomConfig : ITowerDefensePhantomConfig
	{
		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x06026B77 RID: 158583 RVA: 0x00AD6876 File Offset: 0x00AD4A76
		// (set) Token: 0x06026B78 RID: 158584 RVA: 0x00AD687E File Offset: 0x00AD4A7E
		public int Id { get; set; }

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x06026B79 RID: 158585 RVA: 0x00AD6887 File Offset: 0x00AD4A87
		// (set) Token: 0x06026B7A RID: 158586 RVA: 0x00AD688F File Offset: 0x00AD4A8F
		public int PhantomItemId { get; set; }

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x06026B7B RID: 158587 RVA: 0x00AD6898 File Offset: 0x00AD4A98
		// (set) Token: 0x06026B7C RID: 158588 RVA: 0x00AD68A0 File Offset: 0x00AD4AA0
		public int ActivityId { get; set; }

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x06026B7D RID: 158589 RVA: 0x00AD68A9 File Offset: 0x00AD4AA9
		// (set) Token: 0x06026B7E RID: 158590 RVA: 0x00AD68B1 File Offset: 0x00AD4AB1
		public string PhantomNameTextId { get; set; }

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x06026B7F RID: 158591 RVA: 0x00AD68BA File Offset: 0x00AD4ABA
		// (set) Token: 0x06026B80 RID: 158592 RVA: 0x00AD68C2 File Offset: 0x00AD4AC2
		public string PhantomTypeTextId { get; set; }

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x06026B81 RID: 158593 RVA: 0x00AD68CB File Offset: 0x00AD4ACB
		// (set) Token: 0x06026B82 RID: 158594 RVA: 0x00AD68D3 File Offset: 0x00AD4AD3
		public string TypeIconPath { get; set; }

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x06026B83 RID: 158595 RVA: 0x00AD68DC File Offset: 0x00AD4ADC
		// (set) Token: 0x06026B84 RID: 158596 RVA: 0x00AD68E4 File Offset: 0x00AD4AE4
		public string MarkResourceId { get; set; }

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x06026B85 RID: 158597 RVA: 0x00AD68ED File Offset: 0x00AD4AED
		// (set) Token: 0x06026B86 RID: 158598 RVA: 0x00AD68F5 File Offset: 0x00AD4AF5
		public int MaxLevel { get; set; }

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x06026B87 RID: 158599 RVA: 0x00AD68FE File Offset: 0x00AD4AFE
		// (set) Token: 0x06026B88 RID: 158600 RVA: 0x00AD6906 File Offset: 0x00AD4B06
		public List<ITowerDefensePhantomConfigSkillData> SkillDataList { get; set; }
	}
}
