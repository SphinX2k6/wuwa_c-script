using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040AE RID: 16558
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/EFootstepAkAudioEventType.EFootstepAkAudioEventType")]
	public enum EFootstepAkAudioEventType : byte
	{
		// Token: 0x0401623F RID: 90687
		Walk,
		// Token: 0x04016240 RID: 90688
		Run,
		// Token: 0x04016241 RID: 90689
		Sprint,
		// Token: 0x04016242 RID: 90690
		Fallback,
		// Token: 0x04016243 RID: 90691
		EFootstepAkAudioEventType_MAX
	}
}
