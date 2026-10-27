using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B2E RID: 19246
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomSkillItemData : ITowerDefensePhantomSkillItemData
	{
		// Token: 0x17007B61 RID: 31585
		// (get) Token: 0x06031D7C RID: 204156 RVA: 0x00B92663 File Offset: 0x00B90863
		// (set) Token: 0x06031D7D RID: 204157 RVA: 0x00B9266B File Offset: 0x00B9086B
		public string SkillTextId { get; set; }

		// Token: 0x17007B62 RID: 31586
		// (get) Token: 0x06031D7E RID: 204158 RVA: 0x00B92674 File Offset: 0x00B90874
		// (set) Token: 0x06031D7F RID: 204159 RVA: 0x00B9267C File Offset: 0x00B9087C
		public string Level { get; set; }

		// Token: 0x17007B63 RID: 31587
		// (get) Token: 0x06031D80 RID: 204160 RVA: 0x00B92685 File Offset: 0x00B90885
		// (set) Token: 0x06031D81 RID: 204161 RVA: 0x00B9268D File Offset: 0x00B9088D
		public string DescriptionTextId { get; set; }

		// Token: 0x17007B64 RID: 31588
		// (get) Token: 0x06031D82 RID: 204162 RVA: 0x00B92696 File Offset: 0x00B90896
		// (set) Token: 0x06031D83 RID: 204163 RVA: 0x00B9269E File Offset: 0x00B9089E
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
	}
}
