using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F8 RID: 26616
	public static class IAlertSystemOption_UnionVerify
	{
		// Token: 0x0602D774 RID: 186228 RVA: 0x00639988 File Offset: 0x00637B88
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
