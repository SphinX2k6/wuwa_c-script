using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006839 RID: 26681
	public static class IFocusObjectVerify
	{
		// Token: 0x0602E852 RID: 190546 RVA: 0x00659040 File Offset: 0x00657240
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFocusObjectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFocusObjectVerify.<>O.<0>__Verify = new VerifyTableAction(IFocusObjectRotationConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFocusObjectVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFocusObjectVerify.<>O.<1>__Verify = new VerifyTableAction(IFocusObjectCameraConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D7A RID: 32122
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138FF RID: 80127
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013900 RID: 80128
			public static VerifyTableAction <1>__Verify;
		}
	}
}
