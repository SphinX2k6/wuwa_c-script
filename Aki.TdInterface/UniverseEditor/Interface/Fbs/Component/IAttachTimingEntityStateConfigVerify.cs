using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F0 RID: 21488
	public static class IAttachTimingEntityStateConfigVerify
	{
		// Token: 0x06021956 RID: 137558 RVA: 0x004A16A8 File Offset: 0x0049F8A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAttachTimingEntityStateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAttachTimingEntityStateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IAttachTimingLinkEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAttachTimingEntityStateConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAttachTimingEntityStateConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082D7 RID: 33495
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144C8 RID: 83144
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144C9 RID: 83145
			public static VerifyTableAction <1>__Verify;
		}
	}
}
