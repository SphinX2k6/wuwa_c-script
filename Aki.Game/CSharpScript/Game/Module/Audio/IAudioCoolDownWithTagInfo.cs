using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E84 RID: 24196
	public interface IAudioCoolDownWithTagInfo : IAudioCoolDownInfo
	{
		// Token: 0x17008E88 RID: 36488
		// (get) Token: 0x0603D8E7 RID: 252135
		// (set) Token: 0x0603D8E8 RID: 252136
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
