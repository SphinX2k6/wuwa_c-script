using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007785 RID: 30597
	public static class ISetBattleTagVerify
	{
		// Token: 0x06035B4F RID: 219983 RVA: 0x007325B4 File Offset: 0x007307B4
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

		// Token: 0x020086C8 RID: 34504
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC2 RID: 84674
			public static VerifyTableAction <0>__Verify;
		}
	}
}
