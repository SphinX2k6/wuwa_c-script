using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200610C RID: 24844
	public static class IActorTurnToPositionDataVerify
	{
		// Token: 0x0602A72C RID: 173868 RVA: 0x005D8EC8 File Offset: 0x005D70C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorTurnToPositionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorTurnToPositionDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CD9 RID: 31961
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401380D RID: 79885
			public static VerifyTableAction <0>__Verify;
		}
	}
}
