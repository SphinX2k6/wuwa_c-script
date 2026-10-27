using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0E RID: 23566
	public static class TEntityBatchRefreshVerify
	{
		// Token: 0x060286C8 RID: 165576 RVA: 0x00590628 File Offset: 0x0058E828
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRandomBatchPoolRefreshVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRandomBatchRefreshVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISequenceBatchRefreshVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
