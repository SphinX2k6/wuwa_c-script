using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005694 RID: 22164
	public static class IObstacleDetectionConfigVerify
	{
		// Token: 0x06024FC3 RID: 151491 RVA: 0x0051BB94 File Offset: 0x00519D94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IObstacleDetectionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IObstacleDetectionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ITrafficMatchTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IObstacleDetectionConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IObstacleDetectionConfigVerify.<>O.<1>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BC0 RID: 31680
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013670 RID: 79472
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013671 RID: 79473
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
