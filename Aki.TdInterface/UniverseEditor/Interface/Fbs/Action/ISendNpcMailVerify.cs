using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F74 RID: 28532
	public static class ISendNpcMailVerify
	{
		// Token: 0x0603268A RID: 206474 RVA: 0x006CDF5E File Offset: 0x006CC15E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
