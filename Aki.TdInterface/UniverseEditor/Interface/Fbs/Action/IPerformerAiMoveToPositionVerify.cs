using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F3 RID: 29683
	public static class IPerformerAiMoveToPositionVerify
	{
		// Token: 0x06033ED3 RID: 212691 RVA: 0x007003AC File Offset: 0x006FE5AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPerformerAiMoveToPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformerAiMoveToPositionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200866E RID: 34414
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A58 RID: 84568
			public static VerifyTableAction <0>__Verify;
		}
	}
}
