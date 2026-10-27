using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D6 RID: 21462
	public static class IHookLockScreenDetectTypeFullScreenVerify
	{
		// Token: 0x0602338A RID: 144266 RVA: 0x004E09BE File Offset: 0x004DEBBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
