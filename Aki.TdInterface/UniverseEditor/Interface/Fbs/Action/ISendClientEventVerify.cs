using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007737 RID: 30519
	public static class ISendClientEventVerify
	{
		// Token: 0x060358C8 RID: 219336 RVA: 0x0072D764 File Offset: 0x0072B964
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISendClientEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISendClientEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientEventVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086B9 RID: 34489
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB2 RID: 84658
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
