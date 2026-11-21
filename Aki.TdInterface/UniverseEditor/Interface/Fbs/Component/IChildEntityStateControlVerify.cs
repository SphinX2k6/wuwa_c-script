using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CB RID: 21707
	public static class IChildEntityStateControlVerify
	{
		// Token: 0x060223E2 RID: 140258 RVA: 0x004B8538 File Offset: 0x004B6738
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildEntityStateControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildEntityStateControlVerify.<>O.<0>__Verify = new VerifyTableAction(IChildStateChangedConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008303 RID: 33539
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401450F RID: 83215
			public static VerifyTableAction <0>__Verify;
		}
	}
}
