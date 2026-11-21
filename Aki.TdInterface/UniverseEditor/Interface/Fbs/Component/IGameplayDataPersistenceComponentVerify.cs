using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586A RID: 22634
	public static class IGameplayDataPersistenceComponentVerify
	{
		// Token: 0x06024AF8 RID: 150264 RVA: 0x0050A1A0 File Offset: 0x005083A0
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

		// Token: 0x0200839A RID: 33690
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014606 RID: 83462
			public static VerifyTableAction <0>__Verify;
		}
	}
}
