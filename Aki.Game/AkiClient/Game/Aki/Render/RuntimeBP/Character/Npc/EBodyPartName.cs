using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003DFB RID: 15867
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/EBodyPartName.EBodyPartName")]
	public enum EBodyPartName : byte
	{
		// Token: 0x040140E9 RID: 82153
		Skel_Hair,
		// Token: 0x040140EA RID: 82154
		Skel_Face,
		// Token: 0x040140EB RID: 82155
		Skel_Body_Up,
		// Token: 0x040140EC RID: 82156
		Skel_Body_Down,
		// Token: 0x040140ED RID: 82157
		Skel_Body,
		// Token: 0x040140EE RID: 82158
		ChildPart,
		// Token: 0x040140EF RID: 82159
		EBodyPartName_MAX
	}
}
