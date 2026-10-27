using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005586 RID: 21894
	public static class IMonsterNpcInteractionConfig_UnionVerify
	{
		// Token: 0x060243E8 RID: 148456 RVA: 0x00501464 File Offset: 0x004FF664
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMonsterNpcInteractionConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMonsterNpcInteractionWallRunVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMonsterNpcInteractionHookVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMonsterNpcInteractionSwordRidingVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IMonsterNpcInteractionGazePerformVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
