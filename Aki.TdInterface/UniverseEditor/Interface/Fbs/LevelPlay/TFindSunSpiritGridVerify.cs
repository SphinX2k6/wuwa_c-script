using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004607 RID: 17927
	public static class TFindSunSpiritGridVerify
	{
		// Token: 0x0601B290 RID: 111248 RVA: 0x003DE938 File Offset: 0x003DCB38
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFindSunSpiritGridBeginFloorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFindSunSpiritGridEmptyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFindSunSpiritGridEndFloorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFindSunSpiritGridMutableFloorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFindSunSpiritGridNormalFloorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
