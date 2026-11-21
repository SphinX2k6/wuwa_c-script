using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004630 RID: 17968
	public static class ITimeRangeVerify
	{
		// Token: 0x0601A4A3 RID: 107683 RVA: 0x003BDDAC File Offset: 0x003BBFAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IDateTimeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimeRangeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ITimeRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IDateTimeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020081B1 RID: 33201
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401432E RID: 82734
			public static VerifyTableAction <0>__Verify;
		}
	}
}
