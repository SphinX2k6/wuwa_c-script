using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE3 RID: 15075
	[NullableContext(1)]
	public interface ITowerDefenseTipsContentInBattle
	{
		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x06026BAB RID: 158635
		// (set) Token: 0x06026BAC RID: 158636
		string TitleTextId { get; set; }

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x06026BAD RID: 158637
		// (set) Token: 0x06026BAE RID: 158638
		string PhantomTextId { get; set; }

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x06026BAF RID: 158639
		// (set) Token: 0x06026BB0 RID: 158640
		int Level { get; set; }

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x06026BB1 RID: 158641
		// (set) Token: 0x06026BB2 RID: 158642
		string DescTextId { get; set; }

		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x06026BB3 RID: 158643
		// (set) Token: 0x06026BB4 RID: 158644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<string> DescArgs { [return: Nullable(new byte[]
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
