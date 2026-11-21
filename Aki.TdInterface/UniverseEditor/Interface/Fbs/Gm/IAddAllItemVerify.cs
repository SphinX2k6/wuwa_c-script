using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A97 RID: 19095
	public static class IAddAllItemVerify
	{
		// Token: 0x0601CB37 RID: 117559 RVA: 0x0040BFF6 File Offset: 0x0040A1F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
