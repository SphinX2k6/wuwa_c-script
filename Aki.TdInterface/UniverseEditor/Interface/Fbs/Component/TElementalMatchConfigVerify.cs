using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C08 RID: 23560
	public static class TElementalMatchConfigVerify
	{
		// Token: 0x060286AE RID: 165550 RVA: 0x005903E4 File Offset: 0x0058E5E4
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
