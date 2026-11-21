using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C0 RID: 24768
	public static class ITimeScheduleRefreshPositionVerify
	{
		// Token: 0x06029E7F RID: 171647 RVA: 0x005B83BA File Offset: 0x005B65BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
