using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B19 RID: 19225
	public static class ICheckRogueStateTypeVerify
	{
		// Token: 0x0601E3D7 RID: 123863 RVA: 0x0043D3F6 File Offset: 0x0043B5F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
