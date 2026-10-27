using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200159E RID: 5534
	[EnumExtensions]
	public enum EBvbPlayerOperationType
	{
		// Token: 0x040049A8 RID: 18856
		BvbDeploy,
		// Token: 0x040049A9 RID: 18857
		BvbEvolution,
		// Token: 0x040049AA RID: 18858
		BvbChangeHandCard,
		// Token: 0x040049AB RID: 18859
		BvbChangeBoardCard,
		// Token: 0x040049AC RID: 18860
		BvbRecycleHandCard,
		// Token: 0x040049AD RID: 18861
		BvbRecycleBoardCard,
		// Token: 0x040049AE RID: 18862
		BvbEndTurn,
		// Token: 0x040049AF RID: 18863
		BvbUseItemCardSkill,
		// Token: 0x040049B0 RID: 18864
		BvbUseFieldCardSkill,
		// Token: 0x040049B1 RID: 18865
		BvbSelectCard
	}
}
