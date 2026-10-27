using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B2F RID: 19247
	[NullableContext(1)]
	public interface ITowerDefensePhantomSkillItemInBattleData
	{
		// Token: 0x17007B65 RID: 31589
		// (get) Token: 0x06031D85 RID: 204165
		// (set) Token: 0x06031D86 RID: 204166
		string Skill { get; set; }

		// Token: 0x17007B66 RID: 31590
		// (get) Token: 0x06031D87 RID: 204167
		// (set) Token: 0x06031D88 RID: 204168
		string Description { get; set; }

		// Token: 0x17007B67 RID: 31591
		// (get) Token: 0x06031D89 RID: 204169
		// (set) Token: 0x06031D8A RID: 204170
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

		// Token: 0x17007B68 RID: 31592
		// (get) Token: 0x06031D8B RID: 204171
		// (set) Token: 0x06031D8C RID: 204172
		bool IsUnlock { get; set; }

		// Token: 0x17007B69 RID: 31593
		// (get) Token: 0x06031D8D RID: 204173
		// (set) Token: 0x06031D8E RID: 204174
		bool IsCurrent { get; set; }
	}
}
