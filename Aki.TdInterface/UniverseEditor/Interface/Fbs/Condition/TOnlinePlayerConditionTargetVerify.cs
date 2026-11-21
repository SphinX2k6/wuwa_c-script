using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005249 RID: 21065
	public static class TOnlinePlayerConditionTargetVerify
	{
		// Token: 0x060212C2 RID: 135874 RVA: 0x004943D8 File Offset: 0x004925D8
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
