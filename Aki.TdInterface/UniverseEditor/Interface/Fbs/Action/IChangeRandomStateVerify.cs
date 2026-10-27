using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200631C RID: 25372
	public static class IChangeRandomStateVerify
	{
		// Token: 0x0602BE30 RID: 179760 RVA: 0x00608C5D File Offset: 0x00606E5D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
