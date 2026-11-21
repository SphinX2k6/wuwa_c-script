using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004546 RID: 17734
	public static class ISavePointVerify
	{
		// Token: 0x06019AF1 RID: 105201 RVA: 0x003A825C File Offset: 0x003A645C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISavePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISavePointVerify.<>O.<0>__Verify = new VerifyTableAction(IPositionRollbackConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008197 RID: 33175
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142D6 RID: 82646
			public static VerifyTableAction <0>__Verify;
		}
	}
}
