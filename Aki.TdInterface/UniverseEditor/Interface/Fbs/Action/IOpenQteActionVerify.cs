using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1A RID: 27674
	public static class IOpenQteActionVerify
	{
		// Token: 0x06030ABC RID: 199356 RVA: 0x0069B7F8 File Offset: 0x006999F8
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

		// Token: 0x02007DD6 RID: 32214
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401397B RID: 80251
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
