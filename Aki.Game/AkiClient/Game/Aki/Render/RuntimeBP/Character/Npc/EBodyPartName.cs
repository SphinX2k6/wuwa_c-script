using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x0200311C RID: 12572
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/EBodyPartName.EBodyPartName")]
	public enum EBodyPartName : byte
	{
		// Token: 0x0401060F RID: 67087
		Skel_Hair,
		// Token: 0x04010610 RID: 67088
		Skel_Face,
		// Token: 0x04010611 RID: 67089
		Skel_Body_Up,
		// Token: 0x04010612 RID: 67090
		Skel_Body_Down,
		// Token: 0x04010613 RID: 67091
		Skel_Body,
		// Token: 0x04010614 RID: 67092
		ChildPart,
		// Token: 0x04010615 RID: 67093
		EBodyPartName_MAX
	}
}
