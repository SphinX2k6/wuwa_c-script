using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C7 RID: 30663
	public static class TTalkItemStyleVerify
	{
		// Token: 0x06037A05 RID: 227845 RVA: 0x00785FEC File Offset: 0x007841EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITalkItemStylePhoneSendErrorVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITalkItemStyleInnerVoiceVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
