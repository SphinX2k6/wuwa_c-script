using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007183 RID: 29059
	public static class ILookAtTargetVerify
	{
		// Token: 0x06032837 RID: 206903 RVA: 0x006D39A0 File Offset: 0x006D1BA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILookAtTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILookAtTargetVerify.<>O.<0>__Verify = new VerifyTableAction(INpcLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008623 RID: 34339
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149F1 RID: 84465
			public static VerifyTableAction <0>__Verify;
		}
	}
}
