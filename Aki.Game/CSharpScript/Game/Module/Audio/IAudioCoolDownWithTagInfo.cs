using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E69 RID: 20073
	public interface IAudioCoolDownWithTagInfo : IAudioCoolDownInfo
	{
		// Token: 0x1700625A RID: 25178
		// (get) Token: 0x06032877 RID: 206967
		// (set) Token: 0x06032878 RID: 206968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		TArray<SGameplayTagProbabilityCooldownInfo> TagProbability { [return: Nullable(new byte[]
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
