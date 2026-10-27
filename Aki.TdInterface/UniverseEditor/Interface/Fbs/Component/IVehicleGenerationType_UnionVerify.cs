using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B22 RID: 23330
	public static class IVehicleGenerationType_UnionVerify
	{
		// Token: 0x06027DF1 RID: 163313 RVA: 0x0057BCD8 File Offset: 0x00579ED8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVehicleGenerationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVehicleGenerateByVehicleEntityTemplateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVehicleGenerateByVehicleTeamTemplateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
