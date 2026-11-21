using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200803B RID: 32827
	public static class TVarContextVerify
	{
		// Token: 0x0603B108 RID: 241928 RVA: 0x007EDCEC File Offset: 0x007EBEEC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBehaviorTreeFragmentContextVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonBtContextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityTemplateContextVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEntityVarContextVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILevelPlayVarContextVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestVarContextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
