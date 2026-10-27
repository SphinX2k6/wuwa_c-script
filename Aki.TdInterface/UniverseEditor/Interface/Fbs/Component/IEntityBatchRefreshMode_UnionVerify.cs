using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005161 RID: 20833
	public static class IEntityBatchRefreshMode_UnionVerify
	{
		// Token: 0x06021A3B RID: 137787 RVA: 0x004AB2D4 File Offset: 0x004A94D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityBatchRefreshModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISequenceBatchRefreshVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRandomBatchRefreshVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRandomBatchPoolRefreshVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
