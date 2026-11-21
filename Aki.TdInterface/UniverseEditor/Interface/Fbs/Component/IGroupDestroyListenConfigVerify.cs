using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D2 RID: 22738
	public static class IGroupDestroyListenConfigVerify
	{
		// Token: 0x06024ED9 RID: 151257 RVA: 0x00512024 File Offset: 0x00510224
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGroupDestroyListenConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupDestroyListenConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGroupDestroyListenConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGroupDestroyListenConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IChangeTemplateInstanceStateConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083AD RID: 33709
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014620 RID: 83488
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014621 RID: 83489
			public static VerifyTableAction <1>__Verify;
		}
	}
}
