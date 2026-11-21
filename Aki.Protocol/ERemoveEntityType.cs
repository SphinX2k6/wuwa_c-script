using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F4 RID: 5620
	public enum ERemoveEntityType
	{
		// Token: 0x0400AB55 RID: 43861
		[OriginalName("RemoveTypeForce")]
		RemoveTypeForce,
		// Token: 0x0400AB56 RID: 43862
		[OriginalName("HpIsZero")]
		HpIsZero,
		// Token: 0x0400AB57 RID: 43863
		[OriginalName("Destructible")]
		Destructible,
		// Token: 0x0400AB58 RID: 43864
		[OriginalName("RemoveTypeNormal")]
		RemoveTypeNormal,
		// Token: 0x0400AB59 RID: 43865
		[OriginalName("RemoveTypeCapture")]
		RemoveTypeCapture,
		// Token: 0x0400AB5A RID: 43866
		[OriginalName("RemoveTypeTreasureBox")]
		RemoveTypeTreasureBox,
		// Token: 0x0400AB5B RID: 43867
		[OriginalName("RemoveTypeDrop")]
		RemoveTypeDrop,
		// Token: 0x0400AB5C RID: 43868
		[OriginalName("MonsterBoom")]
		MonsterBoom,
		// Token: 0x0400AB5D RID: 43869
		[OriginalName("RemoveTypeResetByModeChange")]
		RemoveTypeResetByModeChange,
		// Token: 0x0400AB5E RID: 43870
		[OriginalName("RemoveTypSimpleCombat")]
		RemoveTypSimpleCombat,
		// Token: 0x0400AB5F RID: 43871
		[OriginalName("RbBlockDestroyed")]
		RbBlockDestroyed,
		// Token: 0x0400AB60 RID: 43872
		[OriginalName("AllRoleDying")]
		AllRoleDying,
		// Token: 0x0400AB61 RID: 43873
		[OriginalName("DyingTimeOut")]
		DyingTimeOut
	}
}
