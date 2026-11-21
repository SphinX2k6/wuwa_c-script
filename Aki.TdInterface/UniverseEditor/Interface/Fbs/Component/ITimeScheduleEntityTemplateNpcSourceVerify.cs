using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A5 RID: 24741
	public static class ITimeScheduleEntityTemplateNpcSourceVerify
	{
		// Token: 0x06029DC7 RID: 171463 RVA: 0x005B6F47 File Offset: 0x005B5147
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
