using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBF RID: 28351
	public static class IFocusObjectVerify
	{
		// Token: 0x060310DA RID: 200922 RVA: 0x006A6F80 File Offset: 0x006A5180
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

		// Token: 0x020085F1 RID: 34289
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149AC RID: 84396
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149AD RID: 84397
			public static VerifyTableAction <1>__Verify;
		}
	}
}
