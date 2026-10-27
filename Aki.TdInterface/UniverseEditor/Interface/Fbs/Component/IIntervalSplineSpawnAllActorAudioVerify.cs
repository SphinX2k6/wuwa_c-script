using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005487 RID: 21639
	public static class IIntervalSplineSpawnAllActorAudioVerify
	{
		// Token: 0x060239CC RID: 145868 RVA: 0x004EC9F0 File Offset: 0x004EABF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IIntervalSplineSpawnAllActorAudioVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IIntervalSplineSpawnAllActorAudioVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B72 RID: 31602
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135E3 RID: 79331
			public static VerifyTableAction <0>__Verify;
		}
	}
}
