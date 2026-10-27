using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E8C RID: 24204
	public static class TGoalActDataVerify
	{
		// Token: 0x0602973D RID: 169789 RVA: 0x005AE194 File Offset: 0x005AC394
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDiscardForEnergyToEvolutionTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDiscardForEnergyToDeployTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
