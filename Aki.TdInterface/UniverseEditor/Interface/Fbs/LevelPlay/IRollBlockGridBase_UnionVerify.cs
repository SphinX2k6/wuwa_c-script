using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004562 RID: 17762
	public static class IRollBlockGridBase_UnionVerify
	{
		// Token: 0x0601AC0E RID: 109582 RVA: 0x003D0BFC File Offset: 0x003CEDFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockGridBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlockGridEmptyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlockGridFloorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRollBlockGridGoalVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRollBlockGridLinkGoalVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRollBlockGridJumpFloorVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRollBlockGridFallFloorVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IRollBlockGridBreakTriggerVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IRollBlockGridQuantumVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IRollBlockGridLaserVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
