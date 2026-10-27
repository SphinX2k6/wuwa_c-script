using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vision;

// Token: 0x020031A4 RID: 12708
public static class visionTypes
{
	// Token: 0x0400D682 RID: 54914
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		1
	})]
	[StaticVariableRuleIgnore]
	public static readonly ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>[] Value = new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>[]
	{
		new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>(EVisionType.召唤, (CharacterVisionComponent Comp) => new GameplayAbilityVisionSummon(Comp)),
		new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>(EVisionType.变身, (CharacterVisionComponent Comp) => new GameplayAbilityVisionMorph(Comp)),
		new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>(EVisionType.探索, (CharacterVisionComponent Comp) => new GameplayAbilityVisionShow(Comp)),
		new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>(EVisionType.操控, (CharacterVisionComponent Comp) => new GameplayAbilityVisionControl(Comp)),
		new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>(EVisionType.驻场, (CharacterVisionComponent Comp) => new GameplayAbilityVisionPresent(Comp)),
		new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>(EVisionType.BossRush, (CharacterVisionComponent Comp) => new GameplayAbilityVisionBossRush(Comp)),
		new ValueTuple<EVisionType, Func<CharacterVisionComponent, GameplayAbilityVisionBase>>(EVisionType.新探索, (CharacterVisionComponent Comp) => new GameplayAbilityVisionShowNew(Comp))
	};
}
