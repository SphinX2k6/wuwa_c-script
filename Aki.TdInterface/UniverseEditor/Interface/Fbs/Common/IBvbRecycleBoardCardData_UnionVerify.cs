using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006397 RID: 25495
	public static class IBvbRecycleBoardCardData_UnionVerify
	{
		// Token: 0x0602B4BB RID: 177339 RVA: 0x005E7038 File Offset: 0x005E5238
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
