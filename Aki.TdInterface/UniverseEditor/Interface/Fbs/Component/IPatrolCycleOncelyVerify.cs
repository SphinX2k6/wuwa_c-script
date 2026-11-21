using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CFB RID: 23803
	public static class IPatrolCycleOncelyVerify
	{
		// Token: 0x06027889 RID: 161929 RVA: 0x00568B92 File Offset: 0x00566D92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
