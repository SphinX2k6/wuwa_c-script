using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A93 RID: 27283
	public static class IMechStuntConfigType_UnionVerify
	{
		// Token: 0x0602FD05 RID: 195845 RVA: 0x006817B4 File Offset: 0x0067F9B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechStuntConfigTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechStuntDiveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechStuntClimbFlyVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMechStuntLevelFlyVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IMechStuntHighSpeedVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IMechStuntWaterVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IMechStuntBurrowVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
