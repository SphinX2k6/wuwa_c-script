using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048AA RID: 18602
	public class MoveCheckInfo
	{
		// Token: 0x06030A01 RID: 199169 RVA: 0x00B4A624 File Offset: 0x00B48824
		public void Reset()
		{
			this.BeforeMoveCheckResult = EMoveCheckResult.None;
			this.AfterMoveCheckResult = EMoveCheckResult.None;
			this.AfterMoveCheckInfo.Result = EMoveCheckResult.None;
			this.AfterMoveCheckInfo.AfterAdjustDistance = float.MaxValue;
		}

		// Token: 0x06030A02 RID: 199170 RVA: 0x00B4A650 File Offset: 0x00B48850
		public void TryUpdateAdjustDistance(EMoveCheckResult checkResult, float afterAdjustDistance)
		{
			if (afterAdjustDistance < this.AfterMoveCheckInfo.AfterAdjustDistance)
			{
				this.AfterMoveCheckInfo.Result = checkResult;
				this.AfterMoveCheckInfo.AfterAdjustDistance = afterAdjustDistance;
			}
		}

		// Token: 0x0401A21E RID: 107038
		public EMoveCheckResult BeforeMoveCheckResult;

		// Token: 0x0401A21F RID: 107039
		public EMoveCheckResult AfterMoveCheckResult;

		// Token: 0x0401A220 RID: 107040
		[Nullable(1)]
		public IMoveCheckResultAndDistance AfterMoveCheckInfo = new MoveCheckResultAndDistance
		{
			Result = EMoveCheckResult.None,
			AfterAdjustDistance = float.MaxValue
		};

		// Token: 0x0401A221 RID: 107041
		public float BrakingDistance;
	}
}
