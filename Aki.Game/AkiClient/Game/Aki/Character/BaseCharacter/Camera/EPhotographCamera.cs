using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033DA RID: 13274
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EPhotographCamera.EPhotographCamera")]
	public enum EPhotographCamera : byte
	{
		// Token: 0x040127EC RID: 75756
		None,
		// Token: 0x040127ED RID: 75757
		战斗拍照角色最大虚化仰视角,
		// Token: 0x040127EE RID: 75758
		战斗拍照角色开始虚化距离,
		// Token: 0x040127EF RID: 75759
		战斗拍照角色最大虚化距离,
		// Token: 0x040127F0 RID: 75760
		战斗拍照角色虚化不透明度,
		// Token: 0x040127F1 RID: 75761
		拍照界面npc开始虚化距离,
		// Token: 0x040127F2 RID: 75762
		拍照界面npc最大虚化距离,
		// Token: 0x040127F3 RID: 75763
		拍照界面npc虚化不透明度,
		// Token: 0x040127F4 RID: 75764
		角色开始虚化距离,
		// Token: 0x040127F5 RID: 75765
		角色最大虚化距离,
		// Token: 0x040127F6 RID: 75766
		角色开始虚化仰视角,
		// Token: 0x040127F7 RID: 75767
		角色最大虚化仰视角,
		// Token: 0x040127F8 RID: 75768
		角色虚化不透明度,
		// Token: 0x040127F9 RID: 75769
		角色开始虚化屏幕占比,
		// Token: 0x040127FA RID: 75770
		角色最大虚化屏幕占比,
		// Token: 0x040127FB RID: 75771
		战斗拍照角色开始虚化仰视角,
		// Token: 0x040127FC RID: 75772
		EPhotographCamera_MAX
	}
}
