using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA4 RID: 15780
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/QuantizerAxisIgnore.QuantizerAxisIgnore")]
	public enum QuantizerAxisIgnore : byte
	{
		// Token: 0x04013C05 RID: 80901
		X,
		// Token: 0x04013C06 RID: 80902
		Y,
		// Token: 0x04013C07 RID: 80903
		Z,
		// Token: 0x04013C08 RID: 80904
		CAMERA,
		// Token: 0x04013C09 RID: 80905
		NONE,
		// Token: 0x04013C0A RID: 80906
		ALL,
		// Token: 0x04013C0B RID: 80907
		QuantizerAxisIgnore_MAX
	}
}
