using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C60 RID: 19552
	public static class IOnlinePlayerConditionTargetVerify
	{
		// Token: 0x0601F006 RID: 126982 RVA: 0x00455CF6 File Offset: 0x00453EF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
