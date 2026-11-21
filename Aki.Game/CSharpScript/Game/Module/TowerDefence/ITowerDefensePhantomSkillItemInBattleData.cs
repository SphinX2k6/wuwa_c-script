using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD7 RID: 15063
	[NullableContext(1)]
	public interface ITowerDefensePhantomSkillItemInBattleData
	{
		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x06026B15 RID: 158485
		// (set) Token: 0x06026B16 RID: 158486
		string Skill { get; set; }

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x06026B17 RID: 158487
		// (set) Token: 0x06026B18 RID: 158488
		string Description { get; set; }

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x06026B19 RID: 158489
		// (set) Token: 0x06026B1A RID: 158490
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

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x06026B1B RID: 158491
		// (set) Token: 0x06026B1C RID: 158492
		bool IsUnlock { get; set; }

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x06026B1D RID: 158493
		// (set) Token: 0x06026B1E RID: 158494
		bool IsCurrent { get; set; }
	}
}
