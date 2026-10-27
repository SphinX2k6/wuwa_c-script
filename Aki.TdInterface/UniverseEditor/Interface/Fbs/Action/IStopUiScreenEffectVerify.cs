using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F5 RID: 29173
	public static class IStopUiScreenEffectVerify
	{
		// Token: 0x06033BF3 RID: 211955 RVA: 0x006F73E5 File Offset: 0x006F55E5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
