using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3F RID: 28223
	public static class IRemoveBuffFromPlayerVerify
	{
		// Token: 0x06031DFB RID: 204283 RVA: 0x006BFDA5 File Offset: 0x006BDFA5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
