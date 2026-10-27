using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AAD RID: 19117
	public static class ICheckItemsVerify
	{
		// Token: 0x0601E013 RID: 122899 RVA: 0x00436320 File Offset: 0x00434520
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckItemsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckItemsVerify.<>O.<0>__Verify = new VerifyTableAction(IItemConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A3B RID: 31291
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133FF RID: 78847
			public static VerifyTableAction <0>__Verify;
		}
	}
}
