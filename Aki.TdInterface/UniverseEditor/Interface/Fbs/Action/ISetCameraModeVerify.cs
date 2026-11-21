using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779F RID: 30623
	public static class ISetCameraModeVerify
	{
		// Token: 0x06035C16 RID: 220182 RVA: 0x00733B11 File Offset: 0x00731D11
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
