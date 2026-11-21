using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E8 RID: 29928
	public static class IPosRotVerify
	{
		// Token: 0x06034787 RID: 214919 RVA: 0x007106FC File Offset: 0x0070E8FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPosRotVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPosRotVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPosRotVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IPosRotVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200868C RID: 34444
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A7F RID: 84607
			public static VerifyTableAction <0>__Verify;
		}
	}
}
