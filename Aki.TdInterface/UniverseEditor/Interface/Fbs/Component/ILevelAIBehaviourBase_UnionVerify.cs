using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A49 RID: 23113
	public static class ILevelAIBehaviourBase_UnionVerify
	{
		// Token: 0x06025CCF RID: 154831 RVA: 0x0052E900 File Offset: 0x0052CB00
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
