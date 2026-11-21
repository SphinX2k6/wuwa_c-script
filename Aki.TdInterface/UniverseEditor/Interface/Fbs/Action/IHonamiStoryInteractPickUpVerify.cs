using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDC RID: 28636
	public static class IHonamiStoryInteractPickUpVerify
	{
		// Token: 0x060319BF RID: 203199 RVA: 0x006B8986 File Offset: 0x006B6B86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
