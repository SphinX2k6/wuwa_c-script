using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016FD RID: 5885
	[EnumExtensions]
	public enum EBvbPlayerOperationType
	{
		// Token: 0x04004D5A RID: 19802
		BvbDeploy,
		// Token: 0x04004D5B RID: 19803
		BvbEvolution,
		// Token: 0x04004D5C RID: 19804
		BvbChangeHandCard,
		// Token: 0x04004D5D RID: 19805
		BvbChangeBoardCard,
		// Token: 0x04004D5E RID: 19806
		BvbRecycleHandCard,
		// Token: 0x04004D5F RID: 19807
		BvbRecycleBoardCard,
		// Token: 0x04004D60 RID: 19808
		BvbEndTurn,
		// Token: 0x04004D61 RID: 19809
		BvbUseItemCardSkill,
		// Token: 0x04004D62 RID: 19810
		BvbUseFieldCardSkill,
		// Token: 0x04004D63 RID: 19811
		BvbSelectCard
	}
}
