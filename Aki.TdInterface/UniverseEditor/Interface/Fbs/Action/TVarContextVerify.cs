using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FD RID: 30717
	public static class TVarContextVerify
	{
		// Token: 0x06037B63 RID: 228195 RVA: 0x00788374 File Offset: 0x00786574
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
