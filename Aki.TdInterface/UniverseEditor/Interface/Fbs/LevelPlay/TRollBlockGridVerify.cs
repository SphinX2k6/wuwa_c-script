using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004616 RID: 17942
	public static class TRollBlockGridVerify
	{
		// Token: 0x0601B2EA RID: 111338 RVA: 0x003DF1F8 File Offset: 0x003DD3F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockGridBreakTriggerVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlockGridEmptyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlockGridFallFloorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRollBlockGridFloorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRollBlockGridGoalVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRollBlockGridJumpFloorVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRollBlockGridLaserVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IRollBlockGridLinkGoalVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IRollBlockGridQuantumVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
