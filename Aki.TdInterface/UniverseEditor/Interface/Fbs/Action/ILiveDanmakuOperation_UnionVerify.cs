using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070ED RID: 28909
	public static class ILiveDanmakuOperation_UnionVerify
	{
		// Token: 0x06032341 RID: 205633 RVA: 0x006CA76C File Offset: 0x006C896C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveDanmakuOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveLoadDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveUnloadDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiveStartInteractDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILiveStopInteractDanmakuConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
