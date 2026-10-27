using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200534C RID: 21324
	public static class IGroupDestroyListenConfigVerify
	{
		// Token: 0x06022E25 RID: 142885 RVA: 0x004D5150 File Offset: 0x004D3350
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

		// Token: 0x02007B4E RID: 31566
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401359B RID: 79259
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401359C RID: 79260
			public static VerifyTableAction <1>__Verify;
		}
	}
}
