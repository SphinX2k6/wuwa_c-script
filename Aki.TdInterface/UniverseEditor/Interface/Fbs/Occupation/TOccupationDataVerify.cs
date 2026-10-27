using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043D4 RID: 17364
	public static class TOccupationDataVerify
	{
		// Token: 0x06019E65 RID: 106085 RVA: 0x003B4AFC File Offset: 0x003B2CFC
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
				result = ISilentAreaOccupationDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
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
