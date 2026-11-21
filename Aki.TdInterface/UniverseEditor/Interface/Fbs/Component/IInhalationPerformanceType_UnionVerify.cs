using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598C RID: 22924
	public static class IInhalationPerformanceType_UnionVerify
	{
		// Token: 0x060255EE RID: 153070 RVA: 0x00520DD8 File Offset: 0x0051EFD8
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
