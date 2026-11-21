using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BB2 RID: 19378
	public static class IPlotPositionVerify
	{
		// Token: 0x0601D945 RID: 121157 RVA: 0x004270B0 File Offset: 0x004252B0
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

		// Token: 0x02008230 RID: 33328
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143F8 RID: 82936
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143F9 RID: 82937
			public static VerifyTableAction <1>__Verify;
		}
	}
}
