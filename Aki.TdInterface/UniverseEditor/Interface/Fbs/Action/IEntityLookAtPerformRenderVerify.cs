using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E6 RID: 26342
	public static class IEntityLookAtPerformRenderVerify
	{
		// Token: 0x0602DCD8 RID: 187608 RVA: 0x00643884 File Offset: 0x00641A84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityLookAtPerformRenderVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityLookAtPerformRenderVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityLookAtPerformRenderVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityLookAtPerformRenderVerify.<>O.<1>__Verify = new VerifyTableAction(ILookAtPerformOverlapMontageConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D55 RID: 32085
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D2 RID: 80082
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138D3 RID: 80083
			public static VerifyTableAction <1>__Verify;
		}
	}
}
