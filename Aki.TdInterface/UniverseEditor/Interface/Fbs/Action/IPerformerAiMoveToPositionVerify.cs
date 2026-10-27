using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8C RID: 27788
	public static class IPerformerAiMoveToPositionVerify
	{
		// Token: 0x06030F78 RID: 200568 RVA: 0x006A5EAC File Offset: 0x006A40AC
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

		// Token: 0x02007DE4 RID: 32228
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013996 RID: 80278
			public static VerifyTableAction <0>__Verify;
		}
	}
}
