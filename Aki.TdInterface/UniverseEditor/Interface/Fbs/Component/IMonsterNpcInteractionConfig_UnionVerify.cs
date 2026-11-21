using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B24 RID: 23332
	public static class IMonsterNpcInteractionConfig_UnionVerify
	{
		// Token: 0x060265F5 RID: 157173 RVA: 0x005419DC File Offset: 0x0053FBDC
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
