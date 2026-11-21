using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CEB RID: 31979
	public static class IVarContext_UnionVerify
	{
		// Token: 0x06039B31 RID: 236337 RVA: 0x007C8AB4 File Offset: 0x007C6CB4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVarContextVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityVarContextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestVarContextVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILevelPlayVarContextVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEntityTemplateContextVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBehaviorTreeFragmentContextVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICommonBtContextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
