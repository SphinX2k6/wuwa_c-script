using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061FC RID: 25084
	public static class IBattleStatePerceptionBehaviorType_UnionVerify
	{
		// Token: 0x0602B3BE RID: 177086 RVA: 0x005F4E14 File Offset: 0x005F3014
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
