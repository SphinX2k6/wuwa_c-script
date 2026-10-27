using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD2 RID: 27602
	public static class INpcLookAtPositionVerify
	{
		// Token: 0x060307DF RID: 198623 RVA: 0x00695910 File Offset: 0x00693B10
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

		// Token: 0x02007DCA RID: 32202
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401396E RID: 80238
			public static VerifyTableAction <0>__Verify;
		}
	}
}
