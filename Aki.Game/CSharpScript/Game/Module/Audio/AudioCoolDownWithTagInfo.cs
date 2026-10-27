using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E86 RID: 24198
	public class AudioCoolDownWithTagInfo : AudioCoolDownInfo, IAudioCoolDownWithTagInfo, IAudioCoolDownInfo
	{
		// Token: 0x17008E8B RID: 36491
		// (get) Token: 0x0603D8EE RID: 252142 RVA: 0x00EDB1E4 File Offset: 0x00ED93E4
		// (set) Token: 0x0603D8EF RID: 252143 RVA: 0x00EDB1EC File Offset: 0x00ED93EC
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
