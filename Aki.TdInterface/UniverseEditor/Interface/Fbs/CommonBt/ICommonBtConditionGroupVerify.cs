using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F0 RID: 25840
	public static class ICommonBtConditionGroupVerify
	{
		// Token: 0x0602BF0F RID: 179983 RVA: 0x005F9658 File Offset: 0x005F7858
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtConditionGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtConditionGroupVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtConditionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200852E RID: 34094
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014893 RID: 84115
			public static VerifyTableAction <0>__Verify;
		}
	}
}
