using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E6B RID: 20075
	public class AudioCoolDownWithTagInfo : AudioCoolDownInfo, IAudioCoolDownWithTagInfo, IAudioCoolDownInfo
	{
		// Token: 0x1700625D RID: 25181
		// (get) Token: 0x0603287E RID: 206974 RVA: 0x00E2C770 File Offset: 0x00E2A970
		// (set) Token: 0x0603287F RID: 206975 RVA: 0x00E2C778 File Offset: 0x00E2A978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<SGameplayTagProbabilityCooldownInfo> TagProbability { [return: Nullable(new byte[]
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
