using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDC RID: 28636
	public static class ISetElementalBoxToTargetVerify
	{
		// Token: 0x060329F7 RID: 207351 RVA: 0x006D4820 File Offset: 0x006D2A20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetElementalBoxToTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetElementalBoxToTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E37 RID: 32311
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F6 RID: 80374
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
