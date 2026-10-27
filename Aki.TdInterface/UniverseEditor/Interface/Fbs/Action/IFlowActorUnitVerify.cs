using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F4 RID: 26612
	public static class IFlowActorUnitVerify
	{
		// Token: 0x0602E56E RID: 189806 RVA: 0x006535E0 File Offset: 0x006517E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowActorUnitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowActorUnitVerify.<>O.<0>__Verify = new VerifyTableAction(IActorInitialStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D74 RID: 32116
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F7 RID: 80119
			public static VerifyTableAction <0>__Verify;
		}
	}
}
