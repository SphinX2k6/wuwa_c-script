using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B38 RID: 19256
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomConfig : ITowerDefensePhantomConfig
	{
		// Token: 0x17007B94 RID: 31636
		// (get) Token: 0x06031DE7 RID: 204263 RVA: 0x00B92812 File Offset: 0x00B90A12
		// (set) Token: 0x06031DE8 RID: 204264 RVA: 0x00B9281A File Offset: 0x00B90A1A
		public int Id { get; set; }

		// Token: 0x17007B95 RID: 31637
		// (get) Token: 0x06031DE9 RID: 204265 RVA: 0x00B92823 File Offset: 0x00B90A23
		// (set) Token: 0x06031DEA RID: 204266 RVA: 0x00B9282B File Offset: 0x00B90A2B
		public int PhantomItemId { get; set; }

		// Token: 0x17007B96 RID: 31638
		// (get) Token: 0x06031DEB RID: 204267 RVA: 0x00B92834 File Offset: 0x00B90A34
		// (set) Token: 0x06031DEC RID: 204268 RVA: 0x00B9283C File Offset: 0x00B90A3C
		public int ActivityId { get; set; }

		// Token: 0x17007B97 RID: 31639
		// (get) Token: 0x06031DED RID: 204269 RVA: 0x00B92845 File Offset: 0x00B90A45
		// (set) Token: 0x06031DEE RID: 204270 RVA: 0x00B9284D File Offset: 0x00B90A4D
		public string PhantomNameTextId { get; set; }

		// Token: 0x17007B98 RID: 31640
		// (get) Token: 0x06031DEF RID: 204271 RVA: 0x00B92856 File Offset: 0x00B90A56
		// (set) Token: 0x06031DF0 RID: 204272 RVA: 0x00B9285E File Offset: 0x00B90A5E
		public string PhantomTypeTextId { get; set; }

		// Token: 0x17007B99 RID: 31641
		// (get) Token: 0x06031DF1 RID: 204273 RVA: 0x00B92867 File Offset: 0x00B90A67
		// (set) Token: 0x06031DF2 RID: 204274 RVA: 0x00B9286F File Offset: 0x00B90A6F
		public string TypeIconPath { get; set; }

		// Token: 0x17007B9A RID: 31642
		// (get) Token: 0x06031DF3 RID: 204275 RVA: 0x00B92878 File Offset: 0x00B90A78
		// (set) Token: 0x06031DF4 RID: 204276 RVA: 0x00B92880 File Offset: 0x00B90A80
		public string MarkResourceId { get; set; }

		// Token: 0x17007B9B RID: 31643
		// (get) Token: 0x06031DF5 RID: 204277 RVA: 0x00B92889 File Offset: 0x00B90A89
		// (set) Token: 0x06031DF6 RID: 204278 RVA: 0x00B92891 File Offset: 0x00B90A91
		public int MaxLevel { get; set; }

		// Token: 0x17007B9C RID: 31644
		// (get) Token: 0x06031DF7 RID: 204279 RVA: 0x00B9289A File Offset: 0x00B90A9A
		// (set) Token: 0x06031DF8 RID: 204280 RVA: 0x00B928A2 File Offset: 0x00B90AA2
		public List<ITowerDefensePhantomConfigSkillData> SkillDataList { get; set; }
	}
}
