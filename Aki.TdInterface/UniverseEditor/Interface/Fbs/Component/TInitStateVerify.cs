using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006269 RID: 25193
	public static class TInitStateVerify
	{
		// Token: 0x0602AE0E RID: 175630 RVA: 0x005DA698 File Offset: 0x005D8898
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInitStateBarrierLockVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInitStateBirthVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInitStateDigitalVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IInitStateMagneticStormVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IInitStateStandbyVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IInitStateWuYinQuVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
