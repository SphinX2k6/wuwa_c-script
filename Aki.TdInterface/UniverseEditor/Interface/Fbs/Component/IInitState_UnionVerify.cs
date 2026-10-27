using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005430 RID: 21552
	public static class IInitState_UnionVerify
	{
		// Token: 0x0602367E RID: 145022 RVA: 0x004E5FD8 File Offset: 0x004E41D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInitStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInitStateBirthVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInitStateStandbyVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IInitStateMagneticStormVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IInitStateWuYinQuVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IInitStateBarrierLockVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IInitStateDigitalVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
