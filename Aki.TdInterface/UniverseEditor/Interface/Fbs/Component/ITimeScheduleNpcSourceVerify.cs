using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B7 RID: 24759
	public static class ITimeScheduleNpcSourceVerify
	{
		// Token: 0x06029E4B RID: 171595 RVA: 0x005B7F26 File Offset: 0x005B6126
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
