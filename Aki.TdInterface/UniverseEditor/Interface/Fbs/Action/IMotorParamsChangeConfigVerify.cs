using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007257 RID: 29271
	public static class IMotorParamsChangeConfigVerify
	{
		// Token: 0x06033001 RID: 208897 RVA: 0x006E26DA File Offset: 0x006E08DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
