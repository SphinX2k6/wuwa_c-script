using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E66 RID: 28262
	public static class IRemovePreloadResourcePhantomCharacterVerify
	{
		// Token: 0x06031F0F RID: 204559 RVA: 0x006C1A38 File Offset: 0x006BFC38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRemovePreloadResourcePhantomCharacterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemovePreloadResourcePhantomCharacterVerify.<>O.<0>__Verify = new VerifyTableAction(IDelayRemoveAfterSkillFinishVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E10 RID: 32272
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139CB RID: 80331
			public static VerifyTableAction <0>__Verify;
		}
	}
}
