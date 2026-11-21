using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005393 RID: 21395
	public static class IAiGearStrategy_UnionVerify
	{
		// Token: 0x060215DA RID: 136666 RVA: 0x0049AB2C File Offset: 0x00498D2C
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
