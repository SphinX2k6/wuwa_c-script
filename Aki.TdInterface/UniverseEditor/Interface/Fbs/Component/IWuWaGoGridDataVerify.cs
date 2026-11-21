using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C5 RID: 25029
	public static class IWuWaGoGridDataVerify
	{
		// Token: 0x0602A8EC RID: 174316 RVA: 0x005CDC48 File Offset: 0x005CBE48
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

		// Token: 0x020084F6 RID: 34038
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014855 RID: 84053
			public static VerifyTableAction <0>__Verify;
		}
	}
}
