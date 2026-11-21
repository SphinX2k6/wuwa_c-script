using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E23 RID: 28195
	public static class IFinishConditionVerify
	{
		// Token: 0x06030B0A RID: 199434 RVA: 0x0069BE4A File Offset: 0x0069A04A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
