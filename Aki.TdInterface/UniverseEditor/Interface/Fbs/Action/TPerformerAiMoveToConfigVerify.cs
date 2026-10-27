using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774B RID: 30539
	public static class TPerformerAiMoveToConfigVerify
	{
		// Token: 0x060377BD RID: 227261 RVA: 0x00782A88 File Offset: 0x00780C88
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPerformerAiMoveToEntityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPerformerAiMoveToPlayerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerformerAiMoveToPositionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
