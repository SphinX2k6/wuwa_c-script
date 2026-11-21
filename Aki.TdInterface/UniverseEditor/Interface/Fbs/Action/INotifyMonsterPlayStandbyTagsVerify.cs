using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FD RID: 29437
	public static class INotifyMonsterPlayStandbyTagsVerify
	{
		// Token: 0x06033562 RID: 210274 RVA: 0x006EC6C8 File Offset: 0x006EA8C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INotifyMonsterPlayStandbyTagsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INotifyMonsterPlayStandbyTagsVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterStandByConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200864E RID: 34382
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A2A RID: 84522
			public static VerifyTableAction <0>__Verify;
		}
	}
}
