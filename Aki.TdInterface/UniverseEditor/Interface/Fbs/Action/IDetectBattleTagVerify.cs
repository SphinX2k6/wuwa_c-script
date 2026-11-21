using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C22 RID: 27682
	public static class IDetectBattleTagVerify
	{
		// Token: 0x0602FA44 RID: 195140 RVA: 0x0067DA74 File Offset: 0x0067BC74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDetectBattleTagVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDetectBattleTagVerify.<>O.<0>__Verify = new VerifyTableAction(IDetectBattleMonsterOnGroundVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085B6 RID: 34230
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401495F RID: 84319
			public static VerifyTableAction <0>__Verify;
		}
	}
}
