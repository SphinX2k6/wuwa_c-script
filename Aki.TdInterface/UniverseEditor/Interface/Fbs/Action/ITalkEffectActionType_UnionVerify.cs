using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A84 RID: 31364
	public static class ITalkEffectActionType_UnionVerify
	{
		// Token: 0x0603747E RID: 226430 RVA: 0x00761A98 File Offset: 0x0075FC98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkEffectActionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkEffectPlayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkEffectStopVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
