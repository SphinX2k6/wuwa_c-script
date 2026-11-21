using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x020032D3 RID: 13011
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/EInputCompSwallowMode.EInputCompSwallowMode")]
	public enum EInputCompSwallowMode : byte
	{
		// Token: 0x04011DD0 RID: 73168
		Override,
		// Token: 0x04011DD1 RID: 73169
		All,
		// Token: 0x04011DD2 RID: 73170
		None,
		// Token: 0x04011DD3 RID: 73171
		EInputCompSwallowMode_MAX
	}
}
