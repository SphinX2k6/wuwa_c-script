using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200622D RID: 25133
	public static class TEntityBatchRefreshVerify
	{
		// Token: 0x0602ACB8 RID: 175288 RVA: 0x005D8570 File Offset: 0x005D6770
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
