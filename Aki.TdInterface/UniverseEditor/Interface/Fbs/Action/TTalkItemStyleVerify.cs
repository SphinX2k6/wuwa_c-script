using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FFF RID: 32767
	public static class TTalkItemStyleVerify
	{
		// Token: 0x0603AF8A RID: 241546 RVA: 0x007EB638 File Offset: 0x007E9838
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkItemStyleInnerVoiceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkItemStylePhoneSendErrorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkItemStyleSceneUiSubtitleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
