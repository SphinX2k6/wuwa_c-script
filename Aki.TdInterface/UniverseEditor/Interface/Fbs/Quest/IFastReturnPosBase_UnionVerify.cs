using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004264 RID: 16996
	public static class IFastReturnPosBase_UnionVerify
	{
		// Token: 0x06017AF7 RID: 97015 RVA: 0x00360F90 File Offset: 0x0035F190
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
