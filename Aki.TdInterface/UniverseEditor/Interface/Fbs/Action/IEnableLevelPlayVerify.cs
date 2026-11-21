using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE5 RID: 27877
	public static class IEnableLevelPlayVerify
	{
		// Token: 0x060300E7 RID: 196839 RVA: 0x00689BF0 File Offset: 0x00687DF0
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

		// Token: 0x020085C4 RID: 34244
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014974 RID: 84340
			public static VerifyTableAction <0>__Verify;
		}
	}
}
