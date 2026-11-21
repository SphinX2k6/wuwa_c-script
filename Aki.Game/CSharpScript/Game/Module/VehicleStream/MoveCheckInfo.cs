using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003821 RID: 14369
	public class MoveCheckInfo
	{
		// Token: 0x0602552D RID: 152877 RVA: 0x00A8542C File Offset: 0x00A8362C
		public void Reset()
		{
			this.BeforeMoveCheckResult = EMoveCheckResult.None;
			this.AfterMoveCheckResult = EMoveCheckResult.None;
			this.AfterMoveCheckInfo.Result = EMoveCheckResult.None;
			this.AfterMoveCheckInfo.AfterAdjustDistance = float.MaxValue;
		}

		// Token: 0x0602552E RID: 152878 RVA: 0x00A85458 File Offset: 0x00A83658
		public void TryUpdateAdjustDistance(EMoveCheckResult checkResult, float afterAdjustDistance)
		{
			if (afterAdjustDistance < this.AfterMoveCheckInfo.AfterAdjustDistance)
			{
				this.AfterMoveCheckInfo.Result = checkResult;
				this.AfterMoveCheckInfo.AfterAdjustDistance = afterAdjustDistance;
			}
		}

		// Token: 0x04014A91 RID: 84625
		public EMoveCheckResult BeforeMoveCheckResult;

		// Token: 0x04014A92 RID: 84626
		public EMoveCheckResult AfterMoveCheckResult;

		// Token: 0x04014A93 RID: 84627
		[Nullable(1)]
		public IMoveCheckResultAndDistance AfterMoveCheckInfo = new MoveCheckResultAndDistance
		{
			Result = EMoveCheckResult.None,
			AfterAdjustDistance = float.MaxValue
		};

		// Token: 0x04014A94 RID: 84628
		public float BrakingDistance;
	}
}
