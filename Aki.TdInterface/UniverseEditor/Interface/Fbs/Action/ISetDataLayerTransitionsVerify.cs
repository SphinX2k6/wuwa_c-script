using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD9 RID: 28633
	public static class ISetDataLayerTransitionsVerify
	{
		// Token: 0x060329DA RID: 207322 RVA: 0x006D4384 File Offset: 0x006D2584
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetDataLayerTransitionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetDataLayerTransitionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E36 RID: 32310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F5 RID: 80373
			public static VerifyTableAction <0>__Verify;
		}
	}
}
