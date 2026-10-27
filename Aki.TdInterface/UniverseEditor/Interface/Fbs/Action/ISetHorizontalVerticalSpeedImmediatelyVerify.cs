using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007003 RID: 28675
	public static class ISetHorizontalVerticalSpeedImmediatelyVerify
	{
		// Token: 0x06032B9C RID: 207772 RVA: 0x006D8328 File Offset: 0x006D6528
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetHorizontalVerticalSpeedImmediatelyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetHorizontalVerticalSpeedImmediatelyVerify.<>O.<0>__Verify = new VerifyUnionAction(TProcessedValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISetHorizontalVerticalSpeedImmediatelyVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISetHorizontalVerticalSpeedImmediatelyVerify.<>O.<0>__Verify = new VerifyUnionAction(TProcessedValueVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E3D RID: 32317
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A07 RID: 80391
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
