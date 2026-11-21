using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B42 RID: 23362
	public static class IMonsterSummonInteractPointVerify
	{
		// Token: 0x060266C9 RID: 157385 RVA: 0x005430A0 File Offset: 0x005412A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterSummonInteractPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterSummonInteractPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083F8 RID: 33784
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146B2 RID: 83634
			public static VerifyTableAction <0>__Verify;
		}
	}
}
