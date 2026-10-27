using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B31 RID: 19249
	public static class ICheckSubLevelStateVerify
	{
		// Token: 0x0601E4A5 RID: 124069 RVA: 0x0043EB0C File Offset: 0x0043CD0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckSubLevelStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckSubLevelStateVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckSubLevelStateConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A4A RID: 31306
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013410 RID: 78864
			public static VerifyTableAction <0>__Verify;
		}
	}
}
