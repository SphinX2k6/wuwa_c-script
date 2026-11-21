using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079CA RID: 31178
	public static class IStopUiScreenEffectVerify
	{
		// Token: 0x06036EF5 RID: 225013 RVA: 0x00758745 File Offset: 0x00756945
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
