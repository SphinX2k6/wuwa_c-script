using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200630A RID: 25354
	public static class IChangeMediaPlayDaVerify
	{
		// Token: 0x0602BD94 RID: 179604 RVA: 0x00607C30 File Offset: 0x00605E30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChangeMediaPlayDaVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeMediaPlayDaVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D0F RID: 32015
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013873 RID: 79987
			public static VerifyTableAction <0>__Verify;
		}
	}
}
