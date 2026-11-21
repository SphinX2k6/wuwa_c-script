using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200639D RID: 25501
	public static class IBvbStartAiDataVerify
	{
		// Token: 0x0602B4DF RID: 177375 RVA: 0x005E734A File Offset: 0x005E554A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
