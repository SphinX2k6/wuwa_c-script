using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007309 RID: 29449
	public static class ITalkItemStyle_UnionVerify
	{
		// Token: 0x0603501D RID: 217117 RVA: 0x0072EACC File Offset: 0x0072CCCC
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
