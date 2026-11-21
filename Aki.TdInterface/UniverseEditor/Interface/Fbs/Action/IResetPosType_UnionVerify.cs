using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200762F RID: 30255
	public static class IResetPosType_UnionVerify
	{
		// Token: 0x06035162 RID: 217442 RVA: 0x00721308 File Offset: 0x0071F508
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IResetPosTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IResetPosByPosEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IResetPosByResetPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
