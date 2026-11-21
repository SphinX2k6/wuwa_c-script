using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769B RID: 30363
	public static class IRunActorCustomEventVerify
	{
		// Token: 0x06035430 RID: 218160 RVA: 0x00725878 File Offset: 0x00723A78
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

		// Token: 0x020086AB RID: 34475
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A9F RID: 84639
			public static VerifyTableAction <0>__Verify;
		}
	}
}
