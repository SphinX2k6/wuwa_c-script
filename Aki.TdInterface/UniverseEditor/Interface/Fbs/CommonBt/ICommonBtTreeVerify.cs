using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200651A RID: 25882
	public static class ICommonBtTreeVerify
	{
		// Token: 0x0602C201 RID: 180737 RVA: 0x00602BD8 File Offset: 0x00600DD8
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

		// Token: 0x02008532 RID: 34098
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014897 RID: 84119
			public static VerifyTableAction <0>__Verify;
		}
	}
}
