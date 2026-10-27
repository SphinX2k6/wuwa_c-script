using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8C RID: 28556
	public static class IServerForceEnableLevelPlayVerify
	{
		// Token: 0x0603276F RID: 206703 RVA: 0x006CFDD9 File Offset: 0x006CDFD9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IServerForceEnableLevelPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IServerForceEnableLevelPlayVerify.<>O.<0>__Verify = new VerifyTableAction(IEnableLevelPlayConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E2B RID: 32299
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E8 RID: 80360
			public static VerifyTableAction <0>__Verify;
		}
	}
}
