using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B0E RID: 31502
	public static class ITalkOptionParamType_UnionVerify
	{
		// Token: 0x06038B9A RID: 232346 RVA: 0x007AC4B0 File Offset: 0x007AA6B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkOptionParamTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkOptionQteSucceedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkOptionQteFailedVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkOptionQteSucceedDelayExecVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITalkOptionQteFailedDelayExecVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITalkOptionRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ITalkOptionPhoneMessageEmojiVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITalkOptionVisualNovelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
