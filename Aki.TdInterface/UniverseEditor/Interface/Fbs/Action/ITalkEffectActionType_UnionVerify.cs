using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AF RID: 29359
	public static class ITalkEffectActionType_UnionVerify
	{
		// Token: 0x0603417A RID: 213370 RVA: 0x007006FC File Offset: 0x006FE8FC
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
