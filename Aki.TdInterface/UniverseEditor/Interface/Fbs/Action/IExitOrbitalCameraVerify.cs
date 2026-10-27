using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672B RID: 26411
	public static class IExitOrbitalCameraVerify
	{
		// Token: 0x0602DF1A RID: 188186 RVA: 0x00647E4E File Offset: 0x0064604E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
