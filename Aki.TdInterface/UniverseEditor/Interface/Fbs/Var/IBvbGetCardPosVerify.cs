using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E3D RID: 15933
	public static class IBvbGetCardPosVerify
	{
		// Token: 0x06015748 RID: 87880 RVA: 0x00318E44 File Offset: 0x00317044
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbGetCardPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbGetCardPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B6 RID: 32950
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014135 RID: 82229
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
