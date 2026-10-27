using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Gameplay.InformationLib
{
	// Token: 0x02003F46 RID: 16198
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/InformationLib/EInfoLib.EInfoLib")]
	public enum EInfoLib : byte
	{
		// Token: 0x040151CD RID: 86477
		文字,
		// Token: 0x040151CE RID: 86478
		图片,
		// Token: 0x040151CF RID: 86479
		声音,
		// Token: 0x040151D0 RID: 86480
		视频,
		// Token: 0x040151D1 RID: 86481
		EInfoLib_MAX
	}
}
