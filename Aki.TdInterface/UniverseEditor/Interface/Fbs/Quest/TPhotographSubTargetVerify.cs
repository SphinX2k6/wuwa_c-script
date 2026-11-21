using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004751 RID: 18257
	public static class TPhotographSubTargetVerify
	{
		// Token: 0x0601AE3A RID: 110138 RVA: 0x003D0A9C File Offset: 0x003CEC9C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPhotographSubTargetSpecificRoleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPhotographSubTargetAnyRoleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
