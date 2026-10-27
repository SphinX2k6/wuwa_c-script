using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F5 RID: 17141
	public static class TPhotographTargetVerify
	{
		// Token: 0x060196C4 RID: 104132 RVA: 0x003A5268 File Offset: 0x003A3468
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
