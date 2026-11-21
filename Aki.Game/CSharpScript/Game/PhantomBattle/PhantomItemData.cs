using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.PhantomBattle
{
	// Token: 0x0200352C RID: 13612
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomItemData : IPhantomItemData
	{
		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x06022A57 RID: 141911 RVA: 0x009DC09C File Offset: 0x009DA29C
		// (set) Token: 0x06022A58 RID: 141912 RVA: 0x009DC0A4 File Offset: 0x009DA2A4
		public bool IsPhantomData { get; set; }

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x06022A59 RID: 141913 RVA: 0x009DC0AD File Offset: 0x009DA2AD
		// (set) Token: 0x06022A5A RID: 141914 RVA: 0x009DC0B5 File Offset: 0x009DA2B5
		public int Id { get; set; }

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x06022A5B RID: 141915 RVA: 0x009DC0BE File Offset: 0x009DA2BE
		// (set) Token: 0x06022A5C RID: 141916 RVA: 0x009DC0C6 File Offset: 0x009DA2C6
		public int Quality { get; set; }

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x06022A5D RID: 141917 RVA: 0x009DC0CF File Offset: 0x009DA2CF
		// (set) Token: 0x06022A5E RID: 141918 RVA: 0x009DC0D7 File Offset: 0x009DA2D7
		public bool IsEquip { get; set; }

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x06022A5F RID: 141919 RVA: 0x009DC0E0 File Offset: 0x009DA2E0
		// (set) Token: 0x06022A60 RID: 141920 RVA: 0x009DC0E8 File Offset: 0x009DA2E8
		public int Role { get; set; }

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x06022A61 RID: 141921 RVA: 0x009DC0F1 File Offset: 0x009DA2F1
		// (set) Token: 0x06022A62 RID: 141922 RVA: 0x009DC0F9 File Offset: 0x009DA2F9
		public int Level { get; set; }

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x06022A63 RID: 141923 RVA: 0x009DC102 File Offset: 0x009DA302
		// (set) Token: 0x06022A64 RID: 141924 RVA: 0x009DC10A File Offset: 0x009DA30A
		public bool IsBreach { get; set; }

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x06022A65 RID: 141925 RVA: 0x009DC113 File Offset: 0x009DA313
		// (set) Token: 0x06022A66 RID: 141926 RVA: 0x009DC11B File Offset: 0x009DA31B
		public int MonsterId { get; set; }

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x06022A67 RID: 141927 RVA: 0x009DC124 File Offset: 0x009DA324
		// (set) Token: 0x06022A68 RID: 141928 RVA: 0x009DC12C File Offset: 0x009DA32C
		public List<PhantomSortStruct> MainPropMap { get; set; }

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x06022A69 RID: 141929 RVA: 0x009DC135 File Offset: 0x009DA335
		// (set) Token: 0x06022A6A RID: 141930 RVA: 0x009DC13D File Offset: 0x009DA33D
		public List<PhantomSortStruct> SubPropMap { get; set; }

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x06022A6B RID: 141931 RVA: 0x009DC146 File Offset: 0x009DA346
		// (set) Token: 0x06022A6C RID: 141932 RVA: 0x009DC14E File Offset: 0x009DA34E
		public bool IsLock { get; set; }

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x06022A6D RID: 141933 RVA: 0x009DC157 File Offset: 0x009DA357
		// (set) Token: 0x06022A6E RID: 141934 RVA: 0x009DC15F File Offset: 0x009DA35F
		public bool IsDeprecate { get; set; }

		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x06022A6F RID: 141935 RVA: 0x009DC168 File Offset: 0x009DA368
		// (set) Token: 0x06022A70 RID: 141936 RVA: 0x009DC170 File Offset: 0x009DA370
		public int ConfigId { get; set; }

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x06022A71 RID: 141937 RVA: 0x009DC179 File Offset: 0x009DA379
		// (set) Token: 0x06022A72 RID: 141938 RVA: 0x009DC181 File Offset: 0x009DA381
		public int Rarity { get; set; }
	}
}
