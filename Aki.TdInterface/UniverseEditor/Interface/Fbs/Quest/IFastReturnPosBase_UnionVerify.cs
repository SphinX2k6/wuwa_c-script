using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E29 RID: 15913
	public static class IFastReturnPosBase_UnionVerify
	{
		// Token: 0x060164CA RID: 91338 RVA: 0x00338398 File Offset: 0x00336598
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFastReturnPosBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFastReturnEntityPosVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFastReturnGravityEntityPosVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
