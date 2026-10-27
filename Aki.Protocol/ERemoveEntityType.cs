using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157E RID: 5502
	public enum ERemoveEntityType
	{
		// Token: 0x0400A6C8 RID: 42696
		[OriginalName("RemoveTypeForce")]
		RemoveTypeForce,
		// Token: 0x0400A6C9 RID: 42697
		[OriginalName("HpIsZero")]
		HpIsZero,
		// Token: 0x0400A6CA RID: 42698
		[OriginalName("Destructible")]
		Destructible,
		// Token: 0x0400A6CB RID: 42699
		[OriginalName("RemoveTypeNormal")]
		RemoveTypeNormal,
		// Token: 0x0400A6CC RID: 42700
		[OriginalName("RemoveTypeCapture")]
		RemoveTypeCapture,
		// Token: 0x0400A6CD RID: 42701
		[OriginalName("RemoveTypeTreasureBox")]
		RemoveTypeTreasureBox,
		// Token: 0x0400A6CE RID: 42702
		[OriginalName("RemoveTypeDrop")]
		RemoveTypeDrop,
		// Token: 0x0400A6CF RID: 42703
		[OriginalName("MonsterBoom")]
		MonsterBoom,
		// Token: 0x0400A6D0 RID: 42704
		[OriginalName("RemoveTypeResetByModeChange")]
		RemoveTypeResetByModeChange,
		// Token: 0x0400A6D1 RID: 42705
		[OriginalName("RemoveTypSimpleCombat")]
		RemoveTypSimpleCombat,
		// Token: 0x0400A6D2 RID: 42706
		[OriginalName("RbBlockDestroyed")]
		RbBlockDestroyed,
		// Token: 0x0400A6D3 RID: 42707
		[OriginalName("AllRoleDying")]
		AllRoleDying,
		// Token: 0x0400A6D4 RID: 42708
		[OriginalName("DyingTimeOut")]
		DyingTimeOut
	}
}
