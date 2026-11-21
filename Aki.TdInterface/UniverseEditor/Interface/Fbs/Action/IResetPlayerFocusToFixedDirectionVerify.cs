using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761A RID: 30234
	public static class IResetPlayerFocusToFixedDirectionVerify
	{
		// Token: 0x060350D8 RID: 217304 RVA: 0x007204E8 File Offset: 0x0071E6E8
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

		// Token: 0x020086A3 RID: 34467
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A96 RID: 84630
			public static VerifyTableAction <0>__Verify;
		}
	}
}
