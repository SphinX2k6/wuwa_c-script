using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED7 RID: 24279
	public static class ICommonBtTreeVerify
	{
		// Token: 0x06029B4D RID: 170829 RVA: 0x005B96F4 File Offset: 0x005B78F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtTreeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtTreeVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtStartVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CC1 RID: 31937
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F1 RID: 79857
			public static VerifyTableAction <0>__Verify;
		}
	}
}
