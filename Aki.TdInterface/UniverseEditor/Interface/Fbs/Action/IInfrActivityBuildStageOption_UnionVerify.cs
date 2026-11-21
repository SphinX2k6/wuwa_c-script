using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007000 RID: 28672
	public static class IInfrActivityBuildStageOption_UnionVerify
	{
		// Token: 0x06031AE7 RID: 203495 RVA: 0x006BA8C8 File Offset: 0x006B8AC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInfrActivityBuildStageOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInfrActivityInfrastructureStageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInfrActivityRoadProcessVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
