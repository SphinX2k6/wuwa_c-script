using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAF RID: 23471
	public static class IWuWaGoGridDataVerify
	{
		// Token: 0x06028328 RID: 164648 RVA: 0x005861B8 File Offset: 0x005843B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoGridDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoGridDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWuWaGoGridDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWuWaGoGridDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 2UL, 1UL, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IWuWaGoGridDataVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IWuWaGoGridDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C85 RID: 31877
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137AF RID: 79791
			public static VerifyTableAction <0>__Verify;
		}
	}
}
