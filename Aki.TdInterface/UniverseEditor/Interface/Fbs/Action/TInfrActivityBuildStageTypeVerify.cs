using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F08 RID: 32520
	public static class TInfrActivityBuildStageTypeVerify
	{
		// Token: 0x0603AA84 RID: 240260 RVA: 0x007E3C1C File Offset: 0x007E1E1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInfrActivityRoadProcessVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInfrActivityInfrastructureStageVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
