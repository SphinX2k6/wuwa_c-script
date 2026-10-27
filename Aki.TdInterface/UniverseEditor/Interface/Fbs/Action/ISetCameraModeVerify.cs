using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD6 RID: 28630
	public static class ISetCameraModeVerify
	{
		// Token: 0x060329B0 RID: 207280 RVA: 0x006D3ECD File Offset: 0x006D20CD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
