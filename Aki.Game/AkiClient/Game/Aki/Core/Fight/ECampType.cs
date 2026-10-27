using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004002 RID: 16386
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/ECampType.ECampType")]
	public enum ECampType : byte
	{
		// Token: 0x04015983 RID: 88451
		不生效,
		// Token: 0x04015984 RID: 88452
		对自己,
		// Token: 0x04015985 RID: 88453
		对敌方,
		// Token: 0x04015986 RID: 88454
		对友方,
		// Token: 0x04015987 RID: 88455
		对自己和友方,
		// Token: 0x04015988 RID: 88456
		对自己和敌方,
		// Token: 0x04015989 RID: 88457
		全部,
		// Token: 0x0401598A RID: 88458
		ECampType_MAX
	}
}
