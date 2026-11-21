using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686A RID: 26730
	public static class IBattleStatePerceptionBehaviorType_UnionVerify
	{
		// Token: 0x0602DB05 RID: 187141 RVA: 0x0063F888 File Offset: 0x0063DA88
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBattleStatePerceptionBehaviorTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPerceptionNotifyGatherToEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerceptionNotifyGatherToPlayerVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
