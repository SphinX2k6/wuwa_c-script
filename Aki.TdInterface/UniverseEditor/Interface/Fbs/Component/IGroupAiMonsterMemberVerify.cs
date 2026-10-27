using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005343 RID: 21315
	public static class IGroupAiMonsterMemberVerify
	{
		// Token: 0x06022DBB RID: 142779 RVA: 0x004D4424 File Offset: 0x004D2624
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGroupAiMonsterMemberVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupAiMonsterMemberVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGroupAiMonsterMemberVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGroupAiMonsterMemberVerify.<>O.<1>__Verify = new VerifyTableAction(IGroupAiMonsterMemberActionTagAttachVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B4D RID: 31565
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013599 RID: 79257
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401359A RID: 79258
			public static VerifyTableAction <1>__Verify;
		}
	}
}
