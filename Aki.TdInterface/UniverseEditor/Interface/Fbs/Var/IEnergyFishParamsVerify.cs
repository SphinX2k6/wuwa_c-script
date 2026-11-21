using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E76 RID: 15990
	public static class IEnergyFishParamsVerify
	{
		// Token: 0x060158FD RID: 88317 RVA: 0x0031BBCC File Offset: 0x00319DCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEnergyFishParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnergyFishParamsVerify.<>O.<0>__Verify = new VerifyTableAction(IEnergyFishStateConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080BA RID: 32954
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014139 RID: 82233
			public static VerifyTableAction <0>__Verify;
		}
	}
}
