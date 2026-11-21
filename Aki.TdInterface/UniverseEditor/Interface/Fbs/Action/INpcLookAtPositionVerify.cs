using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007336 RID: 29494
	public static class INpcLookAtPositionVerify
	{
		// Token: 0x060336FB RID: 210683 RVA: 0x006EF210 File Offset: 0x006ED410
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcLookAtPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcLookAtPositionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008653 RID: 34387
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A2F RID: 84527
			public static VerifyTableAction <0>__Verify;
		}
	}
}
