using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042BA RID: 17082
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EGait.EGait")]
	public enum EGait : byte
	{
		// Token: 0x040173C8 RID: 95176
		Walking,
		// Token: 0x040173C9 RID: 95177
		Running,
		// Token: 0x040173CA RID: 95178
		Sprinting,
		// Token: 0x040173CB RID: 95179
		Stand,
		// Token: 0x040173CC RID: 95180
		EGait_MAX
	}
}
