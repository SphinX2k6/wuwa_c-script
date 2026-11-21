using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007644 RID: 30276
	public static class IRestoreTrialCharacterVerify
	{
		// Token: 0x06035202 RID: 217602 RVA: 0x007222F6 File Offset: 0x007204F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
