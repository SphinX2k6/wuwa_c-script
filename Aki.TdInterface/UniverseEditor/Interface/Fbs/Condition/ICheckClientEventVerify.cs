using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A2 RID: 18850
	public static class ICheckClientEventVerify
	{
		// Token: 0x0601D689 RID: 120457 RVA: 0x00424F3C File Offset: 0x0042313C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckClientEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckClientEventVerify.<>O.<0>__Verify = new VerifyTableAction(ISelfClientEventVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A20 RID: 31264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E3 RID: 78819
			public static VerifyTableAction <0>__Verify;
		}
	}
}
