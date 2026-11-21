using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E4E RID: 32334
	public static class TAlertSystemOptionVerify
	{
		// Token: 0x0603A6BC RID: 239292 RVA: 0x007DDD7C File Offset: 0x007DBF7C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnableAlertAreaVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableAlertUiVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IModifyAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISetAlertUiVisibleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
