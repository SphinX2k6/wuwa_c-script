using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200618D RID: 24973
	public static class IAlertSystemOption_UnionVerify
	{
		// Token: 0x0602B043 RID: 176195 RVA: 0x005EF114 File Offset: 0x005ED314
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAlertSystemOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableAlertAreaVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IModifyAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEnableAlertUiVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
