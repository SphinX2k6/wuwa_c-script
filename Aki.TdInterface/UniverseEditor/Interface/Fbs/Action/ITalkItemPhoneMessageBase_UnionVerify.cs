using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AC6 RID: 31430
	public static class ITalkItemPhoneMessageBase_UnionVerify
	{
		// Token: 0x0603819A RID: 229786 RVA: 0x0078BE14 File Offset: 0x0078A014
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkItemPhoneMessageBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkItemPhoneMessageVoiceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkItemPhoneMessageEmojiVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkItemPhoneMessageAttachmentVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITalkItemPhoneMessageSystemTipVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
