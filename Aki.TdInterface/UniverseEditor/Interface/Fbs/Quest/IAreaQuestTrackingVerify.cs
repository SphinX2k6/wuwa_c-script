using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D12 RID: 15634
	public static class IAreaQuestTrackingVerify
	{
		// Token: 0x06015922 RID: 88354 RVA: 0x0031D965 File Offset: 0x0031BB65
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
