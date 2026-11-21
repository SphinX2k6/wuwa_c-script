using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB4 RID: 19892
	public static class ITurntableConnectorAssetsBaseVerify
	{
		// Token: 0x0601EDDA RID: 126426 RVA: 0x00450366 File Offset: 0x0044E566
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
