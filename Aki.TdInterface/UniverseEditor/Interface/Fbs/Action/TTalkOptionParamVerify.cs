using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008002 RID: 32770
	public static class TTalkOptionParamVerify
	{
		// Token: 0x0603AFA0 RID: 241568 RVA: 0x007EB850 File Offset: 0x007E9A50
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkOptionPhoneMessageEmojiVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkOptionQteFailedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkOptionQteFailedDelayExecVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkOptionQteSucceedVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITalkOptionQteSucceedDelayExecVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITalkOptionRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 7:
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
