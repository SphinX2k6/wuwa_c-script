using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005664 RID: 22116
	public static class INpcStandbyShowModeVerify
	{
		// Token: 0x06024C94 RID: 150676 RVA: 0x005135D4 File Offset: 0x005117D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcStandbyShowModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcStandbyShowModeVerify.<>O.<0>__Verify = new VerifyTableAction(INpcLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BB3 RID: 31667
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401365B RID: 79451
			public static VerifyTableAction <0>__Verify;
		}
	}
}
