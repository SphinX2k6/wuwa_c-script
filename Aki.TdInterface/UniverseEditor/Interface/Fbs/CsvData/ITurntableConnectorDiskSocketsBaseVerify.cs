using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DBD RID: 19901
	public static class ITurntableConnectorDiskSocketsBaseVerify
	{
		// Token: 0x0601EE10 RID: 126480 RVA: 0x0045080E File Offset: 0x0044EA0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
