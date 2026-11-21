using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007381 RID: 29569
	public static class IOpenQteActionVerify
	{
		// Token: 0x06033A10 RID: 211472 RVA: 0x006F5AF4 File Offset: 0x006F3CF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenQteActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenQteActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TOpenQteConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008660 RID: 34400
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A3D RID: 84541
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
