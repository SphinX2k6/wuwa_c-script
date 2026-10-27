using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004729 RID: 18217
	public static class ICameraDataVerify
	{
		// Token: 0x0601BFDA RID: 114650 RVA: 0x003F7740 File Offset: 0x003F5940
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

		// Token: 0x020079DD RID: 31197
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013384 RID: 78724
			public static VerifyTableAction <0>__Verify;
		}
	}
}
