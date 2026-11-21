using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200481D RID: 18461
	public static class IOccupationType_UnionVerify
	{
		// Token: 0x0601B528 RID: 111912 RVA: 0x003DEE40 File Offset: 0x003DD040
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOccupationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAreaOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISilentAreaOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IScreenResourceOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITimeOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IClosedSegmentOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ISeasonRotationOccupationDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
