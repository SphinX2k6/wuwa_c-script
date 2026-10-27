using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F1 RID: 29425
	public static class ITalkItemPhoneMessageBase_UnionVerify
	{
		// Token: 0x06034E94 RID: 216724 RVA: 0x0072A9B0 File Offset: 0x00728BB0
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
