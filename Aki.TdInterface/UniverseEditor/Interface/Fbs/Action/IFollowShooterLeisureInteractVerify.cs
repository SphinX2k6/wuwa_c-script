using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDD RID: 28381
	public static class IFollowShooterLeisureInteractVerify
	{
		// Token: 0x060311B0 RID: 201136 RVA: 0x006A8644 File Offset: 0x006A6844
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFollowShooterLeisureInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowShooterLeisureInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TFollowShooterLeisureTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085F5 RID: 34293
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B1 RID: 84401
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
