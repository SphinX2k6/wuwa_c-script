using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E4 RID: 24804
	public static class ITrampleUe5ComponentVerify
	{
		// Token: 0x0602A025 RID: 172069 RVA: 0x005BBF10 File Offset: 0x005BA110
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrampleUe5ComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrampleUe5ComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrampleUe5ComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ITrampleUe5ComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084DA RID: 34010
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401482A RID: 84010
			public static VerifyTableAction <0>__Verify;
		}
	}
}
