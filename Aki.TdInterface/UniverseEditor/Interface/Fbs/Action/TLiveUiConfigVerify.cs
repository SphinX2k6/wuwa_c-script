using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F2F RID: 32559
	public static class TLiveUiConfigVerify
	{
		// Token: 0x0603ABB0 RID: 240560 RVA: 0x007E5C18 File Offset: 0x007E3E18
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveUiFinishConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveUiHideConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveUiPauseConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiveUiResumeConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILiveUiShowConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILiveUiStartConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
