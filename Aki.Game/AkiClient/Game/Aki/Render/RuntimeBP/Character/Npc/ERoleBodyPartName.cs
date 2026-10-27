using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003DFD RID: 15869
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/ERoleBodyPartName.ERoleBodyPartName")]
	public enum ERoleBodyPartName : byte
	{
		// Token: 0x040140F5 RID: 82165
		Skel_Hair,
		// Token: 0x040140F6 RID: 82166
		Skel_Face,
		// Token: 0x040140F7 RID: 82167
		Skel_Body_Up,
		// Token: 0x040140F8 RID: 82168
		Skel_Body_Down,
		// Token: 0x040140F9 RID: 82169
		Skel_Body,
		// Token: 0x040140FA RID: 82170
		CharacterMesh,
		// Token: 0x040140FB RID: 82171
		WeaponCase,
		// Token: 0x040140FC RID: 82172
		OtherCase,
		// Token: 0x040140FD RID: 82173
		ERoleBodyPartName_MAX
	}
}
