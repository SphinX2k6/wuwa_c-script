using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F3C RID: 16188
	public static class IWoodenBoxProliferateSpawnConfig_UnionVerify
	{
		// Token: 0x0601603C RID: 90172 RVA: 0x00329938 File Offset: 0x00327B38
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
