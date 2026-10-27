using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007207 RID: 29191
	public static class ISubScreenCustomInitDataVerify
	{
		// Token: 0x06033C75 RID: 212085 RVA: 0x006F8138 File Offset: 0x006F6338
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubScreenCustomInitDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubScreenCustomInitDataVerify.<>O.<0>__Verify = new VerifyTableAction(ISubScreenConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E75 RID: 32373
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A59 RID: 80473
			public static VerifyTableAction <0>__Verify;
		}
	}
}
