using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E7 RID: 21223
	public static class IGameplayDataPersistenceComponentVerify
	{
		// Token: 0x06022A5E RID: 141918 RVA: 0x004CD674 File Offset: 0x004CB874
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGameplayDataPersistenceComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGameplayDataPersistenceComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IGameplayDataPersistenceTetrisBoardGameVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B3C RID: 31548
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013582 RID: 79234
			public static VerifyTableAction <0>__Verify;
		}
	}
}
