using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200762A RID: 30250
	public static class TActionContextVerify
	{
		// Token: 0x060371A1 RID: 225697 RVA: 0x007790DC File Offset: 0x007772DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonBtActionContextVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICsvActionContextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityActionContextVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFlowActionContextVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IGmActionContextVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILevelPlayActionContextVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IQuestActionContextVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IToolEditorActionContextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
