using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD5 RID: 31445
	public static class ITalkItemStyleVerify
	{
		// Token: 0x060382F1 RID: 230129 RVA: 0x0078FB1A File Offset: 0x0078DD1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
