using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F14 RID: 28436
	public static class IRunActorCustomEventVerify
	{
		// Token: 0x060323D8 RID: 205784 RVA: 0x006C9910 File Offset: 0x006C7B10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunActorCustomEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunActorCustomEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E1F RID: 32287
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139DB RID: 80347
			public static VerifyTableAction <0>__Verify;
		}
	}
}
