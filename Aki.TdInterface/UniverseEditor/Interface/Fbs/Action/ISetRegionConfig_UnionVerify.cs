using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200782F RID: 30767
	public static class ISetRegionConfig_UnionVerify
	{
		// Token: 0x060361B4 RID: 221620 RVA: 0x0073FC50 File Offset: 0x0073DE50
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetRegionMpcVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetRegionConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
