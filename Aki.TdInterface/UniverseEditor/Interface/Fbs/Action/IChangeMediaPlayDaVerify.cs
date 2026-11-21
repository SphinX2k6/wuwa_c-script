using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697B RID: 27003
	public static class IChangeMediaPlayDaVerify
	{
		// Token: 0x0602E4FD RID: 189693 RVA: 0x00652C3C File Offset: 0x00650E3C
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

		// Token: 0x02008582 RID: 34178
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401491C RID: 84252
			public static VerifyTableAction <0>__Verify;
		}
	}
}
