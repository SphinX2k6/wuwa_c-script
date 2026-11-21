using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062AB RID: 25259
	public static class TPasserbyNpcSpawnVerify
	{
		// Token: 0x0602AF4A RID: 175946 RVA: 0x005DC3B4 File Offset: 0x005DA5B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcOnceOnConditionMetSpawnVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcFixIntervalSpawnVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
