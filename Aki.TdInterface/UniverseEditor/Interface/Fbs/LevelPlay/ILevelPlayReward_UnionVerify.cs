using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004982 RID: 18818
	public static class ILevelPlayReward_UnionVerify
	{
		// Token: 0x0601C12D RID: 114989 RVA: 0x003F7D8C File Offset: 0x003F5F8C
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
