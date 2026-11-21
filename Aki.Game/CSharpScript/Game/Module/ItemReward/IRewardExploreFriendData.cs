using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047AB RID: 18347
	[NullableContext(1)]
	public interface IRewardExploreFriendData
	{
		// Token: 0x17005D96 RID: 23958
		// (get) Token: 0x0602E1BA RID: 188858
		// (set) Token: 0x0602E1BB RID: 188859
		string PlayerDesc { get; set; }

		// Token: 0x17005D97 RID: 23959
		// (get) Token: 0x0602E1BC RID: 188860
		// (set) Token: 0x0602E1BD RID: 188861
		string PlayerName { get; set; }

		// Token: 0x17005D98 RID: 23960
		// (get) Token: 0x0602E1BE RID: 188862
		// (set) Token: 0x0602E1BF RID: 188863
		string PlayerIndexPath { get; set; }

		// Token: 0x17005D99 RID: 23961
		// (get) Token: 0x0602E1C0 RID: 188864
		// (set) Token: 0x0602E1C1 RID: 188865
		string PlayerIconPath { get; set; }

		// Token: 0x17005D9A RID: 23962
		// (get) Token: 0x0602E1C2 RID: 188866
		// (set) Token: 0x0602E1C3 RID: 188867
		int PlayerId { get; set; }

		// Token: 0x17005D9B RID: 23963
		// (get) Token: 0x0602E1C4 RID: 188868
		// (set) Token: 0x0602E1C5 RID: 188869
		int PlayerLevel { get; set; }

		// Token: 0x17005D9C RID: 23964
		// (get) Token: 0x0602E1C6 RID: 188870
		// (set) Token: 0x0602E1C7 RID: 188871
		bool IsMyFriend { get; set; }

		// Token: 0x17005D9D RID: 23965
		// (get) Token: 0x0602E1C8 RID: 188872
		// (set) Token: 0x0602E1C9 RID: 188873
		Action<int> OnClickCallback { get; set; }
	}
}
