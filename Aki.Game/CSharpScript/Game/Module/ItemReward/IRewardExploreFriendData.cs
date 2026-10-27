using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D4 RID: 22484
	[NullableContext(1)]
	public interface IRewardExploreFriendData
	{
		// Token: 0x170089CC RID: 35276
		// (get) Token: 0x060392A6 RID: 234150
		// (set) Token: 0x060392A7 RID: 234151
		string PlayerDesc { get; set; }

		// Token: 0x170089CD RID: 35277
		// (get) Token: 0x060392A8 RID: 234152
		// (set) Token: 0x060392A9 RID: 234153
		string PlayerName { get; set; }

		// Token: 0x170089CE RID: 35278
		// (get) Token: 0x060392AA RID: 234154
		// (set) Token: 0x060392AB RID: 234155
		string PlayerIndexPath { get; set; }

		// Token: 0x170089CF RID: 35279
		// (get) Token: 0x060392AC RID: 234156
		// (set) Token: 0x060392AD RID: 234157
		string PlayerIconPath { get; set; }

		// Token: 0x170089D0 RID: 35280
		// (get) Token: 0x060392AE RID: 234158
		// (set) Token: 0x060392AF RID: 234159
		int PlayerId { get; set; }

		// Token: 0x170089D1 RID: 35281
		// (get) Token: 0x060392B0 RID: 234160
		// (set) Token: 0x060392B1 RID: 234161
		int PlayerLevel { get; set; }

		// Token: 0x170089D2 RID: 35282
		// (get) Token: 0x060392B2 RID: 234162
		// (set) Token: 0x060392B3 RID: 234163
		bool IsMyFriend { get; set; }

		// Token: 0x170089D3 RID: 35283
		// (get) Token: 0x060392B4 RID: 234164
		// (set) Token: 0x060392B5 RID: 234165
		Action<int> OnClickCallback { get; set; }
	}
}
