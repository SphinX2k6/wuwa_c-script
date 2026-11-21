using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006227 RID: 25127
	public static class TElementalMatchConfigVerify
	{
		// Token: 0x0602AC9E RID: 175262 RVA: 0x005D832C File Offset: 0x005D652C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFireElementalMatchVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWaterElementalMatchVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWoodElementalMatchVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
