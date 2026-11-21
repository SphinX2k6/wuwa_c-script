using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2E RID: 27694
	public static class IDisableAlertAreaConditionVerify
	{
		// Token: 0x0602FA81 RID: 195201 RVA: 0x0067DF96 File Offset: 0x0067C196
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
