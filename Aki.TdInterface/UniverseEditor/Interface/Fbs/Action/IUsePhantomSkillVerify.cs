using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE5 RID: 31973
	public static class IUsePhantomSkillVerify
	{
		// Token: 0x06039B09 RID: 236297 RVA: 0x007C86F4 File Offset: 0x007C68F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUsePhantomSkillVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUsePhantomSkillVerify.<>O.<0>__Verify = new VerifyTableAction(ISkillBlackboardVectorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IUsePhantomSkillVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IUsePhantomSkillVerify.<>O.<0>__Verify = new VerifyTableAction(ISkillBlackboardVectorVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008756 RID: 34646
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CDF RID: 85215
			public static VerifyTableAction <0>__Verify;
		}
	}
}
