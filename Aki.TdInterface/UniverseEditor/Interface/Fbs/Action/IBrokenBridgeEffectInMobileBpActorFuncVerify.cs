using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006226 RID: 25126
	public static class IBrokenBridgeEffectInMobileBpActorFuncVerify
	{
		// Token: 0x0602B4F7 RID: 177399 RVA: 0x005F6D74 File Offset: 0x005F4F74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBrokenBridgeEffectInMobileBpActorFuncVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBrokenBridgeEffectInMobileBpActorFuncVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CF7 RID: 31991
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013856 RID: 79958
			public static VerifyTableAction <0>__Verify;
		}
	}
}
