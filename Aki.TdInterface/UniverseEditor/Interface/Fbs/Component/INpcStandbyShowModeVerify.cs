using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C05 RID: 23557
	public static class INpcStandbyShowModeVerify
	{
		// Token: 0x06026ECD RID: 159437 RVA: 0x00554170 File Offset: 0x00552370
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

		// Token: 0x02008415 RID: 33813
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146EA RID: 83690
			public static VerifyTableAction <0>__Verify;
		}
	}
}
