using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E0B RID: 24075
	public static class IMotorAirCurrentConfigVerify
	{
		// Token: 0x06029373 RID: 168819 RVA: 0x005A75A4 File Offset: 0x005A57A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorAirCurrentConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorAirCurrentConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMotorAirCurrentConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMotorAirCurrentConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CAE RID: 31918
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137DB RID: 79835
			public static VerifyTableAction <0>__Verify;
		}
	}
}
