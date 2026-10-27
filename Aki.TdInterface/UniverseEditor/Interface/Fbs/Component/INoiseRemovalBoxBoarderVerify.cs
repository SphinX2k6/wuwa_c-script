using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005604 RID: 22020
	public static class INoiseRemovalBoxBoarderVerify
	{
		// Token: 0x06024898 RID: 149656 RVA: 0x0050AC00 File Offset: 0x00508E00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INoiseRemovalBoxBoarderVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INoiseRemovalBoxBoarderVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INoiseRemovalBoxBoarderVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INoiseRemovalBoxBoarderVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BA3 RID: 31651
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013639 RID: 79417
			public static VerifyTableAction <0>__Verify;
		}
	}
}
