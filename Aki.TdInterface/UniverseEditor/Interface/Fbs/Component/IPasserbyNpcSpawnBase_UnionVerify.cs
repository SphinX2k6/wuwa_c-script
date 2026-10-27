using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D9 RID: 22233
	public static class IPasserbyNpcSpawnBase_UnionVerify
	{
		// Token: 0x06025239 RID: 152121 RVA: 0x00520544 File Offset: 0x0051E744
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcFixIntervalSpawnVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcSpawnBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
