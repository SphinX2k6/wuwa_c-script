using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005406 RID: 21510
	public static class IInhalationPerformanceType_UnionVerify
	{
		// Token: 0x06023536 RID: 144694 RVA: 0x004E3DAC File Offset: 0x004E1FAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInhalationPerformanceTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRoleInhalationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneItemInhalationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
