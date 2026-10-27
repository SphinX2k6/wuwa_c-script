using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CA RID: 30666
	public static class TTalkOptionParamVerify
	{
		// Token: 0x06037A1B RID: 227867 RVA: 0x007861EC File Offset: 0x007843EC
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
