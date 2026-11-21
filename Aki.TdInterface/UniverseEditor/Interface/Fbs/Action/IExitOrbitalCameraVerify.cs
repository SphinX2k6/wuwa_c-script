using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAB RID: 28075
	public static class IExitOrbitalCameraVerify
	{
		// Token: 0x06030760 RID: 198496 RVA: 0x00695592 File Offset: 0x00693792
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
