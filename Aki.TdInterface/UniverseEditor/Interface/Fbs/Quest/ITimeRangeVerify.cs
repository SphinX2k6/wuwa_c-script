using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D7 RID: 16855
	public static class ITimeRangeVerify
	{
		// Token: 0x06018D4D RID: 101709 RVA: 0x00392958 File Offset: 0x00390B58
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

		// Token: 0x02007968 RID: 31080
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132C8 RID: 78536
			public static VerifyTableAction <0>__Verify;
		}
	}
}
