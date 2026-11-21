using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA5 RID: 28069
	public static class IExitMovieCameraVerify
	{
		// Token: 0x06030731 RID: 198449 RVA: 0x00694F82 File Offset: 0x00693182
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
