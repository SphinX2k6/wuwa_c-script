using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004754 RID: 18260
	public static class TPhotographTargetVerify
	{
		// Token: 0x0601AE46 RID: 110150 RVA: 0x003D0B98 File Offset: 0x003CED98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPhotographTargetRolesOnSceneVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPhotographTargetPlayerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
