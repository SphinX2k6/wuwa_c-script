using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005299 RID: 21145
	public static class IFollowerShootVerify
	{
		// Token: 0x06022775 RID: 141173 RVA: 0x004C745C File Offset: 0x004C565C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowerShootVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowerShootVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFollowerShootVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFollowerShootVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFollowerShootVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IFollowerShootVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFollowerShootVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IFollowerShootVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007B2C RID: 31532
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013568 RID: 79208
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013569 RID: 79209
			public static VerifyTableAction <1>__Verify;
		}
	}
}
