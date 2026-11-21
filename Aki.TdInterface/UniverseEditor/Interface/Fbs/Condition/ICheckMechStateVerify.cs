using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F9A RID: 20378
	public static class ICheckMechStateVerify
	{
		// Token: 0x0601FBF4 RID: 130036 RVA: 0x00469594 File Offset: 0x00467794
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckMechStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckMechStateVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckPlayerInMechVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200828E RID: 33422
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014470 RID: 83056
			public static VerifyTableAction <0>__Verify;
		}
	}
}
