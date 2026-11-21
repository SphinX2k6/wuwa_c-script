using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B56 RID: 31574
	public static class ITeamType_UnionVerify
	{
		// Token: 0x06038DB8 RID: 232888 RVA: 0x007AFE68 File Offset: 0x007AE068
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITeamTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICurrentTeamVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBattleTeamVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFlowTeamVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
