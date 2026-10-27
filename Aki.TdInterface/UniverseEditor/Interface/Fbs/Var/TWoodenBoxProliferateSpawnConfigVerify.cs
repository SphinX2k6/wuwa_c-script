using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B6A RID: 15210
	public static class TWoodenBoxProliferateSpawnConfigVerify
	{
		// Token: 0x06014CF0 RID: 85232 RVA: 0x00305ADC File Offset: 0x00303CDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWoodenBoxProliferateRandomInRangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWoodenBoxProliferatePositionListVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
