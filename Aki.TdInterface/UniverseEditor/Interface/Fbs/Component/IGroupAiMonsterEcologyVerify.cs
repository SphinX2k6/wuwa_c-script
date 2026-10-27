using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005340 RID: 21312
	public static class IGroupAiMonsterEcologyVerify
	{
		// Token: 0x06022DA1 RID: 142753 RVA: 0x004D40A4 File Offset: 0x004D22A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGroupAiMonsterEcologyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupAiMonsterEcologyVerify.<>O.<0>__Verify = new VerifyTableAction(IGroupAiMonsterMemberVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B4C RID: 31564
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013598 RID: 79256
			public static VerifyTableAction <0>__Verify;
		}
	}
}
