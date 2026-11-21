using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A6 RID: 22694
	public static class IGraph3dNormalVerify
	{
		// Token: 0x06024D07 RID: 150791 RVA: 0x0050E178 File Offset: 0x0050C378
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dNormalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dNormalVerify.<>O.<0>__Verify = new VerifyTableAction(IGraph3dNodeBaseVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGraph3dNormalVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGraph3dNormalVerify.<>O.<1>__Verify = new VerifyTableAction(IGraph3dEdgeBaseVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083A5 RID: 33701
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014613 RID: 83475
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014614 RID: 83476
			public static VerifyTableAction <1>__Verify;
		}
	}
}
