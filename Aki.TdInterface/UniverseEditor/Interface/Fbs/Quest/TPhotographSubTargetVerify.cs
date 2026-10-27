using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F2 RID: 17138
	public static class TPhotographSubTargetVerify
	{
		// Token: 0x060196B8 RID: 104120 RVA: 0x003A516C File Offset: 0x003A336C
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
