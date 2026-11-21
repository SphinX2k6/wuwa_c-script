using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200627B RID: 25211
	public static class TLevelAIBehaviourVerify
	{
		// Token: 0x0602AE5E RID: 175710 RVA: 0x005DADE0 File Offset: 0x005D8FE0
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
