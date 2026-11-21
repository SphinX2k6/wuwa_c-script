using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD5 RID: 15061
	[NullableContext(1)]
	public interface ITowerDefensePhantomSkillItemData
	{
		// Token: 0x17004F0A RID: 20234
		// (get) Token: 0x06026B04 RID: 158468
		// (set) Token: 0x06026B05 RID: 158469
		string SkillTextId { get; set; }

		// Token: 0x17004F0B RID: 20235
		// (get) Token: 0x06026B06 RID: 158470
		// (set) Token: 0x06026B07 RID: 158471
		string Level { get; set; }

		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x06026B08 RID: 158472
		// (set) Token: 0x06026B09 RID: 158473
		string DescriptionTextId { get; set; }

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x06026B0A RID: 158474
		// (set) Token: 0x06026B0B RID: 158475
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
