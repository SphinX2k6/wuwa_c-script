using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC5 RID: 23749
	public static class IPasserbyNpcSpawnCenterPosBase_UnionVerify
	{
		// Token: 0x0602767A RID: 161402 RVA: 0x005648D4 File Offset: 0x00562AD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcSelfSpawnCenterPosVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcSpawnCenterPosBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
