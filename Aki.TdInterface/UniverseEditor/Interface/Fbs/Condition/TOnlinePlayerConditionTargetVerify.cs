using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D4D RID: 19789
	public static class TOnlinePlayerConditionTargetVerify
	{
		// Token: 0x0601F679 RID: 128633 RVA: 0x00460404 File Offset: 0x0045E604
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOnlinePlayerConditionTargetParticipatorVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOnlinePlayerConditionTargetHostVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
