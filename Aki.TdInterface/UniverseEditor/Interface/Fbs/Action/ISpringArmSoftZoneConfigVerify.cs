using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200797C RID: 31100
	public static class ISpringArmSoftZoneConfigVerify
	{
		// Token: 0x06036C63 RID: 224355 RVA: 0x00753A78 File Offset: 0x00751C78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpringArmSoftZoneConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpringArmSoftZoneConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISingleAxisSpringArmSoftZoneConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISpringArmSoftZoneConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISpringArmSoftZoneConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISingleAxisSpringArmSoftZoneConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISpringArmSoftZoneConfigVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ISpringArmSoftZoneConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISingleAxisSpringArmSoftZoneConfigVerify.Verify));
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

		// Token: 0x02008704 RID: 34564
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B23 RID: 84771
			public static VerifyTableAction <0>__Verify;
		}
	}
}
