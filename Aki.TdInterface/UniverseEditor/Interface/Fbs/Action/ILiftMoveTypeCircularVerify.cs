using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B4 RID: 28852
	public static class ILiftMoveTypeCircularVerify
	{
		// Token: 0x0603219A RID: 205210 RVA: 0x006C7D86 File Offset: 0x006C5F86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
