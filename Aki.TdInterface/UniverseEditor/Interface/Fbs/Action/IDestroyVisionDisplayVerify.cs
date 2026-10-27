using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065AE RID: 26030
	public static class IDestroyVisionDisplayVerify
	{
		// Token: 0x0602D272 RID: 184946 RVA: 0x00631162 File Offset: 0x0062F362
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
