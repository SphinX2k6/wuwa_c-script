using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676E RID: 26478
	public static class IActorTurnToPositionDataVerify
	{
		// Token: 0x0602CE0D RID: 183821 RVA: 0x00622E70 File Offset: 0x00621070
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

		// Token: 0x0200854A RID: 34122
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148B3 RID: 84147
			public static VerifyTableAction <0>__Verify;
		}
	}
}
