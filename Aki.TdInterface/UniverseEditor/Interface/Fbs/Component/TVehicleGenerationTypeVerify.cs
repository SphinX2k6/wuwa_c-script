using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD4 RID: 23764
	public static class TVehicleGenerationTypeVerify
	{
		// Token: 0x06028AB2 RID: 166578 RVA: 0x0059639C File Offset: 0x0059459C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVehicleGenerateByVehicleTeamTemplateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVehicleGenerateByVehicleEntityTemplateVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
