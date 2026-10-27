using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006725 RID: 26405
	public static class IExitMovieCameraVerify
	{
		// Token: 0x0602DEEB RID: 188139 RVA: 0x0064783E File Offset: 0x00645A3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
