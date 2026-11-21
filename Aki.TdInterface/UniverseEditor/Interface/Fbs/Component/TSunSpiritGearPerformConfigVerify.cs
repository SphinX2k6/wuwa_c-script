using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E7 RID: 25319
	public static class TSunSpiritGearPerformConfigVerify
	{
		// Token: 0x0602B06C RID: 176236 RVA: 0x005DDE28 File Offset: 0x005DC028
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
