using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0D RID: 23053
	public static class IIntervalSplineSpawnAllActorAudioVerify
	{
		// Token: 0x06025A84 RID: 154244 RVA: 0x00529A64 File Offset: 0x00527C64
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

		// Token: 0x020083D1 RID: 33745
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014669 RID: 83561
			public static VerifyTableAction <0>__Verify;
		}
	}
}
