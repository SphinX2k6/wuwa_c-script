using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B2D RID: 19245
	[NullableContext(1)]
	public interface ITowerDefensePhantomSkillItemData
	{
		// Token: 0x17007B5D RID: 31581
		// (get) Token: 0x06031D74 RID: 204148
		// (set) Token: 0x06031D75 RID: 204149
		string SkillTextId { get; set; }

		// Token: 0x17007B5E RID: 31582
		// (get) Token: 0x06031D76 RID: 204150
		// (set) Token: 0x06031D77 RID: 204151
		string Level { get; set; }

		// Token: 0x17007B5F RID: 31583
		// (get) Token: 0x06031D78 RID: 204152
		// (set) Token: 0x06031D79 RID: 204153
		string DescriptionTextId { get; set; }

		// Token: 0x17007B60 RID: 31584
		// (get) Token: 0x06031D7A RID: 204154
		// (set) Token: 0x06031D7B RID: 204155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<string> DescriptionArgs { [return: Nullable(new byte[]
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
