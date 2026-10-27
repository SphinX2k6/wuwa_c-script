using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB6 RID: 23734
	public static class TSunSpiritGearPerformConfigVerify
	{
		// Token: 0x06028A24 RID: 166436 RVA: 0x005956B4 File Offset: 0x005938B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISunSpiritGearPerformToGearRelativePosVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISunSpiritGearPerformScaleUpVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
