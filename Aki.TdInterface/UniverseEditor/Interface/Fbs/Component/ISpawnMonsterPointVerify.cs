using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005958 RID: 22872
	public static class ISpawnMonsterPointVerify
	{
		// Token: 0x06026B7A RID: 158586 RVA: 0x00554E34 File Offset: 0x00553034
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

		// Token: 0x02007C34 RID: 31796
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013720 RID: 79648
			public static VerifyTableAction <0>__Verify;
		}
	}
}
