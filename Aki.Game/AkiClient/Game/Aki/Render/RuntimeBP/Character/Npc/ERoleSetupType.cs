using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003DFE RID: 15870
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/ERoleSetupType.ERoleSetupType")]
	public enum ERoleSetupType : byte
	{
		// Token: 0x040140FF RID: 82175
		RoleSetupType1,
		// Token: 0x04014100 RID: 82176
		RoleSetupType2,
		// Token: 0x04014101 RID: 82177
		RoleSetupType3,
		// Token: 0x04014102 RID: 82178
		ERoleSetupType_MAX
	}
}
