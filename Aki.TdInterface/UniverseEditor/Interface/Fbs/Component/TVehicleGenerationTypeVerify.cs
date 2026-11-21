using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006308 RID: 25352
	public static class TVehicleGenerationTypeVerify
	{
		// Token: 0x0602B106 RID: 176390 RVA: 0x005DEC0C File Offset: 0x005DCE0C
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
