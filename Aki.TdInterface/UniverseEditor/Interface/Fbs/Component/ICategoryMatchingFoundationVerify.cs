using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F6C RID: 20332
	public static class ICategoryMatchingFoundationVerify
	{
		// Token: 0x0602040C RID: 132108 RVA: 0x0047CE50 File Offset: 0x0047B050
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AA3 RID: 31395
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401348B RID: 78987
			public static VerifyTableAction <0>__Verify;
		}
	}
}
