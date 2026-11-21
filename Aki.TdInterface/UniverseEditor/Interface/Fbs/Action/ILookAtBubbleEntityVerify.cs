using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717A RID: 29050
	public static class ILookAtBubbleEntityVerify
	{
		// Token: 0x060327DF RID: 206815 RVA: 0x006D2F14 File Offset: 0x006D1114
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILookAtBubbleEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILookAtBubbleEntityVerify.<>O.<0>__Verify = new VerifyTableAction(ILookAtBubbleEntityConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008621 RID: 34337
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149EF RID: 84463
			public static VerifyTableAction <0>__Verify;
		}
	}
}
