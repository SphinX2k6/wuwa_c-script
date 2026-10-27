using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774E RID: 30542
	public static class TPhoneMessageTypeVerify
	{
		// Token: 0x060377CD RID: 227277 RVA: 0x00782C08 File Offset: 0x00780E08
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
