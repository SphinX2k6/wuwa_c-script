using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C3 RID: 21699
	public static class ILevelAIBehaviourBase_UnionVerify
	{
		// Token: 0x06023C17 RID: 146455 RVA: 0x004F188C File Offset: 0x004EFA8C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILevelAIBehaviourBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILevelAIBehaviourSplineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInteractBehaviourActionsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
