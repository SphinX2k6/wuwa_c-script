using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E7 RID: 29671
	public static class IPerformerAiMoveConfig_UnionVerify
	{
		// Token: 0x06033E76 RID: 212598 RVA: 0x006FF924 File Offset: 0x006FDB24
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPerformerAiMoveConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPerformerAiMoveToPositionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerformerAiMoveToEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPerformerAiMoveToPlayerVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
