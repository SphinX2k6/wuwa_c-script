using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006897 RID: 26775
	public static class IBrokenBridgeEffectInMobileBpActorFuncVerify
	{
		// Token: 0x0602DC58 RID: 187480 RVA: 0x00641B7C File Offset: 0x0063FD7C
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

		// Token: 0x0200856A RID: 34154
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148FE RID: 84222
			public static VerifyTableAction <0>__Verify;
		}
	}
}
