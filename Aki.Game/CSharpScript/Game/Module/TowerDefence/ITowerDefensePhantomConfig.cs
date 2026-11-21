using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ADF RID: 15071
	[NullableContext(1)]
	public interface ITowerDefensePhantomConfig
	{
		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x06026B65 RID: 158565
		// (set) Token: 0x06026B66 RID: 158566
		int Id { get; set; }

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x06026B67 RID: 158567
		// (set) Token: 0x06026B68 RID: 158568
		int PhantomItemId { get; set; }

		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x06026B69 RID: 158569
		// (set) Token: 0x06026B6A RID: 158570
		int ActivityId { get; set; }

		// Token: 0x17004F3B RID: 20283
		// (get) Token: 0x06026B6B RID: 158571
		// (set) Token: 0x06026B6C RID: 158572
		string PhantomNameTextId { get; set; }

		// Token: 0x17004F3C RID: 20284
		// (get) Token: 0x06026B6D RID: 158573
		// (set) Token: 0x06026B6E RID: 158574
		string PhantomTypeTextId { get; set; }

		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x06026B6F RID: 158575
		// (set) Token: 0x06026B70 RID: 158576
		string TypeIconPath { get; set; }

		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x06026B71 RID: 158577
		// (set) Token: 0x06026B72 RID: 158578
		string MarkResourceId { get; set; }

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x06026B73 RID: 158579
		// (set) Token: 0x06026B74 RID: 158580
		int MaxLevel { get; set; }

		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x06026B75 RID: 158581
		// (set) Token: 0x06026B76 RID: 158582
		List<ITowerDefensePhantomConfigSkillData> SkillDataList { get; set; }
	}
}
