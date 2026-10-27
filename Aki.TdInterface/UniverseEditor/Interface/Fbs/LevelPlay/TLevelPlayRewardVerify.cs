using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004610 RID: 17936
	public static class TLevelPlayRewardVerify
	{
		// Token: 0x0601B2C4 RID: 111300 RVA: 0x003DEE70 File Offset: 0x003DD070
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
