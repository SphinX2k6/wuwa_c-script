using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007712 RID: 30482
	public static class TMechStuntConfigVerify
	{
		// Token: 0x060376B7 RID: 226999 RVA: 0x007812FC File Offset: 0x0077F4FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechStuntBurrowVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechStuntClimbFlyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechStuntDiveVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMechStuntHighSpeedVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IMechStuntLevelFlyVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IMechStuntWaterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
