using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B91 RID: 19345
	public static class ICameraDataVerify
	{
		// Token: 0x0601D7AF RID: 120751 RVA: 0x004239DC File Offset: 0x00421BDC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICameraDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICameraDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008226 RID: 33318
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143EB RID: 82923
			public static VerifyTableAction <0>__Verify;
		}
	}
}
