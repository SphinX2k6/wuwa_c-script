using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E0 RID: 21984
	public static class IMovementPointHookVerify
	{
		// Token: 0x06024784 RID: 149380 RVA: 0x00508D24 File Offset: 0x00506F24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMovementPointHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMovementPointHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMovementPointHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMovementPointHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMovementPointHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IMovementPointHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMovementPointHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IMovementPointHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x02007B9F RID: 31647
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013634 RID: 79412
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013635 RID: 79413
			public static VerifyTableAction <1>__Verify;
		}
	}
}
