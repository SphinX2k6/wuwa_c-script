using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BAF RID: 19375
	public static class IPlotPosFlowStateVerify
	{
		// Token: 0x0601D923 RID: 121123 RVA: 0x00426B54 File Offset: 0x00424D54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlotPosFlowStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlotPosFlowStateVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowStateIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlotPosFlowStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlotPosFlowStateVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200822F RID: 33327
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143F6 RID: 82934
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143F7 RID: 82935
			public static VerifyTableAction <1>__Verify;
		}
	}
}
