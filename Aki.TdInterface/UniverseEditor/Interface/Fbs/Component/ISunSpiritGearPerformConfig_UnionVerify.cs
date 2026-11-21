using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200600D RID: 24589
	public static class ISunSpiritGearPerformConfig_UnionVerify
	{
		// Token: 0x0602971B RID: 169755 RVA: 0x005A8080 File Offset: 0x005A6280
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
