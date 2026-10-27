using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005320 RID: 21280
	public static class IGraph3dNormalVerify
	{
		// Token: 0x06022C53 RID: 142419 RVA: 0x004D12A4 File Offset: 0x004CF4A4
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

		// Token: 0x02007B46 RID: 31558
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401358E RID: 79246
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401358F RID: 79247
			public static VerifyTableAction <1>__Verify;
		}
	}
}
