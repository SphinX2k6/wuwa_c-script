using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006671 RID: 26225
	public static class IEnableLevelPlayVerify
	{
		// Token: 0x0602D8FE RID: 186622 RVA: 0x0063CE54 File Offset: 0x0063B054
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEnableLevelPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnableLevelPlayVerify.<>O.<0>__Verify = new VerifyTableAction(IEnableLevelPlayConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D4D RID: 32077
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C8 RID: 80072
			public static VerifyTableAction <0>__Verify;
		}
	}
}
