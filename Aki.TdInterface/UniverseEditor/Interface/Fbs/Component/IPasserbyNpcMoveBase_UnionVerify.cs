using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C98 RID: 23704
	public static class IPasserbyNpcMoveBase_UnionVerify
	{
		// Token: 0x06027514 RID: 161044 RVA: 0x00562104 File Offset: 0x00560304
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPasserbyNpcMoveBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPasserbyNpcSplineMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPasserbyNpcLiftMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
