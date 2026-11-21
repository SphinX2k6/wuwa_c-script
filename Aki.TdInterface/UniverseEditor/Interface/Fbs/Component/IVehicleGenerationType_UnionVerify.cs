using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006138 RID: 24888
	public static class IVehicleGenerationType_UnionVerify
	{
		// Token: 0x0602A3B5 RID: 172981 RVA: 0x005C372C File Offset: 0x005C192C
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
