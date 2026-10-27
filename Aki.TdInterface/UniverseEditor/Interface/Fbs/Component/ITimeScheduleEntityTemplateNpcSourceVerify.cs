using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9E RID: 23198
	public static class ITimeScheduleEntityTemplateNpcSourceVerify
	{
		// Token: 0x0602786D RID: 161901 RVA: 0x005701AF File Offset: 0x0056E3AF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
