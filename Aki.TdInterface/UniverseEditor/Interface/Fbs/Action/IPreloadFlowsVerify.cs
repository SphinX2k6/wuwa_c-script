using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D94 RID: 28052
	public static class IPreloadFlowsVerify
	{
		// Token: 0x060318DA RID: 202970 RVA: 0x006B763C File Offset: 0x006B583C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPreloadFlowsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreloadFlowsVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E05 RID: 32261
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C0 RID: 80320
			public static VerifyTableAction <0>__Verify;
		}
	}
}
