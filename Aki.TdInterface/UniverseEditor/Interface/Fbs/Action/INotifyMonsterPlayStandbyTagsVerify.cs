using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB1 RID: 27569
	public static class INotifyMonsterPlayStandbyTagsVerify
	{
		// Token: 0x060306E8 RID: 198376 RVA: 0x00693D28 File Offset: 0x00691F28
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

		// Token: 0x02007DC6 RID: 32198
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401396A RID: 80234
			public static VerifyTableAction <0>__Verify;
		}
	}
}
