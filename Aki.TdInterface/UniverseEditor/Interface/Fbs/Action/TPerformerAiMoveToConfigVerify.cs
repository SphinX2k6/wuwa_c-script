using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F74 RID: 32628
	public static class TPerformerAiMoveToConfigVerify
	{
		// Token: 0x0603ACFA RID: 240890 RVA: 0x007E7A5C File Offset: 0x007E5C5C
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
