using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA3 RID: 20131
	public static class IAngularVelocityConfigVerify
	{
		// Token: 0x0601FAFF RID: 129791 RVA: 0x00469874 File Offset: 0x00467A74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAngularVelocityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAngularVelocityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRangedRandomVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAngularVelocityConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAngularVelocityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRangedRandomVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAngularVelocityConfigVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IAngularVelocityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRangedRandomVerify.Verify));
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

		// Token: 0x02007A7E RID: 31358
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401344E RID: 78926
			public static VerifyTableAction <0>__Verify;
		}
	}
}
