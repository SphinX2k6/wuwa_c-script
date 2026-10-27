using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x02004443 RID: 17475
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EWalkingPosture.EWalkingPosture")]
	public enum EWalkingPosture : byte
	{
		// Token: 0x04018105 RID: 98565
		走,
		// Token: 0x04018106 RID: 98566
		跑,
		// Token: 0x04018107 RID: 98567
		EWalkingPosture_MAX
	}
}
