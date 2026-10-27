using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E11 RID: 19985
	public class RoguelikeMemoryRewardItemData
	{
		// Token: 0x0401B58B RID: 112011
		[Nullable(2)]
		public SeasonReward SeasonReward;

		// Token: 0x0401B58C RID: 112012
		public Aki.Config.RogueSeasonReward? Config;
	}
}
