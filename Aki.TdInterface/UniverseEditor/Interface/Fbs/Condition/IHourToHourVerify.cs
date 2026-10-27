using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C42 RID: 19522
	public static class IHourToHourVerify
	{
		// Token: 0x0601EF18 RID: 126744 RVA: 0x0045428C File Offset: 0x0045248C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHourToHourVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHourToHourVerify.<>O.<0>__Verify = new VerifyTableAction(IHourVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHourToHourVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IHourToHourVerify.<>O.<0>__Verify = new VerifyTableAction(IHourVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A5F RID: 31327
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013427 RID: 78887
			public static VerifyTableAction <0>__Verify;
		}
	}
}
