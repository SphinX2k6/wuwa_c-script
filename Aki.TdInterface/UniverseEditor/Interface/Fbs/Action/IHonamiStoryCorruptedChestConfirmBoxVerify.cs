using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691D RID: 26909
	public static class IHonamiStoryCorruptedChestConfirmBoxVerify
	{
		// Token: 0x0602EF9C RID: 192412 RVA: 0x00667CF4 File Offset: 0x00665EF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
