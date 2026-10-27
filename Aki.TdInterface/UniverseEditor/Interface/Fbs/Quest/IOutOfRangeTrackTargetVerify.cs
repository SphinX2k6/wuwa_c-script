using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F6D RID: 16237
	public static class IOutOfRangeTrackTargetVerify
	{
		// Token: 0x060171AB RID: 94635 RVA: 0x0035454C File Offset: 0x0035274C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOutOfRangeTrackTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOutOfRangeTrackTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IOutOfRangeTrackTargetVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IOutOfRangeTrackTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007911 RID: 30993
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E7 RID: 78311
			public static VerifyTableAction <0>__Verify;
		}
	}
}
