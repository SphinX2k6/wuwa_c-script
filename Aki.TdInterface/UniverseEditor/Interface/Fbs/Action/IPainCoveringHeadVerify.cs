using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5F RID: 27743
	public static class IPainCoveringHeadVerify
	{
		// Token: 0x06030E16 RID: 200214 RVA: 0x006A394E File Offset: 0x006A1B4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
