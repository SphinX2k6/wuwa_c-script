using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C56 RID: 23638
	public static class TLevelAIBehaviourVerify
	{
		// Token: 0x06028850 RID: 165968 RVA: 0x00592BC8 File Offset: 0x00590DC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILevelAIBehaviourSplineVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractBehaviourActionsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
