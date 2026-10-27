using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043BB RID: 17339
	public static class IOccupationType_UnionVerify
	{
		// Token: 0x06019D8D RID: 105869 RVA: 0x003B31B8 File Offset: 0x003B13B8
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
