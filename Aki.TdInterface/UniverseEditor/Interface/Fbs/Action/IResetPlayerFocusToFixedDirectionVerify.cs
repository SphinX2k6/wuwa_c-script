using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E96 RID: 28310
	public static class IResetPlayerFocusToFixedDirectionVerify
	{
		// Token: 0x06032098 RID: 204952 RVA: 0x006C47B4 File Offset: 0x006C29B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IResetPlayerFocusToFixedDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetPlayerFocusToFixedDirectionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E17 RID: 32279
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D2 RID: 80338
			public static VerifyTableAction <0>__Verify;
		}
	}
}
