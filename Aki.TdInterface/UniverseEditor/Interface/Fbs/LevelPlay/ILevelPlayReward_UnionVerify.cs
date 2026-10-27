using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200451A RID: 17690
	public static class ILevelPlayReward_UnionVerify
	{
		// Token: 0x0601A958 RID: 108888 RVA: 0x003CBAF0 File Offset: 0x003C9CF0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILevelPlayRewardVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INoneRewardParamVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAutomaticRewardParamVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVariableRewardParamVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IInteractRewardParamVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
