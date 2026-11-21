using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AEE RID: 15086
	[NullableContext(1)]
	public interface ITowerDefenseLockedHint
	{
		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x06026C01 RID: 158721
		// (set) Token: 0x06026C02 RID: 158722
		string TextId { get; set; }

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x06026C03 RID: 158723
		// (set) Token: 0x06026C04 RID: 158724
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] Args { [return: Nullable(new byte[]
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
