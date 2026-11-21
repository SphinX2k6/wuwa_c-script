using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2B RID: 27691
	public static class IDetectTriggerVerify
	{
		// Token: 0x0602FA6F RID: 195183 RVA: 0x0067DE2E File Offset: 0x0067C02E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
