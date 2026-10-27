using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004768 RID: 18280
	public static class IPerformanceModeSettingVerify
	{
		// Token: 0x0601C248 RID: 115272 RVA: 0x003FC946 File Offset: 0x003FAB46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
