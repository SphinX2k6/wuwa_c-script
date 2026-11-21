using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200506E RID: 20590
	public static class RoverlikeFloatTextKeyMap
	{
		// Token: 0x060338DB RID: 211163 RVA: 0x00E6FB6C File Offset: 0x00E6DD6C
		// Note: this type is marked as 'beforefieldinit'.
		static RoverlikeFloatTextKeyMap()
		{
			Dictionary<ERoverlikeFloatTextType, RoverlikeFloatTextKeyPair> dictionary = new Dictionary<ERoverlikeFloatTextType, RoverlikeFloatTextKeyPair>();
			dictionary[ERoverlikeFloatTextType.HpMax] = new RoverlikeFloatTextKeyPair
			{
				Increment = "RoverRogue_EffectHintHpMaxGet",
				Decrements = "RoverRogue_EffectHintHpMaxLose"
			};
			dictionary[ERoverlikeFloatTextType.Coin] = new RoverlikeFloatTextKeyPair
			{
				Increment = "RoverRogue_EffectHintGoldGet",
				Decrements = "RoverRogue_EffectHintGoldLose"
			};
			dictionary[ERoverlikeFloatTextType.TalentPoint] = new RoverlikeFloatTextKeyPair
			{
				Increment = "RoverRogue_EffectHintTalentPointGet",
				Decrements = "RoverRogue_EffectHintTalentPointGet"
			};
			dictionary[ERoverlikeFloatTextType.GoldEfficiency] = new RoverlikeFloatTextKeyPair
			{
				Increment = "RoverRogue_EffectHintGoldEfficiencyGet",
				Decrements = "RoverRogue_EffectHintGoldEfficiencyLose"
			};
			dictionary[ERoverlikeFloatTextType.ItemRound] = new RoverlikeFloatTextKeyPair
			{
				Increment = "RoverRogue_EffectHintItemDurationGet",
				Decrements = "RoverRogue_EffectHintItemDurationLose"
			};
			dictionary[ERoverlikeFloatTextType.Attr] = new RoverlikeFloatTextKeyPair
			{
				Increment = "RoverRogue_EventGetAttribute",
				Decrements = "RoverRogue_EventGetAttribute"
			};
			RoverlikeFloatTextKeyMap.Map = dictionary;
		}

		// Token: 0x0401B5E5 RID: 112101
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ERoverlikeFloatTextType, RoverlikeFloatTextKeyPair> Map;
	}
}
