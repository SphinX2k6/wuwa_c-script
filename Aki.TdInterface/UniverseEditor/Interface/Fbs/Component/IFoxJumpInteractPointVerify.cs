using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582E RID: 22574
	public static class IFoxJumpInteractPointVerify
	{
		// Token: 0x060248B4 RID: 149684 RVA: 0x00505540 File Offset: 0x00503740
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpInteractPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpInteractPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFoxJumpInteractPointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpInteractPointVerify.<>O.<1>__Verify = new VerifyUnionAction(TFoxJumpInteractPointRelationTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200838F RID: 33679
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145F3 RID: 83443
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145F4 RID: 83444
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
