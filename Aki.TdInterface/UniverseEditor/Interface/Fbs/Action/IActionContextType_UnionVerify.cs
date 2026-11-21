using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DB RID: 26331
	public static class IActionContextType_UnionVerify
	{
		// Token: 0x0602C3ED RID: 181229 RVA: 0x006063CC File Offset: 0x006045CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActionContextTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityActionContextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFlowActionContextVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILevelPlayActionContextVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICommonBtActionContextVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestActionContextVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IGmActionContextVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IToolEditorActionContextVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICsvActionContextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
