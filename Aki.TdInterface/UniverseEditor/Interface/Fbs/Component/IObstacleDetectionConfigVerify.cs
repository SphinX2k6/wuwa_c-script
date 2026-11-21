using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C35 RID: 23605
	public static class IObstacleDetectionConfigVerify
	{
		// Token: 0x060271FC RID: 160252 RVA: 0x0055C730 File Offset: 0x0055A930
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

		// Token: 0x02008422 RID: 33826
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146FF RID: 83711
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014700 RID: 83712
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
