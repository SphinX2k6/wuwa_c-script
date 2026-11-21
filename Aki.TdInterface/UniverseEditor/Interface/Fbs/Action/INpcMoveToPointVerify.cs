using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733F RID: 29503
	public static class INpcMoveToPointVerify
	{
		// Token: 0x06033737 RID: 210743 RVA: 0x006EF81C File Offset: 0x006EDA1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcMoveToPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcMoveToPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008654 RID: 34388
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A30 RID: 84528
			public static VerifyTableAction <0>__Verify;
		}
	}
}
