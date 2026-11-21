using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F4 RID: 25588
	public static class IGiantAnimDataTypeVerify
	{
		// Token: 0x0602B78D RID: 178061 RVA: 0x005EC182 File Offset: 0x005EA382
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
