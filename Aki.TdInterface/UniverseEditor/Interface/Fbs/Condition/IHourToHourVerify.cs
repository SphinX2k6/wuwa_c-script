using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005135 RID: 20789
	public static class IHourToHourVerify
	{
		// Token: 0x06020B1C RID: 133916 RVA: 0x00487B68 File Offset: 0x00485D68
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

		// Token: 0x020082B1 RID: 33457
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014497 RID: 83095
			public static VerifyTableAction <0>__Verify;
		}
	}
}
