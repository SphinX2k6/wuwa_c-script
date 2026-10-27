using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBC RID: 28604
	public static class ISetBattleTagVerify
	{
		// Token: 0x060328E9 RID: 207081 RVA: 0x006D2970 File Offset: 0x006D0B70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetBattleTagVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetBattleTagVerify.<>O.<0>__Verify = new VerifyTableAction(ISetEntityTagVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E33 RID: 32307
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F1 RID: 80369
			public static VerifyTableAction <0>__Verify;
		}
	}
}
