using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E3 RID: 27107
	public static class ILeisureInteractVerify
	{
		// Token: 0x0602F668 RID: 194152 RVA: 0x00674F70 File Offset: 0x00673170
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILeisureInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILeisureInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TLeisureInteractOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D98 RID: 32152
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401392B RID: 80171
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
