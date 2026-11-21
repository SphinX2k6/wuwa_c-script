using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E38 RID: 32312
	public static class TActionContextVerify
	{
		// Token: 0x0603A646 RID: 239174 RVA: 0x007DD1D8 File Offset: 0x007DB3D8
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
