using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005302 RID: 21250
	public static class IGraph3dBaseVerify
	{
		// Token: 0x06022B6B RID: 142187 RVA: 0x004CF85C File Offset: 0x004CDA5C
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

		// Token: 0x02007B41 RID: 31553
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013588 RID: 79240
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013589 RID: 79241
			public static VerifyTableAction <1>__Verify;
		}
	}
}
