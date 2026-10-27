using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C65 RID: 23653
	public static class TMonsterNpcInteractionConfigVerify
	{
		// Token: 0x06028894 RID: 166036 RVA: 0x005931B0 File Offset: 0x005913B0
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
