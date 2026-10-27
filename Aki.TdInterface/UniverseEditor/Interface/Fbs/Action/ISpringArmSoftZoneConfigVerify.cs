using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A7 RID: 29095
	public static class ISpringArmSoftZoneConfigVerify
	{
		// Token: 0x06033965 RID: 211301 RVA: 0x006F27AC File Offset: 0x006F09AC
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

		// Token: 0x02007E6D RID: 32365
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A4C RID: 80460
			public static VerifyTableAction <0>__Verify;
		}
	}
}
