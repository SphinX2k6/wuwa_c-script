using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200474A RID: 18250
	public static class IPlotPositionVerify
	{
		// Token: 0x0601C170 RID: 115056 RVA: 0x003FAE14 File Offset: 0x003F9014
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlotPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlotPositionVerify.<>O.<0>__Verify = new VerifyTableAction(IPlotPosPlayFlowVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlotPositionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlotPositionVerify.<>O.<1>__Verify = new VerifyTableAction(IPlotPosFlowStateVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020079E7 RID: 31207
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013391 RID: 78737
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013392 RID: 78738
			public static VerifyTableAction <1>__Verify;
		}
	}
}
