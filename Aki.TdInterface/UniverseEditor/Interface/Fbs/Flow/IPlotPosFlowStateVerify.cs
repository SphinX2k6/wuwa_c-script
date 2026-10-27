using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004747 RID: 18247
	public static class IPlotPosFlowStateVerify
	{
		// Token: 0x0601C14E RID: 115022 RVA: 0x003FA8B8 File Offset: 0x003F8AB8
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

		// Token: 0x020079E6 RID: 31206
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401338F RID: 78735
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013390 RID: 78736
			public static VerifyTableAction <1>__Verify;
		}
	}
}
