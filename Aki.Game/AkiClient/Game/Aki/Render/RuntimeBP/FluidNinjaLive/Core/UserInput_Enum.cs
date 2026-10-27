using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DAA RID: 15786
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/UserInput_Enum.UserInput_Enum")]
	public enum UserInput_Enum : byte
	{
		// Token: 0x04013C31 RID: 80945
		No_user_input,
		// Token: 0x04013C32 RID: 80946
		Mouse_single,
		// Token: 0x04013C33 RID: 80947
		Touch_single,
		// Token: 0x04013C34 RID: 80948
		Touch_multiple,
		// Token: 0x04013C35 RID: 80949
		UserInput_MAX
	}
}
