using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC0 RID: 19904
	public static class ITurntableConnectorDiskSocketsBase_UnionVerify
	{
		// Token: 0x0601EE1C RID: 126492 RVA: 0x004508FC File Offset: 0x0044EAFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITurntableConnectorNormalDiskSocketsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITurntableConnectorDiskSocketsBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
