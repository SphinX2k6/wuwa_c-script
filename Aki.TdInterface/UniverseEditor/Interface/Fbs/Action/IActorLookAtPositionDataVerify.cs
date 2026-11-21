using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674D RID: 26445
	public static class IActorLookAtPositionDataVerify
	{
		// Token: 0x0602CD10 RID: 183568 RVA: 0x00621280 File Offset: 0x0061F480
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorLookAtPositionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorLookAtPositionDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008546 RID: 34118
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148AE RID: 84142
			public static VerifyTableAction <0>__Verify;
		}
	}
}
