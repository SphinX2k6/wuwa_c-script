using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006514 RID: 25876
	public static class ICommonBtTaskVerify
	{
		// Token: 0x0602C1CD RID: 180685 RVA: 0x006025E0 File Offset: 0x006007E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtTaskVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtTaskVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008531 RID: 34097
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014896 RID: 84118
			public static VerifyTableAction <0>__Verify;
		}
	}
}
