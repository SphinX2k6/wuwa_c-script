using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004538 RID: 17720
	public static class IOuterBullZoneVerify
	{
		// Token: 0x0601AA60 RID: 109152 RVA: 0x003CD6F2 File Offset: 0x003CB8F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
