using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006929 RID: 26921
	public static class IHonamiStoryInteractPickUpVerify
	{
		// Token: 0x0602EFEF RID: 192495 RVA: 0x0066849E File Offset: 0x0066669E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
