using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC9 RID: 27593
	public static class INpcLookAtConfigVerify
	{
		// Token: 0x060307A1 RID: 198561 RVA: 0x006952CC File Offset: 0x006934CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcLookAtConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcLookAtConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TNpcLookAtTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DC9 RID: 32201
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401396D RID: 80237
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
