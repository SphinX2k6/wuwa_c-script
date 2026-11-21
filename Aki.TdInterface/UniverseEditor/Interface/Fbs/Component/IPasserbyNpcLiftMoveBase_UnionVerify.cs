using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8F RID: 23695
	public static class IPasserbyNpcLiftMoveBase_UnionVerify
	{
		// Token: 0x060274DE RID: 160990 RVA: 0x00561BCC File Offset: 0x0055FDCC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcRideLiftLeaveOnArrivalMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcLiftMoveBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
