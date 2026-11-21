using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F35 RID: 32565
	public static class TMechStuntConfigVerify
	{
		// Token: 0x0603ABD4 RID: 240596 RVA: 0x007E5FB4 File Offset: 0x007E41B4
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
