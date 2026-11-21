using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F10 RID: 28432
	public static class IGamepadShakeConfigVerify
	{
		// Token: 0x06031340 RID: 201536 RVA: 0x006AAEC2 File Offset: 0x006A90C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
