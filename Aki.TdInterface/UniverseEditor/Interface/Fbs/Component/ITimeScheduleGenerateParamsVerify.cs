using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B1 RID: 24753
	public static class ITimeScheduleGenerateParamsVerify
	{
		// Token: 0x06029E2D RID: 171565 RVA: 0x005B7CB2 File Offset: 0x005B5EB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
