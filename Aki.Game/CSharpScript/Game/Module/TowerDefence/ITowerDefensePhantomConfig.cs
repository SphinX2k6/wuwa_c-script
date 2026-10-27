using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B37 RID: 19255
	[NullableContext(1)]
	public interface ITowerDefensePhantomConfig
	{
		// Token: 0x17007B8B RID: 31627
		// (get) Token: 0x06031DD5 RID: 204245
		// (set) Token: 0x06031DD6 RID: 204246
		int Id { get; set; }

		// Token: 0x17007B8C RID: 31628
		// (get) Token: 0x06031DD7 RID: 204247
		// (set) Token: 0x06031DD8 RID: 204248
		int PhantomItemId { get; set; }

		// Token: 0x17007B8D RID: 31629
		// (get) Token: 0x06031DD9 RID: 204249
		// (set) Token: 0x06031DDA RID: 204250
		int ActivityId { get; set; }

		// Token: 0x17007B8E RID: 31630
		// (get) Token: 0x06031DDB RID: 204251
		// (set) Token: 0x06031DDC RID: 204252
		string PhantomNameTextId { get; set; }

		// Token: 0x17007B8F RID: 31631
		// (get) Token: 0x06031DDD RID: 204253
		// (set) Token: 0x06031DDE RID: 204254
		string PhantomTypeTextId { get; set; }

		// Token: 0x17007B90 RID: 31632
		// (get) Token: 0x06031DDF RID: 204255
		// (set) Token: 0x06031DE0 RID: 204256
		string TypeIconPath { get; set; }

		// Token: 0x17007B91 RID: 31633
		// (get) Token: 0x06031DE1 RID: 204257
		// (set) Token: 0x06031DE2 RID: 204258
		string MarkResourceId { get; set; }

		// Token: 0x17007B92 RID: 31634
		// (get) Token: 0x06031DE3 RID: 204259
		// (set) Token: 0x06031DE4 RID: 204260
		int MaxLevel { get; set; }

		// Token: 0x17007B93 RID: 31635
		// (get) Token: 0x06031DE5 RID: 204261
		// (set) Token: 0x06031DE6 RID: 204262
		List<ITowerDefensePhantomConfigSkillData> SkillDataList { get; set; }
	}
}
