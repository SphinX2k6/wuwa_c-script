using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004862 RID: 18530
	[NullableContext(1)]
	public interface IPowerRewardButtonItemData
	{
		// Token: 0x17005E4F RID: 24143
		// (get) Token: 0x0602EA0D RID: 190989
		// (set) Token: 0x0602EA0E RID: 190990
		int PowerNum { get; set; }

		// Token: 0x17005E50 RID: 24144
		// (get) Token: 0x0602EA0F RID: 190991
		// (set) Token: 0x0602EA10 RID: 190992
		string RewardTextId { get; set; }

		// Token: 0x17005E51 RID: 24145
		// (get) Token: 0x0602EA11 RID: 190993
		// (set) Token: 0x0602EA12 RID: 190994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] RewardTextArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005E52 RID: 24146
		// (get) Token: 0x0602EA13 RID: 190995
		// (set) Token: 0x0602EA14 RID: 190996
		Action RewardCallBack { get; set; }
	}
}
