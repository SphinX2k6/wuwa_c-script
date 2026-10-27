using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005029 RID: 20521
	public static class IControlPointEventConfigVerify
	{
		// Token: 0x06020E0C RID: 134668 RVA: 0x00492740 File Offset: 0x00490940
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IControlPointEventConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IControlPointEventConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IControlPointEventConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IControlPointEventConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IControlPointEventConfigVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IControlPointEventConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IControlPointEventConfigVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IControlPointEventConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007ACA RID: 31434
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134C7 RID: 79047
			public static VerifyTableAction <0>__Verify;
		}
	}
}
