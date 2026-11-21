using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A9A RID: 19098
	public static class IAddAllPhantomVerify
	{
		// Token: 0x0601CB49 RID: 117577 RVA: 0x0040C16E File Offset: 0x0040A36E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
