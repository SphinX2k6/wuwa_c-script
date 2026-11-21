using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDB RID: 23515
	public static class INpcPerformStateVerify
	{
		// Token: 0x06026D3F RID: 159039 RVA: 0x00551338 File Offset: 0x0054F538
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcPerformStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcPerformStateVerify.<>O.<0>__Verify = new VerifyTableAction(IInitNpcPerformStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcPerformStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INpcPerformStateVerify.<>O.<1>__Verify = new VerifyTableAction(INpcPerformStateConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008411 RID: 33809
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146E1 RID: 83681
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146E2 RID: 83682
			public static VerifyTableAction <1>__Verify;
		}
	}
}
