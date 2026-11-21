using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008047 RID: 32839
	public static class TVillageInfrBuildTypeVerify
	{
		// Token: 0x0603B138 RID: 241976 RVA: 0x007EE11C File Offset: 0x007EC31C
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
