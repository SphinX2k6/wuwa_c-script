using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB7 RID: 23479
	public static class INpcAwakeShowVerify
	{
		// Token: 0x06026B5A RID: 158554 RVA: 0x0054C768 File Offset: 0x0054A968
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcAwakeShowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcAwakeShowVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008409 RID: 33801
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146CD RID: 83661
			public static VerifyTableAction <0>__Verify;
		}
	}
}
