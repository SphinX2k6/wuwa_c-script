using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F4 RID: 30452
	public static class TInfrActivityBuildStageTypeVerify
	{
		// Token: 0x060375B7 RID: 226743 RVA: 0x0077F710 File Offset: 0x0077D910
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
