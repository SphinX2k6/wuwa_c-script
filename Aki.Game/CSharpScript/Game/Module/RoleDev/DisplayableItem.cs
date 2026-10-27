using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD8 RID: 19672
	[NullableContext(1)]
	[Nullable(0)]
	public class DisplayableItem : IDisplayableItem
	{
		// Token: 0x17007D94 RID: 32148
		// (get) Token: 0x06032C7F RID: 207999 RVA: 0x00BD559A File Offset: 0x00BD379A
		// (set) Token: 0x06032C80 RID: 208000 RVA: 0x00BD55A2 File Offset: 0x00BD37A2
		public string DisplayName { get; set; }

		// Token: 0x17007D95 RID: 32149
		// (get) Token: 0x06032C81 RID: 208001 RVA: 0x00BD55AB File Offset: 0x00BD37AB
		// (set) Token: 0x06032C82 RID: 208002 RVA: 0x00BD55B3 File Offset: 0x00BD37B3
		public string DisplayIcon { get; set; }

		// Token: 0x17007D96 RID: 32150
		// (get) Token: 0x06032C83 RID: 208003 RVA: 0x00BD55BC File Offset: 0x00BD37BC
		// (set) Token: 0x06032C84 RID: 208004 RVA: 0x00BD55C4 File Offset: 0x00BD37C4
		public int? DisplayCount { get; set; }

		// Token: 0x17007D97 RID: 32151
		// (get) Token: 0x06032C85 RID: 208005 RVA: 0x00BD55CD File Offset: 0x00BD37CD
		// (set) Token: 0x06032C86 RID: 208006 RVA: 0x00BD55D5 File Offset: 0x00BD37D5
		public bool IsUnlocked { get; set; }

		// Token: 0x17007D98 RID: 32152
		// (get) Token: 0x06032C87 RID: 208007 RVA: 0x00BD55DE File Offset: 0x00BD37DE
		// (set) Token: 0x06032C88 RID: 208008 RVA: 0x00BD55E6 File Offset: 0x00BD37E6
		public bool IsEquipped { get; set; }

		// Token: 0x17007D99 RID: 32153
		// (get) Token: 0x06032C89 RID: 208009 RVA: 0x00BD55EF File Offset: 0x00BD37EF
		// (set) Token: 0x06032C8A RID: 208010 RVA: 0x00BD55F7 File Offset: 0x00BD37F7
		public int? QualityLevel { get; set; }

		// Token: 0x17007D9A RID: 32154
		// (get) Token: 0x06032C8B RID: 208011 RVA: 0x00BD5600 File Offset: 0x00BD3800
		// (set) Token: 0x06032C8C RID: 208012 RVA: 0x00BD5608 File Offset: 0x00BD3808
		public bool? IsFinished { get; set; }

		// Token: 0x17007D9B RID: 32155
		// (get) Token: 0x06032C8D RID: 208013 RVA: 0x00BD5611 File Offset: 0x00BD3811
		// (set) Token: 0x06032C8E RID: 208014 RVA: 0x00BD5619 File Offset: 0x00BD3819
		public EClickActionType ClickAction { get; set; }

		// Token: 0x17007D9C RID: 32156
		// (get) Token: 0x06032C8F RID: 208015 RVA: 0x00BD5622 File Offset: 0x00BD3822
		// (set) Token: 0x06032C90 RID: 208016 RVA: 0x00BD562A File Offset: 0x00BD382A
		public int? ClickParam { get; set; }
	}
}
