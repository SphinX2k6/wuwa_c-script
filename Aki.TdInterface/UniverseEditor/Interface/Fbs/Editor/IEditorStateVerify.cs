using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004873 RID: 18547
	public static class IEditorStateVerify
	{
		// Token: 0x0601CE19 RID: 118297 RVA: 0x00415018 File Offset: 0x00413218
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEditorStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEditorStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEditorObjectCacheInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
				{
					short offsetId2 = 26;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEditorStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEditorStateVerify.<>O.<1>__Verify = new VerifyTableAction(IEditorRestartInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A11 RID: 31249
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133CE RID: 78798
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133CF RID: 78799
			public static VerifyTableAction <1>__Verify;
		}
	}
}
