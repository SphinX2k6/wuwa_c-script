using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F45 RID: 20293
	public static class IBurrowHookVerify
	{
		// Token: 0x06020222 RID: 131618 RVA: 0x004787A8 File Offset: 0x004769A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBurrowHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBurrowHookVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A97 RID: 31383
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013478 RID: 78968
			public static VerifyTableAction <0>__Verify;
		}
	}
}
