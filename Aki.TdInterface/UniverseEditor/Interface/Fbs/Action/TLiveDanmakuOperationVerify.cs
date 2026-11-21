using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F23 RID: 32547
	public static class TLiveDanmakuOperationVerify
	{
		// Token: 0x0603AB70 RID: 240496 RVA: 0x007E5614 File Offset: 0x007E3814
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveLoadDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveStartInteractDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveStopInteractDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiveUnloadDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
