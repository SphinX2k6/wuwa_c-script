using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F3E RID: 24382
	public static class ISlidePerformTypeVerify
	{
		// Token: 0x06028F7F RID: 167807 RVA: 0x00598E46 File Offset: 0x00597046
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
