using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E7 RID: 30183
	public static class IRemovePreloadResourcePhantomCharacterVerify
	{
		// Token: 0x06034F37 RID: 216887 RVA: 0x0071D538 File Offset: 0x0071B738
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

		// Token: 0x0200869C RID: 34460
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A8F RID: 84623
			public static VerifyTableAction <0>__Verify;
		}
	}
}
