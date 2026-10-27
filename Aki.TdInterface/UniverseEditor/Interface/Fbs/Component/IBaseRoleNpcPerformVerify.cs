using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EEE RID: 20206
	public static class IBaseRoleNpcPerformVerify
	{
		// Token: 0x0601FE5C RID: 130652 RVA: 0x0047060E File Offset: 0x0046E80E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
