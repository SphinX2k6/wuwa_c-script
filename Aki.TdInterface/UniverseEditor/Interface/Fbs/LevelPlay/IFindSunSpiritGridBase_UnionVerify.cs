using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200491C RID: 18716
	public static class IFindSunSpiritGridBase_UnionVerify
	{
		// Token: 0x0601BC2C RID: 113708 RVA: 0x003ECB8C File Offset: 0x003EAD8C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFindSunSpiritGridBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFindSunSpiritGridEmptyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFindSunSpiritGridNormalFloorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFindSunSpiritGridMutableFloorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFindSunSpiritGridBeginFloorVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFindSunSpiritGridEndFloorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
