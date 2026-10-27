using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728E RID: 29326
	public static class ITakePlotPhotoVerify
	{
		// Token: 0x06034085 RID: 213125 RVA: 0x006FEFAE File Offset: 0x006FD1AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
