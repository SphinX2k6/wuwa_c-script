using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200800E RID: 32782
	public static class TTeamTypeVerify
	{
		// Token: 0x0603AFE6 RID: 241638 RVA: 0x007EBF80 File Offset: 0x007EA180
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBattleTeamVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICurrentTeamVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
