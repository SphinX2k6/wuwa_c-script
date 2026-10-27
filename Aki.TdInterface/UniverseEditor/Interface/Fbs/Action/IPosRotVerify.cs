using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6D RID: 28013
	public static class IPosRotVerify
	{
		// Token: 0x0603178B RID: 202635 RVA: 0x006B5014 File Offset: 0x006B3214
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

		// Token: 0x02007E00 RID: 32256
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139BB RID: 80315
			public static VerifyTableAction <0>__Verify;
		}
	}
}
