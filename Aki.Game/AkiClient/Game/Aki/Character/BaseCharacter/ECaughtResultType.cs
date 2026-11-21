using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032FA RID: 13050
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECaughtResultType.ECaughtResultType")]
	public enum ECaughtResultType : byte
	{
		// Token: 0x04011FFA RID: 73722
		Success,
		// Token: 0x04011FFB RID: 73723
		Fail,
		// Token: 0x04011FFC RID: 73724
		Ignore,
		// Token: 0x04011FFD RID: 73725
		ECaughtResultType_MAX
	}
}
