using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C9 RID: 22729
	public static class IGroupAiMonsterMemberVerify
	{
		// Token: 0x06024E6F RID: 151151 RVA: 0x005112F8 File Offset: 0x0050F4F8
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

		// Token: 0x020083AC RID: 33708
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401461E RID: 83486
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401461F RID: 83487
			public static VerifyTableAction <1>__Verify;
		}
	}
}
