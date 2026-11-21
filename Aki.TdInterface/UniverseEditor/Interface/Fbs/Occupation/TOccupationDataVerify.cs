using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004839 RID: 18489
	public static class TOccupationDataVerify
	{
		// Token: 0x0601B614 RID: 112148 RVA: 0x003E093C File Offset: 0x003DEB3C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAreaOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClosedSegmentOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IScreenResourceOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISeasonRotationOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISilentAreaOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ITimeOccupationDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
