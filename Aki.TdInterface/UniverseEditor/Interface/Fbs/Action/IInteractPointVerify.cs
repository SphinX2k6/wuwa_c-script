using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699B RID: 27035
	public static class IInteractPointVerify
	{
		// Token: 0x0602F3DC RID: 193500 RVA: 0x0066F7FC File Offset: 0x0066D9FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractPointVerify.<>O.<0>__Verify = new VerifyTableAction(IDragInteractPointInteractionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D91 RID: 32145
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013921 RID: 80161
			public static VerifyTableAction <0>__Verify;
		}
	}
}
