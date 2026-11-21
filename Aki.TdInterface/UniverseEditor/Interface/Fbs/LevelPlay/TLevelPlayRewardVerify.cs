using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A78 RID: 19064
	public static class TLevelPlayRewardVerify
	{
		// Token: 0x0601CA99 RID: 117401 RVA: 0x0040B10C File Offset: 0x0040930C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAutomaticRewardParamVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInteractRewardParamVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INoneRewardParamVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVariableRewardParamVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
