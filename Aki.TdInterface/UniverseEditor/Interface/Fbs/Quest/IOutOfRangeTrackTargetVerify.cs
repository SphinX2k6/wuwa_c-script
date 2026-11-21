using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043AB RID: 17323
	public static class IOutOfRangeTrackTargetVerify
	{
		// Token: 0x0601880D RID: 100365 RVA: 0x0037D9C0 File Offset: 0x0037BBC0
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

		// Token: 0x02008157 RID: 33111
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014247 RID: 82503
			public static VerifyTableAction <0>__Verify;
		}
	}
}
