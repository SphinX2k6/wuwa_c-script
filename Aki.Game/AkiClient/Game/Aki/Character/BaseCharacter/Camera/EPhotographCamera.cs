using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043BF RID: 17343
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EPhotographCamera.EPhotographCamera")]
	public enum EPhotographCamera : byte
	{
		// Token: 0x04017C84 RID: 97412
		None,
		// Token: 0x04017C85 RID: 97413
		战斗拍照角色最大虚化仰视角,
		// Token: 0x04017C86 RID: 97414
		战斗拍照角色开始虚化距离,
		// Token: 0x04017C87 RID: 97415
		战斗拍照角色最大虚化距离,
		// Token: 0x04017C88 RID: 97416
		战斗拍照角色虚化不透明度,
		// Token: 0x04017C89 RID: 97417
		拍照界面npc开始虚化距离,
		// Token: 0x04017C8A RID: 97418
		拍照界面npc最大虚化距离,
		// Token: 0x04017C8B RID: 97419
		拍照界面npc虚化不透明度,
		// Token: 0x04017C8C RID: 97420
		角色开始虚化距离,
		// Token: 0x04017C8D RID: 97421
		角色最大虚化距离,
		// Token: 0x04017C8E RID: 97422
		角色开始虚化仰视角,
		// Token: 0x04017C8F RID: 97423
		角色最大虚化仰视角,
		// Token: 0x04017C90 RID: 97424
		角色虚化不透明度,
		// Token: 0x04017C91 RID: 97425
		角色开始虚化屏幕占比,
		// Token: 0x04017C92 RID: 97426
		角色最大虚化屏幕占比,
		// Token: 0x04017C93 RID: 97427
		战斗拍照角色开始虚化仰视角,
		// Token: 0x04017C94 RID: 97428
		EPhotographCamera_MAX
	}
}
