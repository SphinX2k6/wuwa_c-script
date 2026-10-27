using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157C RID: 5500
	public enum EEntityType
	{
		// Token: 0x0400A6B9 RID: 42681
		[OriginalName("Player")]
		Player,
		// Token: 0x0400A6BA RID: 42682
		[OriginalName("Npc")]
		Npc,
		// Token: 0x0400A6BB RID: 42683
		[OriginalName("Monster")]
		Monster,
		// Token: 0x0400A6BC RID: 42684
		[OriginalName("SceneItem")]
		SceneItem = 5,
		// Token: 0x0400A6BD RID: 42685
		[OriginalName("Custom")]
		Custom,
		// Token: 0x0400A6BE RID: 42686
		[OriginalName("Vision")]
		Vision,
		// Token: 0x0400A6BF RID: 42687
		[OriginalName("Animal")]
		Animal,
		// Token: 0x0400A6C0 RID: 42688
		[OriginalName("ClientOnly")]
		ClientOnly,
		// Token: 0x0400A6C1 RID: 42689
		[OriginalName("Vehicle")]
		Vehicle,
		// Token: 0x0400A6C2 RID: 42690
		[OriginalName("PlayerEntity")]
		PlayerEntity,
		// Token: 0x0400A6C3 RID: 42691
		[OriginalName("SceneEntity")]
		SceneEntity
	}
}
