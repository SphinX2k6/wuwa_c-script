using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager
{
	// Token: 0x02003E29 RID: 15913
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Manager/ECharacterRenderingType.ECharacterRenderingType")]
	public enum ECharacterRenderingType : byte
	{
		// Token: 0x040143B8 RID: 82872
		LocalPlayer,
		// Token: 0x040143B9 RID: 82873
		RemotePlayer,
		// Token: 0x040143BA RID: 82874
		Monster,
		// Token: 0x040143BB RID: 82875
		Npc,
		// Token: 0x040143BC RID: 82876
		Pet,
		// Token: 0x040143BD RID: 82877
		UI,
		// Token: 0x040143BE RID: 82878
		Sequence,
		// Token: 0x040143BF RID: 82879
		Default,
		// Token: 0x040143C0 RID: 82880
		Effect,
		// Token: 0x040143C1 RID: 82881
		Error,
		// Token: 0x040143C2 RID: 82882
		ECharacterRenderingType_MAX
	}
}
