using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064CF RID: 25807
	public static class TGoalActDataVerify
	{
		// Token: 0x0602BDE5 RID: 179685 RVA: 0x005F7138 File Offset: 0x005F5338
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
