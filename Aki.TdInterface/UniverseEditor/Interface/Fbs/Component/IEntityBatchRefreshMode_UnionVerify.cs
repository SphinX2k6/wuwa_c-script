using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C6 RID: 22214
	public static class IEntityBatchRefreshMode_UnionVerify
	{
		// Token: 0x0602398F RID: 145807 RVA: 0x004E5260 File Offset: 0x004E3460
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
