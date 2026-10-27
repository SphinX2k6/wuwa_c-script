using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B3A RID: 15162
	public static class IWoodenBoxProliferateSpawnConfig_UnionVerify
	{
		// Token: 0x06014B92 RID: 84882 RVA: 0x003036A8 File Offset: 0x003018A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IWoodenBoxProliferateSpawnConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWoodenBoxProliferateRandomInRangeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWoodenBoxProliferatePositionListVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
