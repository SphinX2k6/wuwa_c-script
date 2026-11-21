using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F77 RID: 32631
	public static class TPhoneMessageTypeVerify
	{
		// Token: 0x0603AD0A RID: 240906 RVA: 0x007E7BDC File Offset: 0x007E5DDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkItemPhoneMessageAttachmentVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkItemPhoneMessageEmojiVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkItemPhoneMessageSystemTipVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkItemPhoneMessageVoiceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
