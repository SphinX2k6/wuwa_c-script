using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007725 RID: 30501
	public static class ISendBattleEventsVerify
	{
		// Token: 0x06035842 RID: 219202 RVA: 0x0072C908 File Offset: 0x0072AB08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISendBattleEventsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISendBattleEventsVerify.<>O.<0>__Verify = new VerifyTableAction(ISetBattleTagConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086B7 RID: 34487
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB0 RID: 84656
			public static VerifyTableAction <0>__Verify;
		}
	}
}
