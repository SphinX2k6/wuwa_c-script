using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE7 RID: 19687
	public static class ITargetBuffContainerVerify
	{
		// Token: 0x0601F3F3 RID: 127987 RVA: 0x0045C5F2 File Offset: 0x0045A7F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
