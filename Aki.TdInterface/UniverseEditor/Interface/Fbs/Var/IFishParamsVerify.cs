using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E91 RID: 16017
	public static class IFishParamsVerify
	{
		// Token: 0x06015A07 RID: 88583 RVA: 0x0031DC38 File Offset: 0x0031BE38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFishParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFishParamsVerify.<>O.<0>__Verify = new VerifyUnionAction(TFishStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080BD RID: 32957
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401413D RID: 82237
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
