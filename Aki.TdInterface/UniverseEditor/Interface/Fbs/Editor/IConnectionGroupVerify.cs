using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004840 RID: 18496
	public static class IConnectionGroupVerify
	{
		// Token: 0x0601C996 RID: 117142 RVA: 0x0040AF2C File Offset: 0x0040912C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConnectionGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConnectionGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectionIpEndPointVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConnectionGroupVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConnectionGroupVerify.<>O.<1>__Verify = new VerifyTableAction(IGameServerConnectionConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A0A RID: 31242
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133BA RID: 78778
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133BB RID: 78779
			public static VerifyTableAction <1>__Verify;
		}
	}
}
