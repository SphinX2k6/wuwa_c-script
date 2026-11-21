using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA2 RID: 23458
	public static class INoiseRemovalBoxBoarderVerify
	{
		// Token: 0x06026AA8 RID: 158376 RVA: 0x0054B218 File Offset: 0x00549418
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

		// Token: 0x02008405 RID: 33797
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146C8 RID: 83656
			public static VerifyTableAction <0>__Verify;
		}
	}
}
