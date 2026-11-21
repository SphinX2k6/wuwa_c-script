using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBF RID: 23743
	public static class IPasserbyNpcSpawnBase_UnionVerify
	{
		// Token: 0x0602765C RID: 161372 RVA: 0x0056464C File Offset: 0x0056284C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPasserbyNpcSpawnBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPasserbyNpcFixIntervalSpawnVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPasserbyNpcOnceOnConditionMetSpawnVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
