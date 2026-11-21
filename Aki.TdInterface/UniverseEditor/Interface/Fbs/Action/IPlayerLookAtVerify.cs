using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007479 RID: 29817
	public static class IPlayerLookAtVerify
	{
		// Token: 0x0603432E RID: 213806 RVA: 0x00707FC0 File Offset: 0x007061C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayerLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayerLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200867D RID: 34429
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A69 RID: 84585
			public static VerifyTableAction <0>__Verify;
		}
	}
}
