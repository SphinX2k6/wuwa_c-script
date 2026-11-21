using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061FA RID: 25082
	public static class TAiGearStrategyVerify
	{
		// Token: 0x0602AAD4 RID: 174804 RVA: 0x005D1BA0 File Offset: 0x005CFDA0
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
