using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A63 RID: 31331
	public static class ITakePlotPhotoVerify
	{
		// Token: 0x06037389 RID: 226185 RVA: 0x0076034A File Offset: 0x0075E54A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
