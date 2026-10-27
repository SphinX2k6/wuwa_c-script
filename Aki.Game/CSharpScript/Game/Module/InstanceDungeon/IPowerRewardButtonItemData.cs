using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200588A RID: 22666
	[NullableContext(1)]
	public interface IPowerRewardButtonItemData
	{
		// Token: 0x17008A83 RID: 35459
		// (get) Token: 0x06039AEA RID: 236266
		// (set) Token: 0x06039AEB RID: 236267
		int PowerNum { get; set; }

		// Token: 0x17008A84 RID: 35460
		// (get) Token: 0x06039AEC RID: 236268
		// (set) Token: 0x06039AED RID: 236269
		string RewardTextId { get; set; }

		// Token: 0x17008A85 RID: 35461
		// (get) Token: 0x06039AEE RID: 236270
		// (set) Token: 0x06039AEF RID: 236271
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

		// Token: 0x17008A86 RID: 35462
		// (get) Token: 0x06039AF0 RID: 236272
		// (set) Token: 0x06039AF1 RID: 236273
		Action RewardCallBack { get; set; }
	}
}
