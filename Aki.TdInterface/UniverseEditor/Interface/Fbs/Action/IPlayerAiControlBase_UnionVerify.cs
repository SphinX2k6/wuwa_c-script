using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007467 RID: 29799
	public static class IPlayerAiControlBase_UnionVerify
	{
		// Token: 0x060342AE RID: 213678 RVA: 0x007073D4 File Offset: 0x007055D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPlayerAiControlBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnablePlayerAiControlVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisablePlayerAiControlVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
