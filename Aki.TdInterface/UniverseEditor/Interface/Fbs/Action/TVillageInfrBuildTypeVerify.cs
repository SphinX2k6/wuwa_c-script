using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007809 RID: 30729
	public static class TVillageInfrBuildTypeVerify
	{
		// Token: 0x06037B93 RID: 228243 RVA: 0x007887A4 File Offset: 0x007869A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVillageInfrVillageLevelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVillageInfrTreeProcessVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
