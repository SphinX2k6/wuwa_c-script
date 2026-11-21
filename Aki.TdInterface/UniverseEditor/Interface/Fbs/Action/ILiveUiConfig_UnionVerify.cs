using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713E RID: 28990
	public static class ILiveUiConfig_UnionVerify
	{
		// Token: 0x060325D5 RID: 206293 RVA: 0x006CF298 File Offset: 0x006CD498
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveUiConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveUiFinishConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveUiHideConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiveUiPauseConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILiveUiResumeConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILiveUiShowConfigVerify.Verify(verifier, tablePos);
				break;
			case 7:
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
