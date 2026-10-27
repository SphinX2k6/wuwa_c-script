using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AC RID: 26540
	public static class IFinishStateVerify
	{
		// Token: 0x0602E2F0 RID: 189168 RVA: 0x0064EA52 File Offset: 0x0064CC52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
