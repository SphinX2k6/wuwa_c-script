using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A00 RID: 23040
	public static class ISunSpiritGearPerformConfig_UnionVerify
	{
		// Token: 0x060271A3 RID: 160163 RVA: 0x005610BC File Offset: 0x0055F2BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISunSpiritGearPerformConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISunSpiritGearPerformToGearRelativePosVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISunSpiritGearPerformScaleUpVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
