using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E82 RID: 20098
	public static class IAiGearStrategy_UnionVerify
	{
		// Token: 0x0601F98F RID: 129423 RVA: 0x00466B14 File Offset: 0x00464D14
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAiGearStrategyVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRenjuStrategyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRaceStrategyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
