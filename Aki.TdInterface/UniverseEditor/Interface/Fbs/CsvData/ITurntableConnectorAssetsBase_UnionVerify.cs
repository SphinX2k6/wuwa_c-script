using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB7 RID: 19895
	public static class ITurntableConnectorAssetsBase_UnionVerify
	{
		// Token: 0x0601EDE6 RID: 126438 RVA: 0x00450454 File Offset: 0x0044E654
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICircuitConnectAssetsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITurntableConnectorAssetsBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
