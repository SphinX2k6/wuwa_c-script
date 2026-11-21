using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D12 RID: 7442
	public class IItemInspection_SetValue
	{
		// Token: 0x0400606E RID: 24686
		public ESimpleGameplayType Type;

		// Token: 0x0400606F RID: 24687
		public string PrefabPath;

		// Token: 0x04006070 RID: 24688
		public float RotateSpeed;

		// Token: 0x04006071 RID: 24689
		public ISequenceUnlockPoints InteractPointsConfig;

		// Token: 0x04006072 RID: 24690
		public IConeRangeCheck RangeCheckConfig;

		// Token: 0x04006073 RID: 24691
		public IAstrologyTextUiConfig TextUiConfig;

		// Token: 0x04006074 RID: 24692
		public bool? CanExit;

		// Token: 0x04006075 RID: 24693
		public float? ItemOffsetDistance;

		// Token: 0x04006076 RID: 24694
		[Nullable(2)]
		public IItemInspectFinishEffect ItemInteractFinishEffect;
	}
}
