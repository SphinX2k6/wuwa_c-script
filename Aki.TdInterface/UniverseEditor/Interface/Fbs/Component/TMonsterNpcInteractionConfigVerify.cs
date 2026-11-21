using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200628D RID: 25229
	public static class TMonsterNpcInteractionConfigVerify
	{
		// Token: 0x0602AEB0 RID: 175792 RVA: 0x005DB514 File Offset: 0x005D9714
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMonsterNpcInteractionGazePerformVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMonsterNpcInteractionHookVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMonsterNpcInteractionSwordRidingVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMonsterNpcInteractionWallRunVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
