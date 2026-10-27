using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D60 RID: 23904
	public static class IBvbRecycleBoardCardData_UnionVerify
	{
		// Token: 0x06028E51 RID: 167505 RVA: 0x0059E5C8 File Offset: 0x0059C7C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbRecycleBoardCardDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDiscardForEnergyToDeployTypeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDiscardForEnergyToEvolutionTypeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
