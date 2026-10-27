using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E97 RID: 20119
	public static class IAllKillConditionVerify
	{
		// Token: 0x0601FA8F RID: 129679 RVA: 0x00468AA6 File Offset: 0x00466CA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
