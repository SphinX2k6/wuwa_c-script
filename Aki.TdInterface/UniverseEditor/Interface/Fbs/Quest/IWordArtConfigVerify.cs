using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046FC RID: 18172
	public static class IWordArtConfigVerify
	{
		// Token: 0x0601ABC8 RID: 109512 RVA: 0x003CC90C File Offset: 0x003CAB0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWordArtConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWordArtConfigVerify.<>O.<0>__Verify = new VerifyTableAction(INumberWordArtEffectiveTargetTypeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWordArtConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWordArtConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IWordArtDefaultResourceTypeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020081CC RID: 33228
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014366 RID: 82790
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014367 RID: 82791
			public static VerifyTableAction <1>__Verify;
		}
	}
}
