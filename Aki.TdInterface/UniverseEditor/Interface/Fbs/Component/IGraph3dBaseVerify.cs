using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005888 RID: 22664
	public static class IGraph3dBaseVerify
	{
		// Token: 0x06024C1F RID: 150559 RVA: 0x0050C730 File Offset: 0x0050A930
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IGraph3dNodeBaseVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGraph3dBaseVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGraph3dBaseVerify.<>O.<1>__Verify = new VerifyTableAction(IGraph3dEdgeBaseVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083A0 RID: 33696
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401460D RID: 83469
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401460E RID: 83470
			public static VerifyTableAction <1>__Verify;
		}
	}
}
