using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007640 RID: 30272
	public static class TAlertSystemOptionVerify
	{
		// Token: 0x06037217 RID: 225815 RVA: 0x00779C80 File Offset: 0x00777E80
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
