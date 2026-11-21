using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD8 RID: 19672
	public static class IEditorStateVerify
	{
		// Token: 0x0601E606 RID: 124422 RVA: 0x004417E0 File Offset: 0x0043F9E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
			{
				short offsetId = 24;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEditorStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEditorStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEditorRestartInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200825A RID: 33370
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014435 RID: 82997
			public static VerifyTableAction <0>__Verify;
		}
	}
}
