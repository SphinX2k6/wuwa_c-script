using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F2 RID: 5618
	public enum EEntityType
	{
		// Token: 0x0400AB46 RID: 43846
		[OriginalName("Player")]
		Player,
		// Token: 0x0400AB47 RID: 43847
		[OriginalName("Npc")]
		Npc,
		// Token: 0x0400AB48 RID: 43848
		[OriginalName("Monster")]
		Monster,
		// Token: 0x0400AB49 RID: 43849
		[OriginalName("SceneItem")]
		SceneItem = 5,
		// Token: 0x0400AB4A RID: 43850
		[OriginalName("Custom")]
		Custom,
		// Token: 0x0400AB4B RID: 43851
		[OriginalName("Vision")]
		Vision,
		// Token: 0x0400AB4C RID: 43852
		[OriginalName("Animal")]
		Animal,
		// Token: 0x0400AB4D RID: 43853
		[OriginalName("ClientOnly")]
		ClientOnly,
		// Token: 0x0400AB4E RID: 43854
		[OriginalName("Vehicle")]
		Vehicle,
		// Token: 0x0400AB4F RID: 43855
		[OriginalName("PlayerEntity")]
		PlayerEntity,
		// Token: 0x0400AB50 RID: 43856
		[OriginalName("SceneEntity")]
		SceneEntity
	}
}
