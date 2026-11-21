using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AE1 RID: 31457
	public static class ITalkItemStyle_UnionVerify
	{
		// Token: 0x0603833F RID: 230207 RVA: 0x007902E4 File Offset: 0x0078E4E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkItemStyleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkItemStyleInnerVoiceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkItemStylePhoneSendErrorVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
