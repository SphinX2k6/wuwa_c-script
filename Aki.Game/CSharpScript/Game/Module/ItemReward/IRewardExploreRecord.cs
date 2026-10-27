using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D0 RID: 22480
	[NullableContext(1)]
	public interface IRewardExploreRecord
	{
		// Token: 0x170089B2 RID: 35250
		// (get) Token: 0x06039270 RID: 234096
		// (set) Token: 0x06039271 RID: 234097
		string TitleTextId { get; set; }

		// Token: 0x170089B3 RID: 35251
		// (get) Token: 0x06039272 RID: 234098
		// (set) Token: 0x06039273 RID: 234099
		string Record { get; set; }

		// Token: 0x170089B4 RID: 35252
		// (get) Token: 0x06039274 RID: 234100
		// (set) Token: 0x06039275 RID: 234101
		int? RecordRollingTo { get; set; }

		// Token: 0x170089B5 RID: 35253
		// (get) Token: 0x06039276 RID: 234102
		// (set) Token: 0x06039277 RID: 234103
		bool IsNewRecord { get; set; }
	}
}
