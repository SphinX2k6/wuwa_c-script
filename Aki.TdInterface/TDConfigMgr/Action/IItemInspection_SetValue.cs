using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B65 RID: 7013
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemInspection_SetValue
	{
		// Token: 0x04005BD5 RID: 23509
		public ESimpleGameplayType Type;

		// Token: 0x04005BD6 RID: 23510
		public string PrefabPath;

		// Token: 0x04005BD7 RID: 23511
		public float RotateSpeed;

		// Token: 0x04005BD8 RID: 23512
		public ISequenceUnlockPoints InteractPointsConfig;

		// Token: 0x04005BD9 RID: 23513
		public IConeRangeCheck RangeCheckConfig;

		// Token: 0x04005BDA RID: 23514
		public IAstrologyTextUiConfig TextUiConfig;

		// Token: 0x04005BDB RID: 23515
		public bool? CanExit;

		// Token: 0x04005BDC RID: 23516
		public float? ItemOffsetDistance;

		// Token: 0x04005BDD RID: 23517
		[Nullable(2)]
		public IItemInspectFinishEffect ItemInteractFinishEffect;
	}
}
