using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004651 RID: 18001
	public static class ITrackEffectTypeVerify
	{
		// Token: 0x0601A607 RID: 108039 RVA: 0x003C1232 File Offset: 0x003BF432
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
