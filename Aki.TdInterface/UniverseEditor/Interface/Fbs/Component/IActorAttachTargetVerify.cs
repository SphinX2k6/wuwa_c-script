using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005366 RID: 21350
	public static class IActorAttachTargetVerify
	{
		// Token: 0x060213FC RID: 136188 RVA: 0x00496B48 File Offset: 0x00494D48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorAttachTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorAttachTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082C2 RID: 33474
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144AD RID: 83117
			public static VerifyTableAction <0>__Verify;
		}
	}
}
