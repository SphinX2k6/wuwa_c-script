using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F65 RID: 24421
	public static class ISpawnMonsterPointVerify
	{
		// Token: 0x060290E4 RID: 168164 RVA: 0x0059BAA0 File Offset: 0x00599CA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpawnMonsterPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnMonsterPointVerify.<>O.<0>__Verify = new VerifyTableAction(ISearchSpawnMonsterPointVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084A3 RID: 33955
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147C2 RID: 83906
			public static VerifyTableAction <0>__Verify;
		}
	}
}
