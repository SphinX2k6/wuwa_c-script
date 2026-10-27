using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE4 RID: 23524
	public static class TAiGearStrategyVerify
	{
		// Token: 0x06028510 RID: 165136 RVA: 0x0058A110 File Offset: 0x00588310
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRenjuStrategyVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRaceStrategyVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
