using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561B RID: 22043
	public static class IDragActorPlayComponentVerify
	{
		// Token: 0x06023294 RID: 144020 RVA: 0x004D6D58 File Offset: 0x004D4F58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDragActorPlayComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDragActorPlayComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDragActorPlayConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008337 RID: 33591
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014568 RID: 83304
			public static VerifyTableAction <0>__Verify;
		}
	}
}
